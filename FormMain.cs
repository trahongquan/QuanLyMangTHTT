using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMangTHTT
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_Body.Controls.Add(childForm);
            pn_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btn_QLNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLNV());
            lb_Home.Text = "Quản lý nhân viên";
        }

        private void btn_QLTB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLThietBi());
            lb_Home.Text = "Quản lý thiết bị";
        }

        private void btn_QLCTH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCTH());
            lb_Home.Text = "Quản lý Cầu truyền hình";
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                lb_Home.Text = "Trang chủ";
            }
        }
    }
}

  
