using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL_DAL;

namespace QLKS
{

    public partial class ChiTietDatPhong : DevExpress.XtraEditors.XtraForm
    {
        PhongBLLDAL ks = new PhongBLLDAL();
        public ChiTietDatPhong()
        {
            InitializeComponent();
        }
        private void btnNP_Click(object sender, EventArgs e)
        {
            DatPhong dp = new DatPhong();
            dp.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void ChiTietDatPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKSDataSet1.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.quanLyKSDataSet1.Phong);
            // TODO: This line of code loads data into the 'quanLyKSDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter1.Fill(this.quanLyKSDataSet.KhachHang);
            dataGridView1.DataSource = ks.loadDatPhong();
        }
    }
}