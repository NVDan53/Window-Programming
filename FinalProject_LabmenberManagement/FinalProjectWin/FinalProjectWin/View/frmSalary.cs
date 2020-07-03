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
    public partial class frmSalary : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public static SqlConnection Con;
        public frmSalary()
        {
            InitializeComponent();
        }
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        DataSet ds4 = new DataSet();
        DataSet ds5 = new DataSet();       
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; 
            cbo.DisplayMember = ten; 
        }
        private void frmSalary_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";
            frmSalary.FillCombo("SELECT DepartmentName FROM Department", comboBox10, "DepartmentName", "DepartmentName");
            comboBox10.SelectedIndex = -1;           
            cls.loaddatagridview1(dataGridView2, ds2, "select * from Salary ");           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox4.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }       
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update Salary set ID='"+cb2.Text+"',DepartmentName=N'"+comboBox10.Text+"', FullName=N'" + txt53.Text + "',BasicSalary=N'" + txt10.Text  + "',Reward=N'" + textBox1.Text + "',WorkingDay=N'" + txt15.Text + "',DayOff=N'" + txt16.Text  + "',Salary=N'" + txt52.Text + "',Note='" + txt18.Text + "' where ID=N'" + cb2.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridView2, ds2, "select * from Salary where DepartmentName=N'"+comboBox10.SelectedValue+"'");
                MessageBox.Show("Success");
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from Salary where ID=N'" + cb2.Text + "'";
                if (MessageBox.Show("Delete?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview1(dataGridView2, ds2, "select * from Salary");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fail");
            }
        } 
        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {              
            cls.loadtextboxchiso(txt53, "select * from Salary where ID='" + cb2.Text + "'", 2);
            cls.loadtextboxchiso(txt10, "select * from Salary where ID='" + cb2.Text + "'", 3);
            cls.loadtextboxchiso(textBox1, "select * from Salary where ID='" + cb2.Text + "'", 4);         
            cls.loadtextboxchiso(txt15, "select * from Salary where ID='" + cb2.Text + "'", 5);
            cls.loadtextboxchiso(txt16, "select * from Salary where ID='" + cb2.Text + "'", 6);          
            cls.loadtextboxchiso(txt52, "select * from Salary where ID='" + cb2.Text + "'", 7);
            cls.loadtextboxchiso(txt18, "select * from Salary where ID='" + cb2.Text + "'", 8);
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cb2.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txt10.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            txt53.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            comboBox10.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            textBox1.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            txt15.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            txt16.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            txt52.Text = dataGridView2.Rows[i].Cells[7].Value.ToString();
            txt18.Text = dataGridView2.Rows[i].Cells[8].Value.ToString();        
        }      
        private void txt10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txt15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txt16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }          
        private void tl_Click(object sender, EventArgs e)
        {
            int lcb = Convert.ToInt32(txt10.Text);
            int nc = Convert.ToInt32(txt15.Text);
            int th = Convert.ToInt32(textBox1.Text);
            float luong = ((lcb / 26) * nc +th);
            txt52.Text = luong.ToString();
        }
        private void comboBox10_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            frmSalary.FillCombo("select ID from Salary where DepartmentName=(select top(1) DepartmentName from Department a, BasicInformation b where a.DepartmentID=b.DepartmentID and a.DepartmentName=N'" + comboBox10.SelectedValue + "' group by DepartmentName)", cb2, "ID", "ID");
            cb2.DisplayMember = "ID";
            cb2.ValueMember = "ID";
            cls.loaddatagridview1(dataGridView2, ds2, "select * from Salary b where b.DepartmentName=N'" + comboBox10.SelectedValue + "'");
        }       
        private void button5_Click(object sender, EventArgs e)
        {
            int lcb = Convert.ToInt32(txt10.Text);
            int nc = Convert.ToInt32(txt15.Text);
            int th = Convert.ToInt32(textBox1.Text);
            float luong = ((lcb / 26) * nc+ th );
            txt52.Text = luong.ToString();
        }   
    }       
}

