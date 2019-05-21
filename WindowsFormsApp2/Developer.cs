using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Developers:employee
    {
        string Devtype;
        string Supervisor;
        string TaxType;
    
    public string DevelopType
        {
            get { return Devtype; }
            set { Devtype = value; }
        }
    }
}
