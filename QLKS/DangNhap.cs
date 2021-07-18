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
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using BLL_DAL;

namespace QLKS
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        PhongBLLDAL ks = new PhongBLLDAL();
        public DangNhap()
        {
            InitializeComponent();
        }
    private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (ks.KTDN(textEdit1.Text, textEdit2.Text))
            {
                this.Hide();
                FormMenu menu = new FormMenu(textEdit1.Text);
                menu.Show();
            }
            else
                MessageBox.Show("Tên tài khoản hoặc mặt khẩu không đúng");
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}