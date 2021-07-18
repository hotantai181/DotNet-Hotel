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
    public partial class LeTan : DevExpress.XtraEditors.XtraForm
    {
        PhongBLLDAL ks = new PhongBLLDAL();
        public LeTan()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rdbNu.Checked == true)
            {
                ks.ThemNV(txtName.Text, dateTimePicker1.Value, rdbNam.Text, txtTDN.Text, txtPass.Text, 1);
            }
            else
                ks.ThemNV(txtName.Text, dateTimePicker1.Value, rdbNu.Text, txtTDN.Text, txtPass.Text, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}