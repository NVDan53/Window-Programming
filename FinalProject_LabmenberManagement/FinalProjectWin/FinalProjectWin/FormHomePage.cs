using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using FinalProjectWin.Controller;

namespace FinalProjectWin.View
{
    public partial class FormHomePage : Form
    {
        Clsdatabase cls = new Clsdatabase();
        private SqlConnection Con = null;
        public FormHomePage()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {          
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";
            Con.Open();
            string select = "Select * From tbuser where Username='" + txtUsername.Text + "' and Pass='" + txtPassword.Text + "' and Role='Admin'"; SqlCommand cmd = new SqlCommand(select, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Read();
                MessageBox.Show("Login ( Admin ) !", "Notification !");
                FrmMain.quyen = "Admin";
                FrmMain frm = new FrmMain();
                frm.ShowDialog();
                cmd.Dispose();
                reader.Close();
                reader.Dispose();
            }
            else
            {
                MessageBox.Show("Login ( User ) !", "Notification !");
                FrmMain.quyen = "user";
                this.Hide();
                FrmMain frm = new FrmMain();              
                frm.ShowDialog();
                cmd.Dispose();
                reader.Close();
                reader.Dispose();
            }
            


        
    }
        
    }
}

