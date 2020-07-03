using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using FinalProjectWin.Controller;

namespace FinalProjectWin.View
{
    public partial class frmPersonalInfomation : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmPersonalInfomation()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cls.kttrungkhoa(comboBox1.Text, "select ID from PersonalInformation"))
                {
                    string insert = "insert into PersonalInformation values(N'" + comboBox1.Text + "',N'" + textBox1.Text  + "',N'" + textBox2.Text + "',N'" + textBox4.Text  + "',N'" + textBox6.Text + "',N'" + textBox7.Text + "',N'" + textBox8.Text  + "',N'" + textBox12.Text + "',N'" + textBox17.Text + "')";
                    cls.thucthiketnoi(insert);
                    dataGridView1.Refresh();
                    cls.loaddatagridview(dataGridView1, "select * from PersonalInformation");
                }
                else MessageBox.Show("Exist");
            }
            catch
            {
                MessageBox.Show("Incorrect input data");
            }
        }        
        private void frmthongtincanhan_Load(object sender, EventArgs e)
        {
            
            cls.loaddatagridview(dataGridView1, "select * from PersonalInformation");
            cls.loadcombobox(comboBox1, "select * from BasicInformation", 2);
        }     
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                comboBox1.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[hang].Cells[2].Value.ToString();                
                textBox4.Text = dataGridView1.Rows[hang].Cells[3].Value.ToString();             
                textBox6.Text = dataGridView1.Rows[hang].Cells[4].Value.ToString();
                textBox7.Text = dataGridView1.Rows[hang].Cells[5].Value.ToString();
                textBox8.Text = dataGridView1.Rows[hang].Cells[6].Value.ToString();             
                textBox12.Text = dataGridView1.Rows[hang].Cells[7].Value.ToString();
                textBox17.Text = dataGridView1.Rows[hang].Cells[8].Value.ToString();
                //
            }
            catch (Exception)
            { }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(textBox1, "select * from PersonalInformation where ID='" + comboBox1.Text + "'", 1);
            cls.loadtextboxchiso(textBox2, "select * from PersonalInformation where ID='" + comboBox1.Text + "'", 2);           
            cls.loadtextboxchiso(textBox4, "select * from PersonalInformation where ID='" + comboBox1.Text + "'", 3);            
            cls.loadtextboxchiso(textBox6, "select * from PersonalInformation where ID='" + comboBox1.Text + "'", 4);
            cls.loadtextboxchiso(textBox7, "select * from PersonalInformation where ID='" + comboBox1.Text + "'", 5);
            cls.loadtextboxchiso(textBox8, "select * from PersonalInformation where ID='" + comboBox1.Text + "'", 6);           
            cls.loadtextboxchiso(textBox12, "select * from PersonalInformation where ID='" + comboBox1.Text + "'", 7);
            cls.loadtextboxchiso(textBox17, "select * from PersonalInformation where ID='" + comboBox1.Text + "'", 8);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update PersonalInformation set ID=N'" + comboBox1.Text + "',PlaceOfBirth=N'" + textBox2.Text  + "',Address=N'" + textBox4.Text  + "',Phone=N'" + textBox6.Text + "',Nation=N'" + textBox7.Text + "',Religion=N'" + textBox8.Text  + "',Education=N'" + textBox12.Text + "',Note=N'" + textBox17.Text + "' where ID=N'" + comboBox1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from PersonalInformation");
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
                string delete = "delete from PersonalInformation where ID=N'" + comboBox1.Text + "'";
                if (MessageBox.Show("Delete?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview(dataGridView1, "select * from PersonalInformation");
                }
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }
    }
}
