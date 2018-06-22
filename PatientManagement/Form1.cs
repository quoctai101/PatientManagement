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
using System.Web.Script.Serialization;

namespace PatientManagement
{

    public partial class FrmPatientManager : Form
    {
        private List<Patient> lstPatients = new List<Patient>();
        public FrmPatientManager()
        {
            InitializeComponent();
        }
        //
        //Load data
        //
        private void FrmPatientManager_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("Data/Profiles.json");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string json = reader.ReadToEnd();
            lstPatients = serializer.Deserialize<List<Patient>>(json);
            reader.Close();
            changeProfile(1);
        }
        //
        //Support Function
        //
        private void saveData()
        {
            StreamWriter writer = new StreamWriter("Data/Profiles.json");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string json = serializer.Serialize(lstPatients);
            writer.Write(json);
            writer.Close();
        }
        private void changeProfile(int Record)
        {
            Patient currentPatient = lstPatients.Find(x => x.Record == Record);
            txtName.Text = currentPatient.Name;
            txtAddress.Text = currentPatient.Address;
            txtTelephone.Text = currentPatient.Telephone;
            if (currentPatient.Sex.Equals("Male")) txtSex.Text = "Male";
            else txtSex.Text = "Female";
            txtDOB.Text = currentPatient.DOB.Date.ToString("dd/MM/yyyy");
            txtRecord.Text = currentPatient.Record.ToString();
            pbAvatar.ImageLocation = currentPatient.Picture;
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
            int currentRecord = Convert.ToInt32(txtRecord.Text);
            if (currentRecord > 1)
                txtRecord.Text = (Convert.ToInt32(txtRecord.Text) - 1).ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int currentRecord = Convert.ToInt32(txtRecord.Text);
            if (currentRecord < lstPatients.Count)
                txtRecord.Text = (Convert.ToInt32(txtRecord.Text) + 1).ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            txtRecord.Text = "1";
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            txtRecord.Text = lstPatients.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAdd frmAdd = new FrmAdd();
            frmAdd.currentPatientNum = lstPatients.Count;
            frmAdd.send += FrmAdd_send;
            frmAdd.ShowDialog();
        }
        private void FrmAdd_send(Patient patient)
        {
            lstPatients.Add(patient);
            saveData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdate frmUpdate = new FrmUpdate();
            frmUpdate.Patients = lstPatients;
            frmUpdate.currentRecord = Convert.ToInt32(txtRecord.Text);
            frmUpdate.ShowDialog();
            int currentRecord = Convert.ToInt32(txtRecord.Text);
            if (currentRecord > 1 && currentRecord < lstPatients.Count) changeProfile(currentRecord - 1);
            else changeProfile(2);
            changeProfile(currentRecord);
            saveData();
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            FrmResearch frmResearch = new FrmResearch();
            frmResearch.send += FrmResearch_send;
            frmResearch.ShowDialog();
        }

        private void FrmResearch_send(string dataType, DateTime DOB, string value)
        {
            Patient foundPatient = null;
            switch (dataType)
            {
                case "Date of birth":
                    foundPatient = lstPatients.Find(x => x.DOB.Date == DOB.Date);
                    break;
                case "Name":
                    foundPatient = lstPatients.Find(x => x.Name == value);
                    break;
                case "Address":
                    foundPatient = lstPatients.Find(x => x.Address == value);
                    break;
                case "Telephone":
                    foundPatient = lstPatients.Find(x => x.Telephone == value);
                    break;
                case "Record":
                    foundPatient = lstPatients.Find(x => x.Record == Convert.ToInt32(value));
                    break;
            }
            if (foundPatient != null)
            {
                changeProfile(foundPatient.Record);
            }
            else
            {
                MessageBox.Show("Not found!");
            }
        }

        private void toolbtnAdd_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void toolbtnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate_Click(sender, e);
        }

        private void toolbtnResearch_Click(object sender, EventArgs e)
        {
            btnResearch_Click(sender, e);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUpdate_Click(sender, e);
        }

        private void researchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnResearch_Click(sender, e);
        }
    }
}
