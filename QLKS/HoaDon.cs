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
    public partial class HoaDon : DevExpress.XtraEditors.XtraForm
    {
        PhongBLLDAL ks = new PhongBLLDAL();
        public string idHD
        { set { textBox1.Text = value; } }
        public HoaDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = ks.loadCTHD(int.Parse(textBox1.Text));
            tien();
        }
        public void tien()
        {
            int i = 0;
            int tongtien = 0;
            for (i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                tongtien += int.Parse(dataGridView2.Rows[i].Cells[6].Value.ToString());
            }
            textBox2.Text = dataGridView2.Rows[0].Cells[2].Value.ToString();
            if (int.Parse(textBox2.Text) == 1 || int.Parse(textBox2.Text) == 2 || int.Parse(textBox2.Text) == 5 || int.Parse(textBox2.Text) == 6)
            {
                tongtien += 300000;
                textBox3.Text = tongtien.ToString();
            }
            else if (int.Parse(textBox2.Text) == 3 || int.Parse(textBox2.Text) == 4 || int.Parse(textBox2.Text) == 7 || int.Parse(textBox2.Text) == 8)
            {
                tongtien += 400000;
                textBox3.Text = tongtien.ToString();
            }
            else if (int.Parse(textBox2.Text) == 9 || int.Parse(textBox2.Text) == 11)
            {
                tongtien += 500000;
                textBox3.Text = tongtien.ToString();
            }
            else
            {
                tongtien += 600000;
                textBox3.Text = tongtien.ToString();
            }
        }
    }
}