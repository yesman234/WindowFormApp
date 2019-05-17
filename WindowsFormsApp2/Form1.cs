using System;
using System.IO;
using System.Windows.Forms;


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


        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    var myStringCollection = Properties.Settings.Default.MyCollection;
                    foreach (String value in myStringCollection)
                    {
                        listView1.Items.Add(myStringCollection);
                    }
                   
                }
                catch
                {

                }
            }
            catch { }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string[] lines = System.IO.File.ReadAllLines(txtPath.Text.TrimStart());
                    foreach (string line in lines)
                    {
                        listView1.Items.Add(line);
                    }
                }
                catch
                {

                }
            }
            catch { }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string[] lines = System.IO.File.ReadAllLines(txtPath.Text.TrimStart());
                    foreach (string line in lines)
                    {
                        listView1.Items.Add(line);
                    }
                }
                catch
                {

                }
            }
            catch { }
        }
    } 
}
