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
    public partial class frmDepartment : Form
    {
        public frmDepartment()
        {
            InitializeComponent();
        }
        Clsdatabase cls = new Clsdatabase();
        private void frmphongban_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
            cls.loaddatagridview(dataGridView1, "select * from Department");
            cls.loadcombobox(comboBox1, "select * from Project", 0);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cls.kttrungkhoa(textBox2.Text, "select DepartmentID from Department"))
                {
                    string insert = "insert into Department values('" + comboBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "',N'" + dateTimePicker1.Text + "',N'" + textBox5.Text + "')";
                    cls.thucthiketnoi(insert);
                    cls.loaddatagridview(dataGridView1, "select * from Department");
                }
                else
                {
                    MessageBox.Show("DepartmentID is exist", "Same DepartmentID ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Incorrect input data");
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            comboBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update Department set ProjectID=N'" + comboBox1.Text + "',DepartmentName=N'" + textBox3.Text + "',EstablishDate=N'" + dateTimePicker1.Text + "',Note=N'" + textBox5.Text + "' where DepartmentID=N'" + textBox2.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from Department");
                MessageBox.Show("Sucessfull");
            }
            catch
            {
                MessageBox.Show("Incorrect input data");
            }
        }       
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string del = "delete from Department where DepartmentID=N'" + textBox2.Text + "'";
                if (MessageBox.Show("Delete?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(del);
                    cls.loaddatagridview(dataGridView1, "select * from Department");
                }
            }
            catch
            {
                MessageBox.Show("Incorrect input data");
            }
        }
    }
}
