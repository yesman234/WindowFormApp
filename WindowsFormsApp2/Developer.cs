using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Developers : Employee
    {
        #region Private Members
        private string devDevType;
        private string devSupervisor;
        private string devTaxType;
        #endregion

        #region Public Properties
        public string DeveloperType
        {
            get { return devDevType; }
            set { devDevType = value; }
        }
        public string Supervisor
        {
            get { return devSupervisor; }
            set { devSupervisor = value; }
        }
        public string TaxType
        {
            get { return devTaxType; }
            set { devTaxType = value; }
        }
        #endregion
    }
}
