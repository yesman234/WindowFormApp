using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Managers : Employee
    {
        #region Private Members
        private string mgrCostCenter;
        private string mgrSupervisor;
        #endregion

        #region Public Properties
        public string CostCenter
        {
            get { return mgrCostCenter; }
            set { mgrCostCenter = value; }
        }
        public string Supervisor
        {
            get { return mgrSupervisor; }
            set { mgrSupervisor = value; }
        }
        #endregion
    }
}
