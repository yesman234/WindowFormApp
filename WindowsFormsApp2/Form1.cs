using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
              
                if (op.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text= op.FileName;
                }

            }
            catch { }
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void TxtPath_TextChanged(object sender, EventArgs e)
        {
        }


   

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines(txtPath.Text.TrimStart());
                foreach (String line in lines)
                {
                    listView1.Items.Add(line);
                }

            }


            catch { }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines(txtPath.Text.TrimStart());
                foreach (String line in lines)
                {
                    listView1.Items.Add(line);
                }

            }


            catch { }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //creating a new Collections list to query through
            List<Employees> teachers = new List<Employees>()
            {
                try
            {
                string[] lines = File.ReadAllLines(txtPath.Text.TrimStart());
                foreach (String line in lines)
                {
                    listView1.Items.Add(line);
                }

            }


            catch { }
        }
        //tis is where a query setting is being set to null , waiting for user input
             var UserInput = (from employee in data
                                    where employee.firstName == "Userinput"
                                    select employee.lastLast)
                    .Concat(from employee in data
                            where employee.firstName == "UserInput"
                            select employee.Last);
        }
    } 
}
