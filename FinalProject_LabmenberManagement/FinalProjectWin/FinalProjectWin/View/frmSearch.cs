using FinalProjectWin.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalProjectWin.View
{
    public partial class frmSearch : Form
    {
        Clsdatabase cls = new Clsdatabase();

        public frmSearch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int i = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            i = 4;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "") || (textBox1.Text == ""))
                {
                    MessageBox.Show("Enter key word", "Enter key word", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (i == 1)
                    {
                        cls.loaddatagridview(dataGridView1, "select * from BasicInformation where ID=N'" + textBox1.Text + "'");
                    }
                    if (i == 2)
                    {
                        cls.loaddatagridview(dataGridView1, "select * from BasicInformation where FullName=N'" + textBox1.Text + "'");
                    }
                    if (i == 3)
                    {
                        cls.loaddatagridview(dataGridView1, "select * from BasicInformation where IC=N'" + textBox1.Text + "'");
                    }
                    if (i == 4)
                    {
                        cls.loaddatagridview(dataGridView1, "select * from BasicInformation where ProjectID=N'" + textBox1.Text + "'");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Fail");
            }

        }
        private void frmtimkiem_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            cls.loaddatagridview(dataGridView1, "select * from BasicInformation");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "") || (textBox1.Text == ""))
                {
                    cls.loaddatagridview(dataGridView1, "select * from BasicInformation");
                }
                else
                {
                    if (i == 1)
                    {
                        cls.loatextbox(textBox1, "select * from BasicInformation where ID like N'" + textBox1.Text + "%'", 2);
                        cls.loaddatagridview(dataGridView1, "select * from BasicInformation where ID like N'" + textBox1.Text + "%'");
                    }
                    if (i == 2)
                    {
                        cls.loatextbox(textBox1, "select * from BasicInformation where ID like N'" + textBox1.Text + "%'", 3);
                        cls.loaddatagridview(dataGridView1, "select * from BasicInformation where FullName like N'" + textBox1.Text + "%'");
                    }
                    if (i == 3)
                    {
                        cls.loatextbox(textBox1, "select * from BasicInformation where ID like N'" + textBox1.Text + "%'", 8);
                        cls.loaddatagridview(dataGridView1, "select * from BasicInformation where IC like N'" + textBox1.Text + "%'");
                    }
                    if (i == 4)
                    {
                        cls.loatextbox(textBox1, "select * from BasicInformation where ID like N'" + textBox1.Text + "%'", 0);
                        cls.loaddatagridview(dataGridView1, "select * from BasicInformation where ProjectID like N'" + textBox1.Text + "%'");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
        }
    }
}
