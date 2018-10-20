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

namespace AccountSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string inputFile;
            string outputFile;
            string key;

            inputFile = string.Format("./accounts/{0}.acct", accountNumberBox.Text);
            outputFile = string.Format("./accounts/{0}.acctx", accountNumberBox.Text);

            try
            {
                if(Program.CreateAccount(firstNameBox.Text, middleNameBox.Text, lastNameBox.Text, int.Parse(accountNumberBox.Text), double.Parse(balanceBox.Text)) == 0)
                {    
                    try
                    {
                        if (encryptBox.Checked)
                        {
                            Program.EncryptFile(inputFile, outputFile, "1111111111111111");
                            detailsBox.Text = File.ReadAllText(inputFile);
                        }
                        else
                        {
                            detailsBox.Text = File.ReadAllText(inputFile);
                        }
                    }
                    catch
                    {
                        
                    }
                    accountCreationTrueLabel.Text = "Account Creation Successful";
                }
                
            }
            catch
            {
                accountCreationTrueLabel.Text = "Account Creation Failed";
            }
            

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = null;
            string[] dirs = Directory.GetDirectories("./accounts");
            string[] files = Directory.GetFiles("./accounts");


            foreach (string dir in dirs)
            {
                textBox1.Text += string.Format("{0}", dir + Environment.NewLine);
            }
            foreach (string file in files)
            {
                textBox1.Text += string.Format("{0}", file + Environment.NewLine);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            string inputFile;
            string outputFile;
            string key;

            inputFile = string.Format("./accounts/{0}.acctx", accountNumberBox.Text);
            outputFile = string.Format("./accounts/{0}.acctd", accountNumberBox.Text);

            
                Program.DecryptFile(inputFile, outputFile, "1111111111111111");
                detailsBox.Text = File.ReadAllText(outputFile);
            
            
                //detailsBox.Text = string.Format("Unable to Decrypt Account #: {0}", accountNumberBox.Text);
            
        }
    }
}
