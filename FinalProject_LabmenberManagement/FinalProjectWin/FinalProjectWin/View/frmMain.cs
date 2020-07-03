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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public int k = 1;
        public static string quyen;
        private void FrmMain_Load(object sender, EventArgs e)
        {

            if (quyen == "Admin")
            {
                menuItem1.Enabled = true;
                menuItem2.Enabled = true;
                menuItemSearch.Enabled = true;
                menuItem4.Enabled = true;
                menuItemExit.Enabled = true;

            }
            else if (quyen == "user")
            {
                menuItem1.Enabled = false;
                menuItem2.Enabled = false;
                menuItemSearch.Enabled = true;
                menuItem4.Enabled = true;
                menuItemExit.Enabled = true;
            }
        }
        private void menuItem11_Click(object sender, EventArgs e)
        {
            frmSearch ftk = new frmSearch();
            panel_show.Show();
            panel_show.Controls.Clear();
            ftk.TopLevel = false;
            ftk.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ftk);
            ftk.Show();
        }
        private void cmd_nhansu_Click(object sender, EventArgs e)
        {
            frmInformation fc = new frmInformation();
            panel_show.Show();
            panel_show.Controls.Clear();
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fc);
            fc.Show();
        }
        private void cmd_thongticanhan_Click(object sender, EventArgs e)
        {
            frmPersonalInfomation ft = new frmPersonalInfomation();
            panel_show.Show();
            panel_show.Controls.Clear();
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ft);
            ft.Show();
        }
        private void cmd_tracuu_Click(object sender, EventArgs e)
        {
            frmSearch ftk = new frmSearch();
            panel_show.Show();
            panel_show.Controls.Clear();
            ftk.TopLevel = false;
            ftk.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ftk);
            ftk.Show();
        }
        private void cmd_Qlphongban_Click(object sender, EventArgs e)
        {
            frmDepartment fpb = new frmDepartment();
            panel_show.Show();
            panel_show.Controls.Clear();
            fpb.TopLevel = false;
            fpb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fpb);
            fpb.Show();
        }
        private void cmd_Qlbophan_Click(object sender, EventArgs e)
        {
            frmProject frb = new frmProject();
            panel_show.Show();
            panel_show.Controls.Clear();
            frb.TopLevel = false;
            frb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(frb);
            frb.Show();
        }
        private void cmd_qlbangcong_Click(object sender, EventArgs e)
        {
            frmSalary fbc = new frmSalary();

            panel_show.Show();
            panel_show.Controls.Clear();
            fbc.TopLevel = false;
            fbc.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fbc);
            fbc.Show();
        }
        //private void btntracuu_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        //{
        //    frmtimkiem ftk = new frmtimkiem();
        //    panel_show.Show();
        //    panel_show.Controls.Clear();
        //    ftk.TopLevel = false;
        //    ftk.Dock = DockStyle.Fill;
        //    panel_show.Controls.Add(ftk);
        //    ftk.Show();
        //}
        //private void bubblenhansu_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        //{
        //    frmthongtincanhan ft = new frmthongtincanhan();

        //    panel_show.Show();
        //    panel_show.Controls.Clear();
        //    ft.TopLevel = false;
        //    ft.Dock = DockStyle.Fill;
        //    panel_show.Controls.Add(ft);
        //    ft.Show();
        //}
        //private void bubblebophan_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        //{
        //    frmbophan frb = new frmbophan();
        //    panel_show.Show();
        //    panel_show.Controls.Clear();
        //    frb.TopLevel = false;
        //    frb.Dock = DockStyle.Fill;
        //    panel_show.Controls.Add(frb);
        //    frb.Show();
        //}
        //private void bubblephongban_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        //{
        //    frmphongban fpb = new frmphongban();
        //    panel_show.Show();
        //    panel_show.Controls.Clear();
        //    fpb.TopLevel = false;
        //    fpb.Dock = DockStyle.Fill;
        //    panel_show.Controls.Add(fpb);
        //    fpb.Show();
        //}
        private void cmd_minimax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void cmd_maximax_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).Size = new Size(26, 25);
        }
        private void cmd_maximax_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Size = new Size(24, 23);
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }
        private void menuItemStaff_Click(object sender, EventArgs e)
        {
            frmInformation fc = new frmInformation();
            panel_show.Show();
            panel_show.Controls.Clear();
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fc);
            fc.Show();
        }
        private void menuItemPerIn_Click(object sender, EventArgs e)
        {
            frmPersonalInfomation ft = new frmPersonalInfomation();
            panel_show.Show();
            panel_show.Controls.Clear();
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ft);
            ft.Show();
        }

        private void menuItemAccount_Click(object sender, EventArgs e)
        {
            frmSignup b = new frmSignup();
            panel_show.Show();
            panel_show.Controls.Clear();
            b.TopLevel = false;
            b.Dock = DockStyle.Fill;
            panel_show.Controls.Add(b);
            b.Show();

        }

        private void menuItemDepartment_Click(object sender, EventArgs e)
        {
            frmDepartment fpb = new frmDepartment();
            panel_show.Show();
            panel_show.Controls.Clear();
            fpb.TopLevel = false;
            fpb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fpb);
            fpb.Show();
        }

        private void menuItemProject_Click(object sender, EventArgs e)
        {
            frmProject fpb = new frmProject();
            panel_show.Show();
            panel_show.Controls.Clear();
            fpb.TopLevel = false;
            fpb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fpb);
            fpb.Show();
        }

        private void menuItemTask_Click(object sender, EventArgs e)
        {
            frmTask gg = new frmTask();
            panel_show.Show();
            panel_show.Controls.Clear();
            gg.TopLevel = false;
            gg.Dock = DockStyle.Fill;
            panel_show.Controls.Add(gg);
            gg.Show();
        }

        private void menuItemSalary_Click(object sender, EventArgs e)
        {
            frmSalary fhtv = new frmSalary();
            panel_show.Show();
            panel_show.Controls.Clear();
            fhtv.TopLevel = false;
            fhtv.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fhtv);
            fhtv.Show();
        }

        private void menuItemSearch_Click(object sender, EventArgs e)
        {
            frmSearch ftk = new frmSearch();
            panel_show.Show();
            panel_show.Controls.Clear();
            ftk.TopLevel = false;
            ftk.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ftk);
            ftk.Show();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
