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
        QL_NguoiDung nd = new QL_NguoiDung();
        PhongBLLDAL ks = new PhongBLLDAL();
        public DangNhap()
        {
            InitializeComponent();
        }
        public void ProcessLogin()
        {
            LoginResult result;
            result = nd.Check_User(textEdit1.Text, textEdit2.Text);
            if (result == LoginResult.Invalid)
            {
                MessageBox.Show("Sai" + label1.Text + " Hoac " + label2.Text);
                return;
            }
            else if (result == LoginResult.Disabled)
            {
                MessageBox.Show("Tai khoan bi khoa");
                return;
            }
            if (Program.femmenu == null || Program.femmenu.IsDisposed)
            {
                Program.femmenu = new FormMenu(textEdit1.Text);
            }
            this.Visible = false;
            Program.femmenu.Show();
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEdit1.Text.Trim()))

            {
                MessageBox.Show("Không được bỏ trống " + label1.Text.ToLower());
                this.textEdit1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textEdit2.Text))
            {
                MessageBox.Show("Không được bỏ trống " + label2.Text.ToLower());
                this.textEdit2.Focus();
                return;
            }
            int kq = nd.Check_Config();
            if (kq == 0)
            {
                ProcessLogin();
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuoi cau hinh khong ton tai");
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuoi cau hinh khong phu hop");
            }

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