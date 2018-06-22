using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement
{
    public class Patient
    {
        public int Record { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Sex { get; set; }
        public DateTime DOB { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - DOB.Year;
            }
        }
        public string Picture { get; set; }
        public Patient(int Record, string Name, string Address, 
                       string Telephone, string Sex, DateTime DOB, string Picture)
        {
            this.Record = Record;
            this.Name = Name;
            this.Address = Address;
            this.Telephone = Telephone;
            this.Sex = Sex;
            this.DOB = DOB;
            this.Picture = Picture;
        }
        public Patient()
        {

        }
    }
}
