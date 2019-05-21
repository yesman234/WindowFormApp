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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        #region Constructors
        public Form1()
        {
            InitializeComponent();
        }
        #endregion


        #region Control/Form Event Handlers
        private void btnProcess_Click(object sender, EventArgs e)
        {
            //Open the file dialog so the user can select the file
            ofdMain.ShowDialog();

            //If the filename in the dialog is not empty, load and parse the file
            if (!string.IsNullOrEmpty(ofdMain.FileName))
            {
                //Load all file lines into a string array
                string[] fileLines = File.ReadAllLines(ofdMain.FileName);

                //Declare LIST to contain Managers
                List<Managers> mgrList = new List<Managers>();

                //Declare LIST to contain Developers
                List<Developers> devList = new List<Developers>();

                //Declare temp Mgr Object & temp Dev Object
                Managers tmpManager;
                Developers tmpDeveloper;

                //Parse each line of data in the fileLines array, 
                foreach (string lineData in fileLines)
                {
                    if (lineData.Split('|')[6] == "Manager")
                    {
                        tmpManager = new Managers();
                        tmpManager.FirstName = lineData.Split('|')[0];
                        tmpManager.LastName = lineData.Split('|')[1];
                        tmpManager.StreetAddress = lineData.Split('|')[2];
                        tmpManager.City = lineData.Split('|')[3];
                        tmpManager.State = lineData.Split('|')[4];
                        tmpManager.Zip = lineData.Split('|')[5];
                        tmpManager.EmployeeType = lineData.Split('|')[6];
                        tmpManager.CostCenter = lineData.Split('|')[7];
                        tmpManager.Supervisor = lineData.Split('|')[8];

                        mgrList.Add(tmpManager);
                    }
                    else if (lineData.Split('|')[6] == "Developer")
                    {
                        tmpDeveloper = new Developers();
                        tmpDeveloper.FirstName = lineData.Split('|')[0];
                        tmpDeveloper.LastName = lineData.Split('|')[1];
                        tmpDeveloper.StreetAddress = lineData.Split('|')[2];
                        tmpDeveloper.City = lineData.Split('|')[3];
                        tmpDeveloper.State = lineData.Split('|')[4];
                        tmpDeveloper.Zip = lineData.Split('|')[5];
                        tmpDeveloper.EmployeeType = lineData.Split('|')[6];
                        tmpDeveloper.Supervisor = lineData.Split('|')[9];
                        tmpDeveloper.DeveloperType = lineData.Split('|')[7];
                        tmpDeveloper.TaxType = lineData.Split('|')[10];

                        devList.Add(tmpDeveloper);
                    }
                }

                //Define Data Table & columns for output
                DataTable dtOut = new DataTable();
                dtOut.Columns.Add("name");
                dtOut.Columns.Add("address");
                dtOut.Columns.Add("empType");
                dtOut.Columns.Add("supervisor");
                dtOut.Columns.Add("costcenter");
                dtOut.Columns.Add("devtype");
                dtOut.Columns.Add("taxtype");
                DataRow newRow;

                //Display records based on number selected              
                int devLlistMax = 0;
                int mgrLlistMax = 0;
                if (rbShow3.Checked)
                {
                    if (devList.Count < 3) devLlistMax = devList.Count;
                    else devLlistMax = 3;

                    if (mgrList.Count < 3) mgrLlistMax = mgrList.Count;
                    else mgrLlistMax = 3;
                }
                else if (rbShow5.Checked)
                {
                    if (devList.Count < 5) devLlistMax = devList.Count;
                    else devLlistMax = 5;

                    if (mgrList.Count < 5) mgrLlistMax = mgrList.Count;
                    else mgrLlistMax = 5;
                }
                else
                {
                    devLlistMax = devList.Count;
                    mgrLlistMax = mgrList.Count;
                }

                //Loop through list of developers, create rows and add to table
                for (int listIdx = 0; listIdx < devLlistMax; listIdx++)
                {
                    newRow = dtOut.NewRow();
                    newRow["name"] = devList[listIdx].FirstName + " " + devList[listIdx].LastName;
                    newRow["address"] = devList[listIdx].StreetAddress + "  " + devList[listIdx].City + ", " + devList[listIdx].State + "  " + devList[listIdx].Zip;
                    newRow["supervisor"] = devList[listIdx].Supervisor;
                    newRow["empType"] = devList[listIdx].EmployeeType;
                    newRow["costcenter"] = string.Empty;
                    newRow["devtype"] = devList[listIdx].DeveloperType;
                    newRow["taxtype"] = devList[listIdx].TaxType;
                    dtOut.Rows.Add(newRow);
                }

                //Loop through list of managers, create rows and add to table
                for (int listIdx = 0; listIdx < mgrLlistMax; listIdx++)
                {
                    newRow = dtOut.NewRow();
                    newRow["name"] = mgrList[listIdx].FirstName + " " + mgrList[listIdx].LastName;
                    newRow["address"] = mgrList[listIdx].StreetAddress + "  " + mgrList[listIdx].City + ", " + mgrList[listIdx].State + "  " + mgrList[listIdx].Zip;
                    newRow["supervisor"] = mgrList[listIdx].Supervisor;
                    newRow["empType"] = mgrList[listIdx].EmployeeType;
                    newRow["costcenter"] = mgrList[listIdx].CostCenter;
                    newRow["devtype"] = string.Empty;
                    newRow["taxtype"] = string.Empty;
                    dtOut.Rows.Add(newRow);
                }

                //Assign the Data Table as the data source for the grid view
                dgvEmployees.DataSource = dtOut;
            }
            else
            { MessageBox.Show("Please Select a File to Load."); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

    }
}
