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
    public partial class HoSoKhach : DevExpress.XtraEditors.XtraForm
    {
        PhongBLLDAL ks = new PhongBLLDAL();
        public HoSoKhach()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DatPhong dp = new DatPhong();
            dp.Show();
        }

        private void HoSoKhach_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ks.loadKHDP();
        }
    }
}