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
    public partial class DichVu : DevExpress.XtraEditors.XtraForm
    {
        PhongBLLDAL ks = new PhongBLLDAL();
        public DichVu()
        {
            InitializeComponent();
            loadCCBPhong();
            loadHD();
        }
        public void loadHD()
        {
            dataGridView3.DataSource = ks.loadHDDV();
        }
        public void loadCCBPhong()
        {
            comboBox2.DataSource = ks.loadHD();
            comboBox2.DisplayMember = "idPhong";
            comboBox2.ValueMember = "id";
            dataGridView2.DataSource = ks.loadSPPhong();
            dataGridView1.DataSource = ks.loadSP();
            cbbPhong.DataSource = ks.loadDVPhong();
            cbbPhong.DisplayMember = "Name";
            cbbPhong.ValueMember = "Idp";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ThemDv dv = new ThemDv();
            dv.phong = cbbPhong.Text;
            dv.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ks.ThemCTHD(int.Parse(comboBox2.SelectedValue.ToString()), int.Parse(cbbPhong.SelectedValue.ToString()),1, int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()));
            dataGridView2.DataSource = ks.loadSPPhong();
        }

        private void DichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKSDataSet2.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.quanLyKSDataSet2.Phong);
            // TODO: This line of code loads data into the 'quanLyKSDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.quanLyKSDataSet.KhachHang);

        }
    }
}