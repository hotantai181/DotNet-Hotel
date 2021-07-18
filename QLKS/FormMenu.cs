using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BLL_DAL;
namespace QLKS
{
    public partial class FormMenu : DevExpress.XtraEditors.XtraForm
    {
        PhongBLLDAL ks = new PhongBLLDAL();
        
        public string Username;
        public FormMenu(string username)
        {
            InitializeComponent();
            this.Username = username;
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            SoDoPhong  frm  = new SoDoPhong();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            btnDSDP.Enabled = true ;
            btnSDP.Enabled = false;
            btnHSK.Enabled = true;
            btnLT.Enabled = true;
            btnNV.Enabled = true;
            btnTT.Enabled = true;
            barStaticItem2.Caption = Username.ToUpper();
        }

        private void btnDSDP_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            ChiTietDatPhong frm = new ChiTietDatPhong();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            btnDSDP.Enabled = false;
            btnSDP.Enabled = true;
            btnHSK.Enabled = true;
            btnLT.Enabled = true;
            btnNV.Enabled = true;
            btnTT.Enabled = true;
            btndv.Enabled = true;
        }

        private void btnSDP_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            SoDoPhong frm = new SoDoPhong();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            btnDSDP.Enabled = true;
            btnSDP.Enabled = false;
            btnHSK.Enabled = true;
            btnLT.Enabled = true;
            btnNV.Enabled = true;
            btnTT.Enabled = true;
            btndv.Enabled = true;
        }

        private void btnLT_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            LeTan frm = new LeTan();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            btnDSDP.Enabled = true;
            btnSDP.Enabled = true;
            btnHSK.Enabled = true;
            btnLT.Enabled = false;
            btnNV.Enabled = true;
            btndv.Enabled = true;
            btnTT.Enabled = true;
        }

        private void btnHSK_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            HoSoKhach frm = new HoSoKhach();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            btnDSDP.Enabled = true;
            btnSDP.Enabled = true;
            btnHSK.Enabled = false;
            btnLT.Enabled = true;
            btnNV.Enabled = true;
            btndv.Enabled = true;
            btnTT.Enabled = true;
        }

        private void btnNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            NhanVien frm = new NhanVien();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            btnDSDP.Enabled = true;
            btnSDP.Enabled = true;
            btnHSK.Enabled = true;
            btnLT.Enabled = true;
            btnNV.Enabled = false;
            btnTT.Enabled = true;
            btndv.Enabled = true;
        }

        private void btnTT_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            TraPhong frm = new TraPhong();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            btnDSDP.Enabled = true;
            btnSDP.Enabled = true;
            btnHSK.Enabled = true;
            btnLT.Enabled = true;
            btnNV.Enabled = true;
            btnTT.Enabled = false;
            btndv.Enabled = true;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            DichVu frm = new DichVu();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            btnDSDP.Enabled = true;
            btnSDP.Enabled = true;
            btnHSK.Enabled = true;
            btnLT.Enabled = true;
            btnNV.Enabled = true;
            btnTT.Enabled = true;
            btndv.Enabled = false;
        }

        private void barStaticItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Close();
        }
    }
}