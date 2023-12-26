using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMangTHTT
{
    internal class ModifyQLCTH
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        public ModifyQLCTH()
        {
        }
        public DataTable getCauTruyenHinhByid(string id)
        {
            DataTable dt = new DataTable();
            string SQL = "select * from tbl_CTH where id = " + id;
            using (conn = cls_KetNoi.KetNoi())
            {
                conn.Open();
                da = new SqlDataAdapter(SQL, conn);
                da.Fill(dt);
                conn.Close();
            }
            return dt;
        }


        public DataTable getAllCauTruyenHinh()
        {
            DataTable dt = new DataTable();
            string SQL = "select * from tbl_CTH";
            using (conn = cls_KetNoi.KetNoi())
            {
                conn.Open();
                da = new SqlDataAdapter(SQL, conn);
                da.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public bool Insert(cls_CauTruyenHinh CTH)
        {
            conn = cls_KetNoi.KetNoi();
            string SQL = "INSERT INTO tbl_CTH (TenDiemCau, DonViQL, TTTH, IP, SubNet, GetWay, Vlan, PortTD_CTH, PortTD_TTTH, SwL2_TD, SwL2_BM, SwL3, PatchL2, PatchL3, TBTC, DTDD, DiaChi, GhiChu, HinhAnh4, HinhAnh3, HinhAnh2, HinhAnh1, ThietBiDuPhong,HienThi, UPS, Loa, Micro, Password, Serial, TenTrangBi)" +
                "VALUES        (@TenDiemCau,@DonViQL,@TTTH,@IP,@SubNet,@GetWay,@Vlan,@PortTD_CTH,@PortTD_TTTH,@SwL2_TD,@SwL2_BM,@SwL3,@PatchL2,@PatchL3,@TBTC,@DTDD,@DiaChi,@GhiChu, @HinhAnh4, @HinhAnh3, @HinhAnh2, @HinhAnh1, @ThietBiDuPhong, @HienThi, @UPS, @Loa, @Micro, @Password, @Serial, @TenTrangBi)";
            try
            {
                conn.Open();
                cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.Add("@TenDiemCau", SqlDbType.NVarChar).Value = CTH.TenDiemCau;
                cmd.Parameters.Add("@DonViQL", SqlDbType.NVarChar).Value = CTH.DonViQL;
                cmd.Parameters.Add("@TTTH", SqlDbType.NVarChar).Value = CTH.TTTH;
                cmd.Parameters.Add("@IP", SqlDbType.NVarChar).Value = CTH.IP;
                cmd.Parameters.Add("@SubNet", SqlDbType.NVarChar).Value = CTH.SubNet;
                cmd.Parameters.Add("@GetWay", SqlDbType.NVarChar).Value = CTH.GetWay;
                cmd.Parameters.Add("@Vlan", SqlDbType.NVarChar).Value = CTH.Vlan;
                cmd.Parameters.Add("@PortTD_CTH", SqlDbType.NVarChar).Value = CTH.PortTD_CTH;
                cmd.Parameters.Add("@PortTD_TTTH", SqlDbType.NVarChar).Value = CTH.PortTD_TTTH;
                cmd.Parameters.Add("@SwL2_TD", SqlDbType.NVarChar).Value = CTH.SwL2_TD;
                cmd.Parameters.Add("@SwL2_BM", SqlDbType.NVarChar).Value = CTH.SwL2_BM;
                cmd.Parameters.Add("@SwL3", SqlDbType.NVarChar).Value = CTH.SwL3;
                cmd.Parameters.Add("@PatchL2", SqlDbType.NVarChar).Value = CTH.PatchL2;
                cmd.Parameters.Add("@PatchL3", SqlDbType.NVarChar).Value = CTH.PatchL3;
                cmd.Parameters.Add("@TBTC", SqlDbType.NVarChar).Value = CTH.TBTC;
                cmd.Parameters.Add("@DTDD", SqlDbType.NVarChar).Value = CTH.DTDD;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = CTH.DiaChi;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = CTH.GhiChu;
                cmd.Parameters.Add("@TenTrangBi", SqlDbType.NVarChar).Value = CTH.TenTrangBi;
                cmd.Parameters.Add("@Serial", SqlDbType.NVarChar).Value = CTH.Serial;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = CTH.Password;
                cmd.Parameters.Add("@Micro", SqlDbType.NVarChar).Value = CTH.Micro;
                cmd.Parameters.Add("@Loa", SqlDbType.NVarChar).Value = CTH.Loa;
                cmd.Parameters.Add("@UPS", SqlDbType.NVarChar).Value = CTH.UPS;
                cmd.Parameters.Add("@HienThi", SqlDbType.NVarChar).Value = CTH.HienThi;
                cmd.Parameters.Add("@ThietBiDuPhong", SqlDbType.NVarChar).Value = CTH.ThietBiDuPhong;
                cmd.Parameters.Add("@HinhAnh1", SqlDbType.VarBinary).Value = CTH.HinhAnh_1;
                cmd.Parameters.Add("@HinhAnh2", SqlDbType.VarBinary).Value = CTH.HinhAnh_2;
                cmd.Parameters.Add("@HinhAnh3", SqlDbType.VarBinary).Value = CTH.HinhAnh_3;
                cmd.Parameters.Add("@HinhAnh4", SqlDbType.VarBinary).Value = CTH.HinhAnh_4;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;

        }
        public bool Delete(cls_CauTruyenHinh CTH)
        {
            string SQL = "DELETE tbl_CTH  WHERE ID= @Id";
            using (conn  = cls_KetNoi.KetNoi())
                try
                {
                    conn.Open();
                    cmd = new SqlCommand(SQL, conn);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = CTH.Id;
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
                catch (Exception ex)
                {
                    return false;
                }
            return true;
        }

        public bool Update(cls_CauTruyenHinh CTH)
        {
            conn = cls_KetNoi.KetNoi();
            string SQL = "UPDATE tbl_CTH SET TenDiemCau = @TenDiemCau, DonViQL = @DonViQL, TTTH = @TTTH, IP = @IP, SubNet = @SubNet, GetWay = @GetWay," +
                " Vlan = @Vlan, PortTD_CTH = @PortTD_CTH, PortTD_TTTH = @PortTD_TTTH, SwL2_TD = @SwL2_TD," +
                "SwL2_BM = @SwL2_BM, SwL3 = @SwL3, PatchL2 = @PatchL2, PatchL3 = @PatchL3, TBTC = @TBTC, DTDD = @DTDD, DiaChi = @DiaChi, GhiChu = @GhiChu," +
                "ThietBiDuPhong = @ThietBiDuPhong,HienThi = @HienThi,UPS = @UPS,Loa= @Loa,Micro= @Micro,Password = @Password,Serial= @Serial,TenTrangBi = @TenTrangBi, HinhAnh1 = @HinhAnh1,HinhAnh2 = @HinhAnh2,HinhAnh3 = @HinhAnh3,HinhAnh4 = @HinhAnh4 WHERE id = id";
            try
            {
                conn.Open();
                cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = CTH.Id;
                cmd.Parameters.Add("@TenDiemCau", SqlDbType.NVarChar).Value = CTH.TenDiemCau;
                cmd.Parameters.Add("@DonViQL", SqlDbType.NVarChar).Value = CTH.DonViQL;
                cmd.Parameters.Add("@TTTH", SqlDbType.NVarChar).Value = CTH.TTTH;
                cmd.Parameters.Add("@IP", SqlDbType.NVarChar).Value = CTH.IP;
                cmd.Parameters.Add("@SubNet", SqlDbType.NVarChar).Value = CTH.SubNet;
                cmd.Parameters.Add("@GetWay", SqlDbType.NVarChar).Value = CTH.GetWay;
                cmd.Parameters.Add("@Vlan", SqlDbType.NVarChar).Value = CTH.Vlan;
                cmd.Parameters.Add("@PortTD_CTH", SqlDbType.NVarChar).Value = CTH.PortTD_CTH;
                cmd.Parameters.Add("@PortTD_TTTH", SqlDbType.NVarChar).Value = CTH.PortTD_TTTH;
                cmd.Parameters.Add("@SwL2_TD", SqlDbType.NVarChar).Value = CTH.SwL2_TD;
                cmd.Parameters.Add("@SwL2_BM", SqlDbType.NVarChar).Value = CTH.SwL2_BM;
                cmd.Parameters.Add("@SwL3", SqlDbType.NVarChar).Value = CTH.SwL3;
                cmd.Parameters.Add("@PatchL2", SqlDbType.NVarChar).Value = CTH.PatchL2;
                cmd.Parameters.Add("@PatchL3", SqlDbType.NVarChar).Value = CTH.PatchL3;
                cmd.Parameters.Add("@TBTC", SqlDbType.NVarChar).Value = CTH.TBTC;
                cmd.Parameters.Add("@DTDD", SqlDbType.NVarChar).Value = CTH.DTDD;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = CTH.DiaChi;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = CTH.GhiChu;
                cmd.Parameters.Add("@TenTrangBi", SqlDbType.NVarChar).Value = CTH.TenTrangBi;
                cmd.Parameters.Add("@Serial", SqlDbType.NVarChar).Value = CTH.Serial;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = CTH.Password;
                cmd.Parameters.Add("@Micro", SqlDbType.NVarChar).Value = CTH.Micro;
                cmd.Parameters.Add("@Loa", SqlDbType.NVarChar).Value = CTH.Loa;
                cmd.Parameters.Add("@UPS", SqlDbType.NVarChar).Value = CTH.UPS;
                cmd.Parameters.Add("@HienThi", SqlDbType.NVarChar).Value = CTH.HienThi;
                cmd.Parameters.Add("@ThietBiDuPhong", SqlDbType.NVarChar).Value = CTH.ThietBiDuPhong;
                cmd.Parameters.Add("@HinhAnh1", SqlDbType.VarBinary).Value = CTH.HinhAnh_1;
                cmd.Parameters.Add("@HinhAnh2", SqlDbType.VarBinary).Value = CTH.HinhAnh_2;
                cmd.Parameters.Add("@HinhAnh3", SqlDbType.VarBinary).Value = CTH.HinhAnh_3;
                cmd.Parameters.Add("@HinhAnh4", SqlDbType.VarBinary).Value = CTH.HinhAnh_4;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        public DataTable Find(string keyWord)
        {
            string sql = "SELECT * FROM tbl_CTH WHERE IP like N'%" + keyWord 

                + "%' or DonViQL like N'%" + keyWord
                + "%' or TTTH like N'%" + keyWord
                + "%' or IP like N'%" + keyWord
                + "%' or SubNet like N'%" + keyWord
                + "%' or GetWay like N'%" + keyWord
                + "%' or Vlan like N'%" + keyWord
                + "%' or PortTD_CTH like N'%" + keyWord
                + "%' or PortTD_TTTH like N'%" + keyWord
                + "%' or SwL2_TD like N'%" + keyWord
                + "%' or SwL2_BM like N'%" + keyWord
                + "%' or SwL3 like N'%" + keyWord
                + "%' or PatchL2 like N'%" + keyWord
                + "%' or PatchL3 like N'%" + keyWord
                + "%' or TBTC like N'%" + keyWord
                + "%' or DTDD like N'%" + keyWord
                + "%' or DiaChi like N'%" + keyWord
                + "%' or GhiChu like N'%" + keyWord
                + "%' or TenTrangBi like N'%" + keyWord
                + "%' or Serial like N'%" + keyWord
                + "%' or UPS like N'%" + keyWord
                + "%' or ThietBiDuPhong like N'%" + keyWord
                + "%' or HienThi like N'%" + keyWord
                + "%' or Loa like N'%" + keyWord
                + "%' or Micro like N'%" + keyWord
                + "%'";
            DataTable dt = new DataTable();
            using (conn = cls_KetNoi.KetNoi())
                try
                {
                    conn.Open();
                    da = new SqlDataAdapter(sql, conn);
                    da.Fill(dt);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                }
            return dt;
        }
    }
}