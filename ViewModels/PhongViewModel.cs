using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp2.ViewModels
{
    class PhongViewModel : ViewModelBase
    {
        PHONG _phong;

        public PHONG Phong
        {
            get
            {
                return _phong;
            }

            set
            {
                _phong = value;
            }
        }

        public string TenPhong
        {
            get { return _phong.TENPHONG; }
            set { _phong.TENPHONG = value; RaisePropertyChanged("TenPhong"); }
        }

        public string LoaiPhong
        {
            get { return _phong.LOAIPHONG.TENLOAIPHONG; }
            set { _phong.LOAIPHONG.TENLOAIPHONG = value; RaisePropertyChanged("LoaiPhong"); }
        }

        public Int32 DonGia
        {
            get { return _phong.LOAIPHONG.DONGIA; }
            set { _phong.LOAIPHONG.DONGIA = value; RaisePropertyChanged("DonGia"); }
        }

        public string TinhTrang
        {
            get { return _phong.TINHTRANG; }
            set { _phong.TINHTRANG = value; RaisePropertyChanged("TinhTrang"); }
        }

        public string GhiChu
        {
            get { return _phong.GHICHU; }
            set { _phong.GHICHU = value; RaisePropertyChanged("GhiChu"); }
        }

       

    }
}
