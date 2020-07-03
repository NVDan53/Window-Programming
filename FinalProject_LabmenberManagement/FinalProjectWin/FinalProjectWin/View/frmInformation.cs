using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;
using FinalProjectWin.Controller;

namespace FinalProjectWin.View
{
    public partial class frmInformation : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public static SqlConnection Con;
        public frmInformation()
        {
            InitializeComponent();
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



        private void frmcoban_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
            frmInformation.FillCombo("SELECT ProjectID FROM Project", comboBox2, "ProjectID", "ProjectID");
            comboBox2.SelectedIndex = -1;

            cls.loaddatagridview(dataGridView1, "select * from BasicInformation");
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {

            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string insert = "insert into BasicInformation values(N'" + comboBox2.Text + "',N'" + comboBox3.Text + "',N'" + textBox3.Text + "',N'" + textBox4.Text + "',N'" + dateTimePicker1.Text + "',N'" + comboBox1.Text + "',N'" + textBox9.Text + "',N'" + textBox12.Text + "',N'" + textBox19.Text + "')";
            if ((!cls.kttrungkhoa(textBox3.Text, "select ID from BasicInformation")))
            {
                if (textBox3.Text != "" && textBox9.Text != "")
                {
                    cls.thucthiketnoi(insert);
                    dataGridView1.Refresh();
                    cls.loaddatagridview(dataGridView1, "select * from BasicInformation");
                    MessageBox.Show("sucessfull");
                }
                else if (textBox3.Text == "") MessageBox.Show("Enter ID");
            }
            else if ((!cls.kttrungkhoa(textBox3.Text, "select ID from BasicInformation")))
            {
                if (MessageBox.Show("Exist", "Fail", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(insert);
                    cls.loaddatagridview(dataGridView1, "select * from BasicInformation");
                    MessageBox.Show("Sucessfull");
                    string delete = "delete from BasicInformation where ID='" + textBox3.Text + "'";
                    cls.thucthiketnoi(delete);
                }
            }
            string ine = "insert into PersonalInformation(ID,FullName) select ID,FullName from ID,FullName where ID='" + textBox3.Text + "'";
            if ((!cls.kttrungkhoa(textBox3.Text, "select ID from BasicInformation")))
            {
                if (textBox3.Text != "")
                {
                    cls.thucthiketnoi(ine);
                    dataGridView1.Refresh();
                }
                else MessageBox.Show("Enter ID");
            }
            else
                MessageBox.Show("success", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string ins = "insert into Salary(ID,FullName) select ID,FullName from BasicInformation where ID='" + textBox3.Text + "'";
            if ((!cls.kttrungkhoa(textBox3.Text, "select ID from Salary")))
            {
                if (textBox3.Text != "")
                {
                    cls.thucthiketnoi(ins);
                    dataGridView1.Refresh();
                }
                else MessageBox.Show("Enter ID");
            }
            else
            {
                MessageBox.Show("ID is exist", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                string updata = " update Salary set DepartmentName = (select top(1) DepartmentName from Department a,BasicInformation b where a.DepartmentID=b.DepartmentID and a.DepartmentID=N'" + comboBox3.Text + "' group by DepartmentName) where ID='" + textBox3.Text + "'";
                cls.thucthiketnoi(updata);
                dataGridView1.Refresh();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                comboBox2.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
                comboBox3.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[hang].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[hang].Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[hang].Cells[4].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[hang].Cells[5].Value.ToString();
                textBox9.Text = dataGridView1.Rows[hang].Cells[6].Value.ToString();
                textBox12.Text = dataGridView1.Rows[hang].Cells[7].Value.ToString();
                textBox19.Text = dataGridView1.Rows[hang].Cells[8].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string update = "update BasicInformation set ProjectID=N'" + comboBox2.Text + "',DepartmentID=N'" + comboBox3.Text + "',FullName=N'" + textBox4.Text + "',Birthday='" + dateTimePicker1.Text + "',Gender=N'" + comboBox1.Text + "',IC=N'" + textBox9.Text + "',Position=N'" + textBox12.Text + "',Note=N'" + textBox19.Text + "' where ID=N'" + textBox3.Text + "'";
            cls.thucthiketnoi(update);
            dataGridView1.Refresh();
            cls.loaddatagridview(dataGridView1, "select * from BasicInformation");
            MessageBox.Show("Sucessfull");
            string upd = "update Salary set FullName=N'" + textBox4.Text + "' where ID=N'" + textBox3.Text + "'";
            cls.thucthiketnoi(upd);
            cls.loaddatagridview(dataGridView1, "select * from BasicInformation");
            string ds = "update Salary set DepartmentName = (select top(1) DepartmentName from Department a,BasicInformation b where a.DepartmentID=b.DepartmentID and a.DepartmentID=N'" + comboBox3.Text + "' group by DepartmentName) where ID='" + textBox3.Text + "'";
            cls.thucthiketnoi(ds);
            dataGridView1.Refresh();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            string delete = "delete from BasicInformation where ID=N'" + textBox3.Text + "'";
            if (MessageBox.Show("Delete?", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dataGridView1, "select * from BasicInformation");
            }
            MessageBox.Show("Deleted ");
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmInformation.FillCombo("select p.DepartmentID from Project b,Department p where b.ProjectID=p.ProjectID and p.ProjectID=N'" + comboBox2.SelectedValue + "'", comboBox3, "DepartmentID", "DepartmentID");
            comboBox3.DisplayMember = "DepartmentID";
            comboBox3.ValueMember = "DepartmentID";
        }  
    }
}
