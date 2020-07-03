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
    public partial class frmTask : Form
    {
        public frmTask()
        {
            InitializeComponent();
        }
        Clsdatabase cls = new Clsdatabase();
        private void frmTask_Load(object sender, EventArgs e)
        {          
            cls.loaddatagridview(dataGridView1, "select * from Task");
            cls.loadcombobox(comboBox1, "select * from Project", 0);
            cls.loadcombobox(comboBox2, "select * from BasicInformation", 2);         
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
        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cls.kttrungkhoa(textBox1.Text, "select TaskID from Task"))
                {
                    string insert = "insert into Task values('" + comboBox1.Text +  "',N'" + textBox3.Text + "',N'" + comboBox2.Text + "',N'" + textBox5.Text + "',N'" + textBox1.Text + "')";
                    cls.thucthiketnoi(insert);
                    cls.loaddatagridview(dataGridView1, "select * from Task");
                }
                else
                {
                    MessageBox.Show("Exist", "Same", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Incorrect data");
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            comboBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();         
            textBox1.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update Task set ProjectID=N'" + comboBox1.Text + "',TaskName=N'" + textBox3.Text + "',ID=N'" + comboBox2.Text + "',Description=N'" + textBox5.Text + "' where TaskID=N'" + textBox1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from Task");
                MessageBox.Show("success");
            }
            catch
            {
                MessageBox.Show("incorrect data");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string del = "delete from Task where TaskID=N'" + textBox1.Text + "'";
                if (MessageBox.Show("Delete?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(del);
                    cls.loaddatagridview(dataGridView1, "select * from Task");
                }
            }
            catch
            {
                MessageBox.Show("Incorrect Data");
            }
        }       
        private void Button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                if ((textBox2.Text == "") || (textBox2.Text == ""))
                {
                    MessageBox.Show("Enter key word", "Enter key word", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (i == 1)
                    {
                        cls.loaddatagridview(dataGridView1, "select * from Task where ID=N'" + textBox2.Text + "'");
                    }
                    if (i == 2)
                    {
                        cls.loaddatagridview(dataGridView1, "select * from Task where TaskName=N'" + textBox2.Text + "'");
                    }
                   
                }
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((textBox2.Text == "") || (textBox2.Text == ""))
                {
                    cls.loaddatagridview(dataGridView1, "select * from Task");
                }
                else
                {
                    if (i == 1)
                    {
                        cls.loatextbox(textBox1, "select * from Task where ID like N'" + textBox2.Text + "%'", 2);
                        cls.loaddatagridview(dataGridView1, "select * from Task where ID like N'" + textBox2.Text + "%'");
                    }
                    if (i == 2)
                    {
                        cls.loatextbox(textBox1, "select * from Task where ID like N'" + textBox2.Text + "%'", 1);
                        cls.loaddatagridview(dataGridView1, "select * from Task where TaskName like N'" + textBox2.Text + "%'");
                    }                  
                }
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }
    }
}
