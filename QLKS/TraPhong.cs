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
    public partial class TraPhong : DevExpress.XtraEditors.XtraForm
    {
        PhongBLLDAL ks = new PhongBLLDAL();
        HoaDon hd = new HoaDon();
        WordExport word = new WordExport();

        public TraPhong()
        {
            InitializeComponent();
            dataGridView1.DataSource = ks.loadHD();
            txtDate.Text = DateTime.Now.ToString();
        
        }
        private void TraPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKSDataSet3.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.quanLyKSDataSet3.Phong);
            string idHD = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMP.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dataGridView2.DataSource = ks.loadCTHD(int.Parse(idHD));
            dataGridView3.DataSource = ks.loadKHTheoHD(int.Parse(txtMP.Text));
            textBox2.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            textEdit8.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ks.SuaTingTrangPhong(int.Parse(txtMP.Text),"Còn phòng");
            ks.SuaHD(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()), DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()),int.Parse(txtMP.Text),1,int.Parse(txtTT.Text));
            ks.XoaDatPhong(int.Parse(txtMP.Text));
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtMP.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string idHD = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dataGridView2.DataSource = ks.loadCTHD(int.Parse(idHD));
            dataGridView3.DataSource = ks.loadKHTheoHD(int.Parse(txtMP.Text));
            textBox2.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            textEdit8.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            tien();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.idHD = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            hd.Show();
        }
        public void tien()
        {
            int i = 0;
            int tongtien = 0;
            DateTime ngaymuon = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            DateTime ngaytra = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            TimeSpan Time = ngaytra - ngaymuon;
            int TongSoNgay = Time.Days;
            for (i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                tongtien += int.Parse(dataGridView2.Rows[i].Cells[6].Value.ToString());
            }
            if (int.Parse(txtMP.Text) == 1 || int.Parse(txtMP.Text) == 2 || int.Parse(txtMP.Text) == 5 || int.Parse(txtMP.Text) == 6)
            {
                if (TongSoNgay == 0)
                {
                    TongSoNgay = 1;
                    tongtien = tongtien + 300000 * TongSoNgay;
                    txtTT.Text = tongtien.ToString();
                }
                else
                {
                    tongtien = tongtien + 300000 * TongSoNgay;
                    txtTT.Text = tongtien.ToString();
                }
            }
            else if (int.Parse(txtMP.Text) == 3 || int.Parse(txtMP.Text) == 4 || int.Parse(txtMP.Text) == 7 || int.Parse(txtMP.Text) == 8)
            {
                if (TongSoNgay == 0)
                {
                    TongSoNgay = 1;
                    tongtien = tongtien + 400000 * TongSoNgay;
                    txtTT.Text = tongtien.ToString();
                }
                else
                {
                    tongtien = tongtien + 400000 * TongSoNgay;
                    txtTT.Text = tongtien.ToString();
                }
            }
            else if (int.Parse(txtMP.Text) == 9 || int.Parse(txtMP.Text) == 11)
            {
                if (TongSoNgay == 0)
                {
                    TongSoNgay = 1;
                    tongtien = tongtien + 500000 * TongSoNgay;
                    txtTT.Text = tongtien.ToString();
                }
                else
                {
                    tongtien = tongtien + 500000 * TongSoNgay;
                    txtTT.Text = tongtien.ToString();
                }
            }
            else
            {
                if (TongSoNgay == 0)
                {
                    TongSoNgay = 1;
                    tongtien = tongtien + 600000 * TongSoNgay;
                    txtTT.Text = tongtien.ToString();
                }
                else
                {
                    tongtien = tongtien + 600000 * TongSoNgay;
                    txtTT.Text = tongtien.ToString();
                }
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            word.HoaDonKhachSan(txtDate.Text, dataGridView1.CurrentRow.Cells[0].Value.ToString(), textBox2.Text, dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), txtMP.Text, txtTT.Text);
        }
    }
}