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
    public partial class frmProject : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmProject()
        {
            InitializeComponent();
        }
        private void frmbophan_Load(object sender, EventArgs e)
        {
            cls.loaddatagridview(dataGridView1, "select * from Project");
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cls.kttrungkhoa(textBox1.Text, "select ProjectID from Project"))
                {
                    string insert = "insert into Project values(N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + dateTimePicker1.Text + "',N'" + textBox3.Text + "',N'" + dateTimePicker2.Text +"')";
                    cls.thucthiketnoi(insert);
                    cls.loaddatagridview(dataGridView1, "select * from Project");
                }
                else
                {
                    MessageBox.Show("Project is exist ", "Same project", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Incorrect input data");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update Project set ProjectName=N'" + textBox2.Text  + "',Deadline='" + dateTimePicker1.Text + "',Note=N'" + textBox3.Text + "',StartDate='" + dateTimePicker2.Text+"' where ProjectID='" + textBox1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from Project");
                MessageBox.Show("Sucessfull");
            }
            catch
            {
                MessageBox.Show("Incorrect input data");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {        
                string del = "delete from Project where ProjectID='" + textBox1.Text + "'";
                string del1 = "delete from Project where ProjectID='" + textBox1.Text + "'";             
                if (MessageBox.Show("Delete?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(del1);
                    cls.thucthiketnoi(del);
                    cls.loaddatagridview(dataGridView1, "select * from Project");
                }           
        }               
    }
}
