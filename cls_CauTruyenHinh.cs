using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMangTHTT
{
    public class cls_CauTruyenHinh
   
    {
        private int _id;
        private string _TenDiemCau;
        private string _DonViQL;
        private string _TTTH;
        private string _IP;
        private string _SubNet;
        private string _GetWay;
        private string _Vlan;
        private string _PortTD_CTH;
        private string _PortTD_TTTH;
        private string _SwL2_TD;
        private string _SwL2_BM;
        private string _SwL3;
        private string _PatchL2;
        private string _PatchL3;
        private string _TBTC;
        private string _DTDD;
        private string _DiaChi;
        private string _GhiChu;
        private string _TenTrangBi;
        private string _Serial;
        private string _Password;
        private string _Micro;
        private string _Loa;
        private string _UPS;
        private string _HienThi;
        private string _ThietBiDuPhong;
        private byte[] _HinhAnh_1;
        private byte[] _HinhAnh_2;
        private byte[] _HinhAnh_3;
        private byte[] _HinhAnh_4;

        public cls_CauTruyenHinh()
        {
        }

        public cls_CauTruyenHinh(string tenDiemCau, string donViQL, string tTTH, string iP, string subNet, string getWay, string vlan, string portTD_CTH, string portTD_TTTH, string swL2_TD, string swL2_BM, string swL3, string patchL2, string patchL3, string tBTC, string dTDD, string diaChi, string ghiChu, string tenTrangBi, string serial, string password, string micro, string loa, string uPS, string hienThi, string thietBiDuPhong, byte[] hinhAnh_1, byte[] hinhAnh_2, byte[] hinhAnh_3, byte[] hinhAnh_4)
        {
            TenDiemCau = tenDiemCau;
            DonViQL = donViQL;
            TTTH = tTTH;
            IP = iP;
            SubNet = subNet;
            GetWay = getWay;
            Vlan = vlan;
            PortTD_CTH = portTD_CTH;
            PortTD_TTTH = portTD_TTTH;
            SwL2_TD = swL2_TD;
            SwL2_BM = swL2_BM;
            SwL3 = swL3;
            PatchL2 = patchL2;
            PatchL3 = patchL3;
            TBTC = tBTC;
            DTDD = dTDD;
            DiaChi = diaChi;
            GhiChu = ghiChu;
            TenTrangBi = tenTrangBi;
            Serial = serial;
            Password = password;
            Micro = micro;
            Loa = loa;
            UPS = uPS;
            HienThi = hienThi;
            ThietBiDuPhong = thietBiDuPhong;
            HinhAnh_1 = hinhAnh_1;
            HinhAnh_2 = hinhAnh_2;
            HinhAnh_3 = hinhAnh_3;
            HinhAnh_4 = hinhAnh_4;
        }

        public cls_CauTruyenHinh(int id, string tenDiemCau, string donViQL, string tTTH, string iP, string subNet, string getWay, string vlan, string portTD_CTH, string portTD_TTTH, string swL2_TD, string swL2_BM, string swL3, string patchL2, string patchL3, string tBTC, string dTDD, string diaChi, string ghiChu, string tenTrangBi, string serial, string password, string micro, string loa, string uPS, string hienThi, string thietBiDuPhong, byte[] hinhAnh_1, byte[] hinhAnh_2, byte[] hinhAnh_3, byte[] hinhAnh_4)
        {
            Id = id;
            TenDiemCau = tenDiemCau;
            DonViQL = donViQL;
            TTTH = tTTH;
            IP = iP;
            SubNet = subNet;
            GetWay = getWay;
            Vlan = vlan;
            PortTD_CTH = portTD_CTH;
            PortTD_TTTH = portTD_TTTH;
            SwL2_TD = swL2_TD;
            SwL2_BM = swL2_BM;
            SwL3 = swL3;
            PatchL2 = patchL2;
            PatchL3 = patchL3;
            TBTC = tBTC;
            DTDD = dTDD;
            DiaChi = diaChi;
            GhiChu = ghiChu;
            TenTrangBi = tenTrangBi;
            Serial = serial;
            Password = password;
            Micro = micro;
            Loa = loa;
            UPS = uPS;
            HienThi = hienThi;
            ThietBiDuPhong = thietBiDuPhong;
            HinhAnh_1 = hinhAnh_1;
            HinhAnh_2 = hinhAnh_2;
            HinhAnh_3 = hinhAnh_3;
            HinhAnh_4 = hinhAnh_4;
        }

        public int Id { get => _id; set => _id = value; }
        public string TenDiemCau { get => _TenDiemCau; set => _TenDiemCau = value; }
        public string DonViQL { get => _DonViQL; set => _DonViQL = value; }
        public string TTTH { get => _TTTH; set => _TTTH = value; }
        public string IP { get => _IP; set => _IP = value; }
        public string SubNet { get => _SubNet; set => _SubNet = value; }
        public string GetWay { get => _GetWay; set => _GetWay = value; }
        public string Vlan { get => _Vlan; set => _Vlan = value; }
        public string PortTD_CTH { get => _PortTD_CTH; set => _PortTD_CTH = value; }
        public string PortTD_TTTH { get => _PortTD_TTTH; set => _PortTD_TTTH = value; }
        public string SwL2_TD { get => _SwL2_TD; set => _SwL2_TD = value; }
        public string SwL2_BM { get => _SwL2_BM; set => _SwL2_BM = value; }
        public string SwL3 { get => _SwL3; set => _SwL3 = value; }
        public string PatchL2 { get => _PatchL2; set => _PatchL2 = value; }
        public string PatchL3 { get => _PatchL3; set => _PatchL3 = value; }
        public string TBTC { get => _TBTC; set => _TBTC = value; }
        public string DTDD { get => _DTDD; set => _DTDD = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
        public string TenTrangBi { get => _TenTrangBi; set => _TenTrangBi = value; }
        public string Serial { get => _Serial; set => _Serial = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string Micro { get => _Micro; set => _Micro = value; }
        public string Loa { get => _Loa; set => _Loa = value; }
        public string UPS { get => _UPS; set => _UPS = value; }
        public string HienThi { get => _HienThi; set => _HienThi = value; }
        public string ThietBiDuPhong { get => _ThietBiDuPhong; set => _ThietBiDuPhong = value; }
        public byte[] HinhAnh_1 { get => _HinhAnh_1; set => _HinhAnh_1 = value; }
        public byte[] HinhAnh_2 { get => _HinhAnh_2; set => _HinhAnh_2 = value; }
        public byte[] HinhAnh_3 { get => _HinhAnh_3; set => _HinhAnh_3 = value; }
        public byte[] HinhAnh_4 { get => _HinhAnh_4; set => _HinhAnh_4 = value; }
    }
}
