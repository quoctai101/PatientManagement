using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PatientManagement
{
    public partial class FrmUpdate : Form
    {
        public List<Patient> Patients { get; set; }
        public int currentRecord { get; set; }
        public FrmUpdate()
        {
            InitializeComponent();
        }
        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            changeProfile(currentRecord);
        }
        //
        //Support function
        //
        private bool checkChanged()
        {
            int currentRecord = Convert.ToInt32(txtRecord.Text);
            Patient currentPatient = Patients[currentRecord - 1];
            string currentSex = rbMale.Checked ? "Male" : "Female";
            if (currentPatient.Name != txtName.Text ||
                currentPatient.Address != txtAddress.Text ||
                currentPatient.Telephone != txtTelephone.Text ||
                currentPatient.Sex != currentSex ||
                currentPatient.DOB.Date != dtpDOB.Value.Date)
                return true;
            else return false;

        }
        private bool checkEmpty()
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtAddress.Text) || String.IsNullOrEmpty(txtTelephone.Text))
            {
                MessageBox.Show("Please fill all blanks");
                return true;
            }
            return false;
        }
        private void changeProfile(int Record)
        {
            Patient currentPatient = Patients.Find(x => x.Record == Record);
            txtName.Text = currentPatient.Name;
            txtAddress.Text = currentPatient.Address;
            txtTelephone.Text = currentPatient.Telephone;
            if (currentPatient.Sex.Equals("Male")) rbMale.Checked = true;
            else rbFemale.Checked = true;
            dtpDOB.Value = currentPatient.DOB;
            txtRecord.Text = currentPatient.Record.ToString();
            pbAvatar.ImageLocation = currentPatient.Picture;
        }
        private void confirmSave(object sender, EventArgs e)
        {
            DialogResult doSave = MessageBox.Show("Do you want to save this patient?","Update",MessageBoxButtons.YesNo);
            if(doSave == DialogResult.Yes)
            {
                btnSave_Click(sender, e);
            }
        }
        //
        //Events
        //
        private void txtRecord_TextChanged(object sender, EventArgs e)
        {
            int currentRecord = Convert.ToInt32(txtRecord.Text);
            changeProfile(currentRecord);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                if (checkChanged()) confirmSave(sender, e);
                int currentRecord = Convert.ToInt32(txtRecord.Text);
                if (currentRecord > 1)
                    txtRecord.Text = (Convert.ToInt32(txtRecord.Text) - 1).ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                if (checkChanged()) confirmSave(sender, e);
                int currentRecord = Convert.ToInt32(txtRecord.Text);
                if (currentRecord < Patients.Count)
                    txtRecord.Text = (Convert.ToInt32(txtRecord.Text) + 1).ToString();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {

            if (!checkEmpty())
            {
                if (checkChanged()) confirmSave(sender, e);
                txtRecord.Text = "1";
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                if (checkChanged()) confirmSave(sender, e);
                txtRecord.Text = Patients.Count.ToString();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FileDialog file = new OpenFileDialog();
            file.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            file.ShowDialog(); // show dialog
            if (!String.IsNullOrEmpty(file.FileName))
                pbAvatar.ImageLocation = file.FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                int currentRecord = Convert.ToInt32(txtRecord.Text);
                Patient currentPatient = Patients[currentRecord - 1];
                currentPatient.Name = txtName.Text;
                currentPatient.Address = txtAddress.Text;
                currentPatient.Telephone = txtTelephone.Text;
                currentPatient.Sex = rbMale.Checked ? "Male" : "Female";
                currentPatient.DOB = dtpDOB.Value.Date;
                if (pbAvatar.ImageLocation != currentPatient.Picture)
                    File.Copy(pbAvatar.ImageLocation, System.Environment.CurrentDirectory + "/Data/Pictures/" + txtRecord.Text + Path.GetExtension(pbAvatar.ImageLocation), true);
                currentPatient.Picture = "Data/Pictures/" + txtRecord.Text + Path.GetExtension(pbAvatar.ImageLocation);
            }
        }
    }
}
