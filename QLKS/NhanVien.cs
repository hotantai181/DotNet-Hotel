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
        public NhanVien()
        {
            InitializeComponent();
            dataGridView1.DataSource = ks.loadNV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LeTan lt = new LeTan();
            lt.Show();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
        }
    }
}