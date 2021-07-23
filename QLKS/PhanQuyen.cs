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
    public partial class PhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        PhongBLLDAL ks = new PhongBLLDAL();
        public PhanQuyen()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_QuanLyKS_HC_DataSet1.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter1.Fill(this.qlks1.Account);
            this.qL_NhomNguoiDungTableAdapter1.Fill(this.qlks1.QL_NhomNguoiDung);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ks.CapNhatChucVu(int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()), int.Parse(comboBox1.SelectedValue.ToString()));
            MessageBox.Show("Thay đổi chức vụ nhân viên thành công");
        }
    }
}