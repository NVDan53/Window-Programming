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
    public partial class frmSignup : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmSignup()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            string insert = "insert into tbuser values(N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox4.Text + "',N'" + textBox3.Text + "','" + dateTimePicker1.Text + "')";
                if (cls.kttrungkhoa(textBox1.Text, "select * from tbuser") == true)
                    MessageBox.Show("Username is exist");
                else
                {
                    cls.thucthiketnoi(insert);
                    MessageBox.Show("Success");
                    cls.loaddatagridview(dataGridView1, "select * from tbuser");
                }
            }
            catch
            {
                MessageBox.Show("Incorrect Data");
            }

        }       
        private void frmdangki_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
            cls.loaddatagridview(dataGridView1, "select * from tbuser");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";           
        }        
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update tbuser set Username=N'" + textBox1.Text + "',Pass=N'" + textBox2.Text + "',Role=N'" + textBox4.Text + "',Name=N'" + textBox3.Text + "',Birthday='" + dateTimePicker1.Text + "' where Username='"+textBox1.Text+"'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from tbuser");
                MessageBox.Show("Success");
            }
            catch
            {
                MessageBox.Show("Incorrect data");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string delete = "delete from tbuser where Username=N'" + textBox1.Text + "'";
            if (MessageBox.Show("Delete?", "Delete data ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dataGridView1, "select * from tbuser");
            }
            MessageBox.Show("Deleted ");
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                textBox1.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[hang].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.Rows[hang].Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[hang].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.CustomFormat = "MM/dd/yyyy";
                string insert = "insert into tbuser values(N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox4.Text + "',N'" + textBox3.Text + "','" + dateTimePicker1.Text + "')";
                if (cls.kttrungkhoa(textBox1.Text, "select * from tbuser") == true)
                    MessageBox.Show("Username is exist");
                else
                {
                    cls.thucthiketnoi(insert);
                    MessageBox.Show("Success");
                    cls.loaddatagridview(dataGridView1, "select * from tbuser");
                    //this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Incorrect data");
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update tbuser set Username=N'" + textBox1.Text + "',Pass=N'" + textBox2.Text + "',Role=N'" + textBox4.Text + "',Name=N'" + textBox3.Text + "',Birthday='" + dateTimePicker1.Text + "' where Username='" + textBox1.Text+ "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from tbuser");
                MessageBox.Show("Success");
            }
            catch
            {
                MessageBox.Show("Incorrect data");
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string delete = "delete from tbuser where Username=N'" + textBox1.Text + "'";
            if (MessageBox.Show("Delete ?", "Delete data ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dataGridView1, "select * from tbuser");
            }
            MessageBox.Show("Deleted ");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
