using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMangTHTT
{
    internal class cls_ThietBi
    {
        private int _id;
        private string _ThietBiTruyenHinh;
        private string _Serial;
        private string _Micro;
        private string _Loa;
        private string _HienThi;
        private string _UPS;
        private string _ThietBiDuPhong;
        private string _ChiTietKhac;

        public cls_ThietBi()
        {
        }

        public cls_ThietBi(string thietBiTruyenHinh, string serial, string micro, string loa, string hienThi, string uPS, string thietBiDuPhong, string chiTietKhac)
        {
            ThietBiTruyenHinh = thietBiTruyenHinh;
            Serial = serial;
            Micro = micro;
            Loa = loa;
            HienThi = hienThi;
            UPS = uPS;
            ThietBiDuPhong = thietBiDuPhong;
            ChiTietKhac = chiTietKhac;
        }

        public cls_ThietBi(int id, string thietBiTruyenHinh, string serial, string micro, string loa, string hienThi, string uPS, string thietBiDuPhong, string chiTietKhac)
        {
            Id = id;
            ThietBiTruyenHinh = thietBiTruyenHinh;
            Serial = serial;
            Micro = micro;
            Loa = loa;
            HienThi = hienThi;
            UPS = uPS;
            ThietBiDuPhong = thietBiDuPhong;
            ChiTietKhac = chiTietKhac;
        }

        public int Id { get => _id; set => _id = value; }
        public string ThietBiTruyenHinh { get => _ThietBiTruyenHinh; set => _ThietBiTruyenHinh = value; }
        public string Serial { get => _Serial; set => _Serial = value; }
        public string Micro { get => _Micro; set => _Micro = value; }
        public string Loa { get => _Loa; set => _Loa = value; }
        public string HienThi { get => _HienThi; set => _HienThi = value; }
        public string UPS { get => _UPS; set => _UPS = value; }
        public string ThietBiDuPhong { get => _ThietBiDuPhong; set => _ThietBiDuPhong = value; }
        public string ChiTietKhac { get => _ChiTietKhac; set => _ChiTietKhac = value; }
    }
}
