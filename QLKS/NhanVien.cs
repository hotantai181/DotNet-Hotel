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
    public partial class NhanVien : DevExpress.XtraEditors.XtraForm
    {
        PhongBLLDAL ks = new PhongBLLDAL();
        public string Chucvu
        { set { textBox1.Text = value; } }
        public NhanVien()
        {
            InitializeComponent();
            loadNV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Lễ Tân")
            {
                MessageBox.Show("Bạn không đủ quyền để thực hiện");
            }
            else
            {
                LeTan lt = new LeTan();
                lt.Show();
            }
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
        }

        public void loadNV()
        {
            dataGridView1.DataSource = ks.loadNV();
            comboBox1.DataSource = ks.loadNV();
            comboBox1.DisplayMember = "username";
            comboBox1.ValueMember = "id";
            dataGridView2.DataSource = ks.loadNVTheoMa(int.Parse(comboBox1.SelectedValue.ToString()));
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Lễ Tân")
            {
                MessageBox.Show("Bạn không đủ quyền để thực hiện");
            }
            else
            {
                PhanQuyen phanQuyen = new PhanQuyen();
                phanQuyen.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Lễ Tân")
            {
                MessageBox.Show("Bạn không đủ quyền để thực hiện");
            }
            else
            {
                if(textBox6.Text == dataGridView2.CurrentRow.Cells[1].Value.ToString())
                {
                    ks.CapNhatMatKhau(int.Parse(comboBox1.SelectedValue.ToString()), textBox7.Text);
                    MessageBox.Show("Cập nhật mật khẩu thành công");
                    textBox6.Clear();
                    textBox7.Clear();
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác");
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dataGridView2.DataSource = ks.loadNVTheoMa(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
        }

        private void btnRs_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ks.loadNV();
        }
    }
}