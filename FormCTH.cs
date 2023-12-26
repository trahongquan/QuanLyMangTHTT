using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Thư viện inmpot export
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml.Style;
using System.Data.SqlClient;
using System.Windows.Input;
using Microsoft.Office.Interop.Excel;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Imaging;
using System.Reflection;

namespace QuanLyMangTHTT
{
    public partial class FormCTH : Form
    {

        public FormCTH()
        {
            InitializeComponent();
        }
        ModifyQLCTH modify = new ModifyQLCTH();
        

        private void FormCTH_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_QLCTH.DataSource = modify.getAllCauTruyenHinh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenDiemCau.Focus();
            string tenDiemCau = this.txtTenDiemCau.Text;
            string donViQL = this.txtDonViQL.Text;
            string tTTH = this.txtTTTH.Text;
            string iP = this.txtIP.Text;
            string subNet = this.txtSubNet.Text;
            string getWay = this.txtGetWay.Text;
            string vlan = this.txtVlan.Text;
            string portTDCTH = this.txtPortTDCTH.Text;
            string portTDTTTH = this.txtPortTDTTTH.Text;
            string portSwL2TD = this.txtSWL2TD.Text;
            string portSwL2BM = this.txtSWL2BM.Text;
            string portSwL3 = this.txtSwL3.Text;
            string patchL2 = this.txtPatch2.Text;
            string patchL3 = this.txtPatch3.Text;
            string tBTC = this.txtTBTC.Text;
            string dTDD = this.txtNVTT.Text;
            string diaChi = this.txtDiaChi.Text;
            string ghiChu = this.txtGhiChu.Text;
            string tenTrangBi = this.txtTenTrangBi.Text;
            string serial = this.txtSerial.Text;
            string passWord = this.txtPassWord.Text;
            string micro = this.txtMicro.Text;
            string loa = this.txtLoa.Text;
            string uPS = this.txtUPS.Text;
            string hienThi = this.txtHienThi.Text;
            string duPhong = this.txtDuPhong.Text;

            Image hinhAnh1 = picBox1.Image;
            MemoryStream tmpStream1 = new MemoryStream();
            hinhAnh1.Save(tmpStream1, ImageFormat.Png); // change to other format
            tmpStream1.Seek(0, SeekOrigin.Begin);
            byte[] imgBytes1 = new byte[100000000];
            tmpStream1.Read(imgBytes1, 0, 100000000);

            Image hinhAnh2 = picBox2.Image;
            MemoryStream tmpStream2 = new MemoryStream();
            hinhAnh2.Save(tmpStream2, ImageFormat.Png); // change to other format
            tmpStream2.Seek(0, SeekOrigin.Begin);
            byte[] imgBytes2 = new byte[100000000];
            tmpStream2.Read(imgBytes2, 0, 100000000);

            Image hinhAnh3 = picBox3.Image;
            MemoryStream tmpStream3 = new MemoryStream();
            hinhAnh3.Save(tmpStream3, ImageFormat.Png); // change to other format
            tmpStream3.Seek(0, SeekOrigin.Begin);
            byte[] imgBytes3 = new byte[100000000];
            tmpStream3.Read(imgBytes3, 0, 100000000);

            Image hinhAnh4 = picBox4.Image;
            MemoryStream tmpStream4 = new MemoryStream();
            hinhAnh4.Save(tmpStream4, ImageFormat.Png); // change to other format
            tmpStream4.Seek(0, SeekOrigin.Begin);
            byte[] imgBytes4 = new byte[100000000];
            tmpStream4.Read(imgBytes4, 0, 100000000);



            cls_CauTruyenHinh CTH = new cls_CauTruyenHinh (tenDiemCau, donViQL, tTTH, iP,
                subNet, getWay, vlan, portTDCTH, portTDTTTH, portSwL2TD, portSwL2BM, portSwL3,
                patchL2, patchL3, tBTC, dTDD, diaChi, ghiChu, tenTrangBi,serial,passWord,micro,loa,uPS,hienThi,duPhong,imgBytes1,imgBytes2,imgBytes3,imgBytes4);

            if (checkData())
            {
                if (modify.Insert(CTH))
                {
                    MessageBox.Show("Đã thêm mới thông tin", "Thông báo:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_QLCTH.DataSource = modify.getAllCauTruyenHinh();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thành công", "Thông báo:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Xác nhận đóng chương trình?", "Thông báo: ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ;
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(this.txtID.Text);
            string tenDiemCau = this.txtTenDiemCau.Text;
            string donViQL = this.txtDonViQL.Text;
            string tTTH = this.txtTTTH.Text;
            string iP = this.txtIP.Text;
            string subNet = this.txtSubNet.Text;
            string getWay = this.txtGetWay.Text;
            string vlan = this.txtVlan.Text;
            string portTDCTH = this.txtPortTDCTH.Text;
            string portTDTTTH = this.txtPortTDTTTH.Text;
            string portSwL2TD = this.txtSWL2TD.Text;
            string portSwL2BM = this.txtSWL2BM.Text;
            string portSwL3 = this.txtSwL3.Text;
            string patchL2 = this.txtPatch2.Text;
            string patchL3 = this.txtPatch3.Text;
            string tBTC = this.txtTBTC.Text;
            string dTDD = this.txtNVTT.Text;
            string diaChi = this.txtDiaChi.Text;
            string ghiChu = this.txtGhiChu.Text;
            string tenTrangBi = this.txtTenTrangBi.Text;
            string serial = this.txtSerial.Text;
            string passWord = this.txtPassWord.Text;
            string micro = this.txtMicro.Text;
            string loa = this.txtLoa.Text;
            string uPS = this.txtUPS.Text;
            string hienThi = this.txtHienThi.Text;
            string duPhong = this.txtDuPhong.Text;

            Byte[] imgBytes1 = ConvertImg2Byte(picBox1.Image);
            Byte[] imgBytes2 = ConvertImg2Byte(picBox2.Image);
            Byte[] imgBytes3 = ConvertImg2Byte(picBox3.Image);
            Byte[] imgBytes4 = ConvertImg2Byte(picBox4.Image);

            cls_CauTruyenHinh CTH = new cls_CauTruyenHinh(tenDiemCau, donViQL, tTTH, iP,
                subNet, getWay, vlan, portTDCTH, portTDTTTH, portSwL2TD, portSwL2BM, portSwL3,
                patchL2, patchL3, tBTC, dTDD, diaChi, ghiChu, tenTrangBi, serial, passWord, micro, loa, uPS, hienThi, duPhong, imgBytes1, imgBytes2, imgBytes3, imgBytes4);

            if (modify.Update(CTH))
            {
                if (MessageBox.Show("Xác nhận cập nhật?", "Thông báo: ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ;
                dgv_QLCTH.DataSource = modify.getAllCauTruyenHinh();
                Clear();
                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Byte[] ConvertImg2Byte(Image image)
        {
            if (image != null)
            {
                MemoryStream tmpStream = new MemoryStream();
                image.Save(tmpStream, ImageFormat.Png); // change to other format
                tmpStream.Seek(0, SeekOrigin.Begin);
                byte[] imageBye = new byte[100000000];
                tmpStream.Read(imageBye, 0, 100000000);
                return imageBye;
            }
            return null;
        }

        public void dgv_QLCTH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtID.Text = dgv_QLCTH.Rows[index].Cells["id"].Value.ToString();
                txtTenDiemCau.Text = dgv_QLCTH.Rows[index].Cells["TenDiemCau"].Value.ToString();
                txtDonViQL.Text = dgv_QLCTH.Rows[index].Cells["DonViQL"].Value.ToString();
                txtTTTH.Text = dgv_QLCTH.Rows[index].Cells["TTTH"].Value.ToString();
                txtIP.Text = dgv_QLCTH.Rows[index].Cells["IP"].Value.ToString();
                txtSubNet.Text = dgv_QLCTH.Rows[index].Cells["SubNet"].Value.ToString();
                txtGetWay.Text = dgv_QLCTH.Rows[index].Cells["GetWay"].Value.ToString();
                txtVlan.Text = dgv_QLCTH.Rows[index].Cells["Vlan"].Value.ToString();
                txtPortTDCTH.Text = dgv_QLCTH.Rows[index].Cells["PortTD_CTH"].Value.ToString();
                txtPortTDTTTH.Text = dgv_QLCTH.Rows[index].Cells["PortTD_TTTH"].Value.ToString();
                txtSWL2BM.Text = dgv_QLCTH.Rows[index].Cells["SwL2_BM"].Value.ToString();
                txtSWL2TD.Text = dgv_QLCTH.Rows[index].Cells["SwL2_TD"].Value.ToString();
                txtSwL3.Text = dgv_QLCTH.Rows[index].Cells["SwL3"].Value.ToString();
                txtPatch2.Text = dgv_QLCTH.Rows[index].Cells["PatchL2"].Value.ToString();
                txtPatch3.Text = dgv_QLCTH.Rows[index].Cells["PatchL3"].Value.ToString();
                txtTBTC.Text = dgv_QLCTH.Rows[index].Cells["TBTC"].Value.ToString();
                txtNVTT.Text = dgv_QLCTH.Rows[index].Cells["DTDD"].Value.ToString();
                txtDiaChi.Text = dgv_QLCTH.Rows[index].Cells["DiaChi"].Value.ToString();
                txtGhiChu.Text = dgv_QLCTH.Rows[index].Cells["GhiChu"].Value.ToString();
                txtGhiChu.Text = dgv_QLCTH.Rows[index].Cells["TenTrangBi"].Value.ToString();
                txtGhiChu.Text = dgv_QLCTH.Rows[index].Cells["Serial"].Value.ToString();
                txtGhiChu.Text = dgv_QLCTH.Rows[index].Cells["Password"].Value.ToString();
                txtGhiChu.Text = dgv_QLCTH.Rows[index].Cells["Micro"].Value.ToString();
                txtGhiChu.Text = dgv_QLCTH.Rows[index].Cells["Loa"].Value.ToString();
                txtGhiChu.Text = dgv_QLCTH.Rows[index].Cells["UPS"].Value.ToString();
                txtGhiChu.Text = dgv_QLCTH.Rows[index].Cells["HienThi"].Value.ToString();
                txtGhiChu.Text = dgv_QLCTH.Rows[index].Cells["ThietBiDuPhong"].Value.ToString();

                ShowImg(dgv_QLCTH.Rows[index].Cells["HinhAnh1"], picBox1, picSoDo1);
                ShowImg(dgv_QLCTH.Rows[index].Cells["HinhAnh2"], picBox2, picSoDo2);
                ShowImg(dgv_QLCTH.Rows[index].Cells["HinhAnh3"], picBox3, picSoDo3);
                ShowImg(dgv_QLCTH.Rows[index].Cells["HinhAnh4"], picBox4, picSoDo4);


            }
        }
        private void ShowImg(DataGridViewCell dataImg, PictureBox picBox, PictureBox picSoDo)
        {
            if (dataImg.Value != null && !dataImg.Value.ToString().Equals("System.Byte[]"))
            {
                var data = (Byte[]) dataImg.Value;
                var stream = new MemoryStream(data);
             
                    picBox.Image = Image.FromStream(stream);
                    picSoDo.Image = Image.FromStream(stream);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!this.txtID.Text.Equals(""))
            {
                if (MessageBox.Show("Xác nhận xoá?", "Thông báo: ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);
                cls_CauTruyenHinh CTH = new cls_CauTruyenHinh();
                CTH.Id = int.Parse(this.txtID.Text);

                if (modify.Delete(CTH))
                {
                    dgv_QLCTH.DataSource = modify.getAllCauTruyenHinh();
                    Clear();

                }
                else
                    MessageBox.Show("Xoá không thành công", "Thông báo:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Clear()
        {
            txtID.Text = "";
            txtTenDiemCau.Text = "";
            txtDonViQL.Text = "";
            txtTTTH.Text = "";
            txtIP.Text = "";
            txtSubNet.Text = "";
            txtGetWay.Text = "";
            txtVlan.Text = "";
            txtPortTDCTH.Text = "";
            txtPortTDTTTH.Text = "";
            txtSWL2BM.Text = "";
            txtSWL2TD.Text = "";
            txtSwL3.Text = "";
            txtPatch2.Text = "";
            txtPatch3.Text = "";
            txtTBTC.Text = "";
            txtNVTT.Text = "";
            txtDiaChi.Text = "";
            txtGhiChu.Text = "";
            txtTenTrangBi.Text = "";
            txtSerial.Text = "";
            txtPassWord.Text = "";
            txtMicro.Text = "";
            txtLoa.Text = "";
            txtUPS.Text = "";
            txtHienThi.Text = "";
            txtDuPhong.Text = "";
            picBox1.Image = default;
            picBox2.Image = default;
            picBox3.Image = default;
            picBox4.Image = default;

        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            string CTH = txtFind.Text;
            if (!CTH.Equals(""))
            {
                dgv_QLCTH.DataSource = modify.Find(CTH);
            }
            else
            {
                dgv_QLCTH.DataSource = modify.getAllCauTruyenHinh();
            }
        }
        //private void ExportExcel(string path)
        //{
        //    Excel.Application application = new Excel.Application();
        //    application.Application.Workbooks.Add(Type.Missing);
        //    for (int i = 0; i < dgv_QLCTH.Columns.Count; i++)
        //    {
        //        application.Cells[1, i + 1] = dgv_QLCTH.Columns[i].HeaderText;
        //    }
        //    for (int i = 0; i < dgv_QLCTH.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < dgv_QLCTH.Columns.Count; j++)
        //        {
        //            application.Cells[i + 2, j + 1] = dgv_QLCTH.Rows[i].Cells[j].Value;
        //        }
        //    }
        //    application.Columns.AutoFit();
        //    application.ActiveWorkbook.SaveCopyAs(path);
        //    application.ActiveWorkbook.Saved = true;
        //}
        //private void ImportExcel(string path)
        //{
        //    using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
        //    {
        //        ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
        //        DataTable dt = new DataTable();
        //        for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
        //        {
        //            dt.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
        //        }
        //        for (int i = excelWorksheet.Dimension.Start.Row; i <= excelWorksheet.Dimension.End.Row; i++)
        //        {
        //            List<string> listRows = new List<string>();
        //            for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
        //            {
        //                listRows.Add(excelWorksheet.Cells[i, j].Value.ToString());
        //            }
        //            dt.Rows.Add(listRows.ToArray());
        //        }
        //        dgv_QLCTH.DataSource = dt;

        //    }

        //}



        //private void btn_ImportExcel_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Title = "Export Excel";
        //    openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*xls";
        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        try
        //        {
        //            ImportExcel(openFileDialog.FileName);
        //            MessageBox.Show("Nhập file thành công!");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Không thành công!\n" + ex.Message);
        //        }
        //    }
        //}


        public bool checkData()
        {
            if (string.IsNullOrEmpty(txtTenDiemCau.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên điểm cầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDiemCau.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtIP.Text))
            {
                MessageBox.Show("Bạn chưa địa chỉ IP", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIP.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSubNet.Text))
            {
                MessageBox.Show("Bạn chưa nhập Subnetmark.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSubNet.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtGetWay.Text))
            {
                MessageBox.Show("Bạn chưa nhập getway.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGetWay.Focus();
                return false;
            }
            int a;
            if (string.IsNullOrEmpty(txtSWL2BM.Text))
            {
                MessageBox.Show("Bạn chưa nhập toạ độ Switch Layer2 bảo mật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSWL2BM.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSwL3.Text))
            {
                MessageBox.Show("Bạn chưa nhập toạ độ Switch Layer3.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSwL3.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSWL2TD.Text))
            {
                MessageBox.Show("Bạn chưa nhập toạ độ Switch Layer 2 truyền dẫn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSWL2TD.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtVlan.Text))
            {
                MessageBox.Show("Bạn chưa nhập Vlan.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVlan.Focus();
                return false;
            }
            return true;
        }

        //public void SaveImportExcel()
        //{
        //    try
        //    {
        //        for (int i = 0; i <= dgv_QLCTH.Rows.Count - 1; i++)
        //        {
        //            var rows = dgv_QLCTH.Rows[i];
        //            cls_CauTruyenHinh CTH = new cls_CauTruyenHinh(tenDiemCau, donViQL, tTTH, iP,
        //       subNet, getWay, vlan, portTDCTH, portTDTTTH, portSwL2TD, portSwL2BM, portSwL3,
        //       patchL2, patchL3, tBTC, dTDD, diaChi, ghiChu, tenTrangBi, serial, passWord, micro, loa, uPS, hienThi, duPhong);
        //            rows.Cells[1].Value.ToString(),
        //            rows.Cells[2].Value.ToString(),
        //            rows.Cells[3].Value.ToString(),
        //            rows.Cells[4].Value.ToString(),
        //            rows.Cells[5].Value.ToString(),
        //            rows.Cells[6].Value.ToString(),
        //            rows.Cells[7].Value.ToString(),
        //            rows.Cells[8].Value.ToString(),
        //            rows.Cells[9].Value.ToString(),
        //            rows.Cells[10].Value.ToString(),
        //            rows.Cells[11].Value.ToString(),
        //            rows.Cells[12].Value.ToString(),
        //            rows.Cells[13].Value.ToString(),
        //            rows.Cells[14].Value.ToString(),
        //            rows.Cells[15].Value.ToString(),
        //            rows.Cells[16].Value.ToString(),
        //            rows.Cells[17].Value.ToString(),
        //            rows.Cells[18].Value.ToString());

        //            modify.Insert(CTH);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }

        //}
       

        //private void buttonXem_Click(object sender, EventArgs e)
        //{
            
           
        //    //string id = dgv_QLCTH.SelectedRows[0].Cells[0].Value.ToString();
        //    //DataTable dt = modify.getCauTruyenHinhByid(id);

        //    //int Id = int.Parse(dt.Rows[0][0].ToString());
        //    //cls_CauTruyenHinh CTH = new cls_CauTruyenHinh(Id,
        //    //                                            dt.Rows[0][1].ToString(),
        //    //                                            dt.Rows[0][2].ToString(),
        //    //                                            dt.Rows[0][3].ToString(),
        //    //                                            dt.Rows[0][4].ToString(),
        //    //                                            dt.Rows[0][5].ToString(),
        //    //                                            dt.Rows[0][6].ToString(),
        //    //                                            dt.Rows[0][7].ToString(),
        //    //                                            dt.Rows[0][8].ToString(),
        //    //                                            dt.Rows[0][9].ToString(),
        //    //                                            dt.Rows[0][10].ToString(),
        //    //                                            dt.Rows[0][11].ToString(),
        //    //                                            dt.Rows[0][12].ToString(),
        //    //                                            dt.Rows[0][13].ToString(),
        //    //                                            dt.Rows[0][14].ToString(),
        //    //                                            dt.Rows[0][15].ToString(),
        //    //                                            dt.Rows[0][16].ToString(),
        //    //                                            dt.Rows[0][17].ToString(),
        //    //                                            dt.Rows[0][18].ToString(),
        //    //                                            dt.Rows[0][19].ToString(),
        //    //                                            dt.Rows[0][20].ToString(),
        //    //                                            dt.Rows[0][21].ToString(),
        //    //                                            dt.Rows[0][22].ToString(),
        //    //                                            dt.Rows[0][23].ToString(),
        //    //                                            dt.Rows[0][24].ToString(),
        //    //                                            dt.Rows[0][25].ToString(),
        //    //                                            dt.Rows[0][26].ToString(),
        //    //                                            dt.Rows[0][27].ToString()); 
        //    FormQLThietBi formQLTB = new FormQLThietBi(/*CTH*/);
        //    formQLTB.Show();
        //}

        private void txtTenDiemCau_TextChanged(object sender, EventArgs e)
        {
            if (txtTenDiemCau.Equals(""))
            {
                lb_TenDiemCau.Text = "";
            }
            else
            {
                lb_TenDiemCau.Text = txtTenDiemCau.Text.ToString();
            }
        }

      
        private void btn_Xem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabChiTiet;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabDanhSach;
        }

     

        //Click ẢNh PHÓNG TO
        private void picBox1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabSoDo1;
           
           
        }

        private void picBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabSoDo2;
        }

        private void picBox3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabSoDo3;
        }

        private void picBox4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabSoDo4;
        }

        private void BackChiTiet_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabChiTiet;
        }


        //----------------------------------------------------


        private void ThemAnh1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files|*.jpg;*.jpeg;.*.gif;.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picBox1.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void ThemAnh2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files|*.jpg;*.jpeg;.*.gif;.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picBox2.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void ThemAnh3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files|*.jpg;*.jpeg;.*.gif;.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picBox3.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void ThemAnh4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files|*.jpg;*.jpeg;.*.gif;.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picBox4.Image = new Bitmap(opnfd.FileName);
            }
        }
    }
}
