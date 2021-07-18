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
    public partial class DatPhong : DevExpress.XtraEditors.XtraForm
    {
        PhongBLLDAL ks = new PhongBLLDAL();
        public DatPhong()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            dataGridView1.DataSource = ks.loadKHDP();
            cbbPhong.DataSource = ks.loadPhong();
            cbbPhong.DisplayMember = "name";
            cbbPhong.ValueMember = "id";
            dataGridView2.DataSource = ks.loadDatPhong();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ks.ThemKKH(txtTenKh.Text, cbbGT.SelectedItem.ToString(),txtCM.Text,txtDT.Text);
            dataGridView1.DataSource = ks.loadKHDP();
        }

        private void cbbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {        
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            int d = 0;
            for (int i = 0; i <= dataGridView2.RowCount - 2; i++)
            {
                if (dataGridView2.Rows[i].Cells[1].Value.ToString() == cbbPhong.SelectedValue.ToString())
                {
                    d++;
                }
            }
            if (d == 0)
            {
                ks.Datphong(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), int.Parse(cbbPhong.SelectedValue.ToString()), DateCheckin.Value, Datecheckout.Value);
                ks.SuaTingTrangPhong(int.Parse(cbbPhong.SelectedValue.ToString()), "Đang sử dụng");
                ks.ThemHD(DateCheckin.Value, Datecheckout.Value, int.Parse(cbbPhong.SelectedValue.ToString()), 0);
            }
            else
                MessageBox.Show("Phòng đang được sử dụng");
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = ks.loadDatPhong();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ks.loadKHDP();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}