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
    public partial class FrmAdd : Form
    {
        public delegate void SendData(Patient patient);
        public event SendData send;
        public int currentPatientNum { get; set; }
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtAddress.Text) || String.IsNullOrEmpty(txtTelephone.Text))
                MessageBox.Show("Please fill all blanks");
            else
            {
                File.Copy(pbAvatar.ImageLocation, System.Environment.CurrentDirectory +"/Data/Pictures/" + txtRecord.Text + Path.GetExtension(pbAvatar.ImageLocation),true);
                send(new Patient(Convert.ToInt32(txtRecord.Text),txtName.Text,txtAddress.Text,txtTelephone.Text,
                                 rbMale.Checked == true? "Male" : "Female",dtpDOB.Value,"Data/Pictures/" + txtRecord.Text + Path.GetExtension(pbAvatar.ImageLocation)));
                this.Close();
            }
            
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FileDialog file = new OpenFileDialog();
            file.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            file.ShowDialog(); // show dialog
            if(!String.IsNullOrEmpty(file.FileName))
                pbAvatar.ImageLocation = file.FileName;
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            txtRecord.Text = (currentPatientNum + 1).ToString();
        }

    }
}
