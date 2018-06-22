using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class FrmResearch : Form
    {
        public delegate void SendData(string dataType,DateTime DOB,string value);
        public event SendData send;
        public bool isFound { get; set; }
        public FrmResearch()
        {
            InitializeComponent();
        }
        //
        //Events
        //
        private void rbDOB_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDOB.Checked)
            {
                dtpDOB.Visible = true;
                txtValue.Visible = false;
            }
            else
            {
                dtpDOB.Visible = false;
                txtValue.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            if (rbRecord.Checked)
            {
                int isConverted;
                bool canConverted = Int32.TryParse(txtValue.Text, out isConverted);
                if (!canConverted)
                {
                    MessageBox.Show("Invalid Record!");
                    return;
                }
            }         
            this.isFound = false;
            string checkedButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            switch (checkedButton)
            {
                case "Date of birth":
                    send("Date of birth", dtpDOB.Value, null);
                    break;
                default:
                    send(checkedButton, new DateTime() , txtValue.Text);
                    break;
            }
            this.Close();
        }

        private void FrmResearch_Load(object sender, EventArgs e)
        {
            this.isFound = false;
        }
    }
}
