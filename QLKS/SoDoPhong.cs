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
    public partial class SoDoPhong : DevExpress.XtraEditors.XtraForm
    {
        PhongBLLDAL ks = new PhongBLLDAL();

        public SoDoPhong()
        {
            InitializeComponent();
            loadTable();
        }

        #region Method
        #endregion

        private void simpleButton1_Click(object sender, EventArgs e)
        {
 
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SoDoPhong_Load(sender,e);
        }
        public void loadTable()
        {
            dataGridView1.DataSource = ks.loadPhong();
            dataGridView2.DataSource = ks.loadPhong();
            dataGridView3.DataSource = ks.loadDatPhong();   
            for(int i=0; i < dataGridView2.RowCount -1;i++)
            {
                Button btn = new Button() { Width = 150, Height = 150};
                btn.Text = dataGridView2.Rows[i].Cells[1].Value.ToString() + Environment.NewLine + dataGridView2.Rows[i].Cells[2].Value.ToString();
                btn.MouseClick += btn_MouseClick;
                btn.Tag = i;
                switch (dataGridView2.Rows[i].Cells[2].Value.ToString())
                {
                    case "Còn phòng":
                        btn.BackColor = Color.Aqua;
                        break;
                    case "Được đặt":
                        btn.BackColor = Color.Lavender;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        public void btn_MouseClick(object sender,MouseEventArgs e)    
        {
            Button btnSender = (Button)sender;
            if (e.Button == MouseButtons.Left)
            {
                if (btnSender.BackColor == Color.Aqua)
                    cmsConphong.Show(Cursor.Position.X, Cursor.Position.Y);
                else if (btnSender.BackColor == Color.Red)
                    cmsCoKhach.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
        private void datPhongTrong_Click_1(object sender, EventArgs e)
        {
            DatPhong dp = new DatPhong();
            dp.Show();
        }

        private void datPhongDsd_Click(object sender, EventArgs e)
        {
            DatPhong dp = new DatPhong();
            dp.Show();
        }

        private void dichVu_Click(object sender, EventArgs e)
        {
            DichVu dv = new DichVu();
            dv.Show();
        }

        private void suaPhongDsd_Click(object sender, EventArgs e)
        {
            DatPhong dp = new DatPhong();
            dp.Show();
        }

        private void traPhong_Click(object sender, EventArgs e)
        {
            TraPhong tp = new TraPhong();
            tp.Show();
        }

        private void SoDoPhong_Load(object sender, EventArgs e)
        {
        }
    }
}