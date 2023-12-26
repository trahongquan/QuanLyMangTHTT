using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;

namespace QuanLyMangTHTT
{

    public partial class FormChinhSuaCTH : Form
    {
        //string chiso, sdt;
        public FormChinhSuaCTH()
        {
            InitializeComponent();
        }
        //public FormChinhSuaCTH(string chiso,string sdt)
        //{
        //    InitializeComponent();
        //    this.chiso = chiso;
        //    this.sdt = sdt;

        //}
        ModifyQLCTH modify = new ModifyQLCTH();
    


        private void FormChinhSuaCTH_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Xác nhận thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }




        private void btnThoatChinhSua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //void LoadData()
        //{
        //    txtTenThietBi.Text = sdt;
        //}
        private void FormChinhSuaCTH_Load(object sender, EventArgs e)
        {
            //LoadData();
        }
    }
}
