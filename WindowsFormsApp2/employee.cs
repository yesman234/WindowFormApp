using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Employee
    {
        #region Private Variables
        private string fName;
        private string lName;
        private string sAddress;
        private string city;
        private string state;
        private string zip;
        private string empType;
        #endregion

        #region Public Properties
        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string LastName
        {
            get { return lName; }
            set { lName = value; }
        }
        public string StreetAddress
        {
            get { return sAddress; }
            set { sAddress = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }
        public string EmployeeType
        {
            get { return empType; }
            set { empType = value; }
        }
        #endregion
    }
}
