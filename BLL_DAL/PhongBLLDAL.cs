using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Windows.Documents;
using DevExpress.Data.TreeList;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;

namespace BLL_DAL
{
    public class PhongBLLDAL
    {
        QLKSDataContext _QLKS = new QLKSDataContext();
        public PhongBLLDAL()
        { }
        //        //    //  //      /// //  LOAD DATA  //       //  //  //  //  ///
        #region Load Data
        public IQueryable loadKHDP()
        {
            IQueryable KH =
                            from t in _QLKS.KhachHangs
                            select new
                            {
                                ID = t.id,
                                Name = t.name,
                                Gt = t.Gt,
                                CMND = t.CMND,
                                DT = t.DTLH,
                            };
            return KH;                         
        }
        public IQueryable loadSPPhong()
        {
            IQueryable var = from u in _QLKS.SanPhams
                             from h in _QLKS.ChiTietHoaDons
                             where u.id == h.idSanPham
                             select new
                             {
                                 ID = u.id,
                                 Name = u.name,
                                 idPhong = h.idPhong,
                                 Sl = u.soluong,
                                 DonGia = u.priceSP,
                             };
            return var;
        }
        public IQueryable loadDV()
        {
            IQueryable var = from u in _QLKS.DichVus
                             select new
                             {
                                 ID = u.id,
                                 Name = u.name,
                                 Price = u.priceDv,
                             };
            return var;
        }
        public IQueryable loadPhong()
        {
            IQueryable var = from u in _QLKS.Phongs
                             select new
                             {
                                 ID = u.id,
                                 Name = u.name,
                                 Status = u.status,
                             };
            return var;
        }
        public IQueryable loadSP()
        {
            IQueryable var = from u in _QLKS.SanPhams
                             select new
                             {
                                 ID = u.id,
                                 Name = u.name,
                                 Price = u.priceSP,
                             };
            return var;
        }
        public IQueryable loadDTPhong()
        {
            IQueryable table = from t in _QLKS.DatPhongs
                               from u in _QLKS.Phongs
                               where t.idPhong == u.id
                               select new
                               {
                                   iDPhong = t.idPhong,
                                   name = u.name,
                               };
            return table;
        }
        public IQueryable loadHDDV()
        {
            IQueryable table = from t in _QLKS.ChiTietHoaDons
                               from u in _QLKS.DichVus
                               where t.idPhong == u.id
                               select new
                               {
                                   ID = t.id,
                                   iDPhong = t.idPhong,
                                   Name = u.name,
                                   Sl = u.soluong,
                               };
            return table;
        }
        public IQueryable loadNV()
        {
            IQueryable table = from nv in _QLKS.Accounts
                               select new
                               {
                                   ID = nv.id,
                                   Name = nv.Dislayname,
                                   NgSinh = nv.NgaySinh,
                                   GT = nv.Gt,
                                   username = nv.Username,
                                   type = nv.Type,
                               };
            return table;
        }
        public IQueryable loadHD()
        {
            IQueryable table = from t in _QLKS.HoaDons
                               where t.status == 0
                               select new
                               {
                                   ID = t.id,
                                   iDPhong = t.idPhong,
                                   dateCheckIn = t.DateCheckIn,
                                   dateCheckOut = t.DateCheckOut,
                                  
                                   Status = t.status,
                               };
            return table;
        }
        public IQueryable loadDatPhong()
        {
            return _QLKS.DatPhongs.Select(k => k);
        }
        public IQueryable loadNVTheoMa(int pid)
        {
            IQueryable table = from nv in _QLKS.Accounts
                               where nv.id == pid
                               select new
                               {
                                   Id = nv.id,
                                   Pass = nv.PassWord,
                               };
            return table;
        }
        public IQueryable loadDVPhong()
        {
            IQueryable table = from u in _QLKS.DatPhongs
                               from p in _QLKS.Phongs
                               where u.idPhong == p.id
                               select new
                               {
                                   Name= p.name,
                                   Idp = u.idPhong,
                               };
            return table;
        }
        public IQueryable loadHDTheoPhong(int idPhong)
        {
            IQueryable table = from ct in _QLKS.HoaDons
                               where ct.idPhong == idPhong
                               select ct;
            return table;
        }
        public IQueryable loadCTHD(int idHd)
        {
            IQueryable table = from ct in _QLKS.ChiTietHoaDons
                               where ct.idHoaDon == idHd
                               select ct;
            return table;
        }
        public IQueryable loadKHTheoHD(int idPhong)
        {
            IQueryable table = from d in _QLKS.DatPhongs
                               from k in _QLKS.KhachHangs
                               where d.idKh == k.id
                               where d.idPhong == idPhong
                               select new
                               {
                                   IDKH = d.idKh,
                                   iDPhong = d.idPhong,
                                   Name = k.name,
                                   Dt = k.DTLH,
                               };
            return table;
        }
        public IQueryable loadNVTheoCV(string pUsername)
        {
            IQueryable table = from nv in _QLKS.Accounts
                               where nv.Username == pUsername
                               select new
                               {
                                   ID=nv.id,
                                   type =nv.Type,
                               };
            return table;
        }

        #endregion
        //        //    //  //      /// //  CHỨC NÀNG   //        //    //  //      /// 

        #region Kiem Tra Dang Nhap
        public bool KTDN(string pTenDN, string pMatKhau)
        {

            try
            {
                IQueryable dp = from d in _QLKS.Accounts
                                where d.Username == pTenDN
                                where d.PassWord == pMatKhau
                                select new
                                {
                                    Id = d.id,
                                };  
                if (dp != null)
                    return true;
                else return false;
            }
            catch { return false; }
        }
        #endregion

        #region Cap Nhat Dat Phong
        public void Datphong(int pIdKH, int pIdPhong,  DateTime pCheckIn, DateTime pCheckOut)
        {
            DatPhong tp = new DatPhong();
            tp.idKh = pIdKH;
            tp.idPhong = pIdPhong;
            tp.DateCheckin = pCheckIn;
            tp.DateCheckout = pCheckOut;
            _QLKS.DatPhongs.InsertOnSubmit(tp);
            _QLKS.SubmitChanges();
        }
        public void XoaDatPhong(int pIdPhong)
        {
            DatPhong tp = _QLKS.DatPhongs.Where(k => k.idPhong == pIdPhong).FirstOrDefault();
            if (tp != null)
            {
                _QLKS.DatPhongs.DeleteOnSubmit(tp);
                _QLKS.SubmitChanges();
            }
        }
        public void SuaDatPhong(int pIdPhong, int pIdKH, DateTime pCheckIn , DateTime pChekOut)
        {
            DatPhong tp = _QLKS.DatPhongs.Where(k => k.idPhong == pIdPhong).FirstOrDefault();
            if (tp != null)
            {
                tp.idPhong = pIdPhong;
                tp.idKh = pIdKH;
                tp.DateCheckin = pCheckIn;
                tp.DateCheckout = pChekOut;
                _QLKS.SubmitChanges();
            }
        }
        #endregion

        #region Tinh trang phong
        public void SuaTingTrangPhong(int pIdPhong,string tt)
        {
            Phong t = _QLKS.Phongs.Where(k => k.id == pIdPhong).FirstOrDefault();
            if (tt != null)
            {
                t.status = tt;
                _QLKS.SubmitChanges();
            }
        }
        #endregion

        #region Cap Nhat Khach Hang
        public void ThemKKH(string pTenKh, string pGT, string CMND, string DTLH)
        {
            KhachHang kh = new KhachHang();
            kh.name = pTenKh;
            kh.Gt = pGT;
            kh.CMND = CMND;
            kh.DTLH = DTLH;
            _QLKS.KhachHangs.InsertOnSubmit(kh);
            _QLKS.SubmitChanges();
        }
        public void XoaKH(int pId)
        {
            KhachHang kh = _QLKS.KhachHangs.Where(k => k.id == pId).FirstOrDefault();
            if (kh != null)
            {
                _QLKS.KhachHangs.DeleteOnSubmit(kh);
                _QLKS.SubmitChanges();
            }
        }
        public void SuaKH(int id,string pTenKh, string pGT, string CMND, string DTLH)
        {
            KhachHang kh = _QLKS.KhachHangs.Where(k => k.id == id).FirstOrDefault();
            if (kh != null)
            {
                kh.name = pTenKh;
                kh.Gt = pGT;
                kh.CMND = CMND;
                kh.DTLH = DTLH;
                _QLKS.SubmitChanges();
            }
        }

        #endregion

        #region Cap Nhat Nhan Vien
        public void ThemNV(string pDislayname, DateTime pNgaySinh, string pGt, string pUsername,string pPassWord,int pType)
        {
            Account ac = new Account();
            ac.Dislayname = pDislayname;
            ac.NgaySinh = pNgaySinh;
            ac.Gt = pGt;
            ac.Username = pUsername;
            ac.PassWord = pPassWord;
            ac.Type = pType;
            _QLKS.Accounts.InsertOnSubmit(ac);
            _QLKS.SubmitChanges();
        }
        public void XoaNV(int pId)
        {
            Account ac = _QLKS.Accounts.Where(k => k.id == pId).FirstOrDefault();
            if (ac != null)
            {
                _QLKS.Accounts.DeleteOnSubmit(ac);
                _QLKS.SubmitChanges();
            }
        }
        public void SuaNV(int id,string pDislayname, DateTime pNgaySinh, string pGt, string pUsername, string pPassWord, int pType)
        {
            Account ac = _QLKS.Accounts.Where(k => k.id == id).FirstOrDefault();
            if (ac != null)
            {
                ac.Dislayname = pDislayname;
                ac.NgaySinh = pNgaySinh;
                ac.Gt = pGt;
                ac.Username = pUsername;
                ac.PassWord = pPassWord;
                ac.Type = pType;
                _QLKS.SubmitChanges();
            }
        }

        public void CapNhatChucVu(int id, int pType)
        {
            Account ac = _QLKS.Accounts.Where(k => k.id == id).FirstOrDefault();
            if (ac != null)
            {
                ac.Type = pType;
                _QLKS.SubmitChanges();
            }
        }

        public void CapNhatMatKhau(int id, string pPassword)
        {
            Account ac = _QLKS.Accounts.Where(k => k.id == id).FirstOrDefault();
            if (ac != null)
            {
                ac.PassWord = pPassword;
                _QLKS.SubmitChanges();
            }
        }
        #endregion

        #region Cap Nhat Hoa don
        public void ThemHD(DateTime pCheckin , DateTime pCheckout , int pIdPhong , int pStatus)
        {
            HoaDon hd = new HoaDon();
            hd.DateCheckIn = pCheckin;
            hd.DateCheckOut = pCheckout;
            hd.idPhong = pIdPhong;
            hd.status = pStatus;
            _QLKS.HoaDons.InsertOnSubmit(hd);
            _QLKS.SubmitChanges();
        }
        public void XoaHD(int pId)
        {
            HoaDon hd = _QLKS.HoaDons.Where(k => k.id == pId).FirstOrDefault();
            if (hd != null)
            {
                _QLKS.HoaDons.DeleteOnSubmit(hd);
                _QLKS.SubmitChanges();
            }
        }
        public void SuaHD(int id, DateTime pCheckin, DateTime pCheckout, int pIdPhong, int pStatus,int pTongtien)
        {
            HoaDon hd = _QLKS.HoaDons.Where(k => k.id == id).FirstOrDefault();
            if (hd != null)
            {
                hd.DateCheckIn = pCheckin;
                hd.DateCheckOut = pCheckout;
                hd.idPhong = pIdPhong;
                hd.status = pStatus;
                hd.tongtien = pTongtien;
                _QLKS.SubmitChanges();
            }
        }

        #endregion

        #region Cap Nhat Chi Tiet Hoa Don
        public void ThemCTHD(int piDHD, int piDP, int piDDV,int piDSP, int pTT)
        {
            ChiTietHoaDon ct = new ChiTietHoaDon();
            ct.idHoaDon = piDHD;
            ct.idPhong = piDP;
            ct.idDichVu = piDDV;
            ct.idSanPham = piDSP;
            ct.tongtien = pTT;
            _QLKS.ChiTietHoaDons.InsertOnSubmit(ct);
            _QLKS.SubmitChanges();
        }
        public void XoaCTHD(int pId)
        {
            ChiTietHoaDon ct = _QLKS.ChiTietHoaDons.Where(k => k.id == pId).FirstOrDefault();
            if (ct != null)
            {
                _QLKS.ChiTietHoaDons.DeleteOnSubmit(ct);
                _QLKS.SubmitChanges();
            }
        }
        public void SuaCTHD(int id, int piDHD, int piDP, int piDDV)
        {
            ChiTietHoaDon ct = _QLKS.ChiTietHoaDons.Where(k => k.id == id).FirstOrDefault();
            if (ct != null)
            {
                ct.idHoaDon = piDHD;
                ct.idPhong = piDP;
                ct.idDichVu = piDDV;
                _QLKS.SubmitChanges();
            }
        }

        #endregion

        #region Chuc Nang Tim Kiem 

        // TIM KIEM THEO PHONG //
        public IQueryable loadTheoPhong(int idPhong)
        {
            IQueryable tp = from u in _QLKS.DatPhongs
                            where u.idPhong == idPhong
                            select new
                            {
                                Id = u.idPhong,
                                IdKhachHang = u.idKh,
                                DateCheckIn = u.DateCheckin,
                                DateCheckOut = u.DateCheckout,
                            };
            return tp;
        }
        // TIM KIEM THEO TANG//
        public IQueryable loadTheoTang(string tang)
        {
            IQueryable tp = from u in _QLKS.Phongs
                           where u.name.Substring(1, 1) == tang
                           select new
                           {
                               ID = u.id,
                               Name = u.name,
                               Status = u.status,
                           };
            return tp;
        }
        // TIM KIEM THEO TEN KH DAT Phong
        public IQueryable loadTenKH(string tenkh)
        {
            IQueryable tp = from u in _QLKS.KhachHangs
                            from d in _QLKS.DatPhongs
                            from p in _QLKS.Phongs
                            where u.name == tenkh
                            where u.id == d.idKh
                            where d.idPhong == p.id
                            select new
                            {
                                IDKH = u.name,
                                IDPhong = p.name,
                                DateCheckIn = d.DateCheckin,
                                DateChekcout = d.DateCheckin,
                            };
            return tp;
        }



        #endregion

    }
}
