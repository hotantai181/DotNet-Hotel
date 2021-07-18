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
    public partial class ThemDv : DevExpress.XtraEditors.XtraForm
    {
        PhongBLLDAL ks = new PhongBLLDAL();
        public ThemDv()
        {
            InitializeComponent();
         
        }
        public string phong
        { set { comboBox1.Text = value; } }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
             ks.ThemCTHD(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()),int.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString()),int.Parse(comboBox2.SelectedValue.ToString()),1,int.Parse(textBox2.Text));           
             this.Close();
        }

        private void ThemDv_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = ks.loadDV();
            comboBox2.DataSource = ks.loadDV();
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "id";
            comboBox1.DataSource = ks.loadDVPhong();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Idp";
            dataGridView2.DataSource = ks.loadHDTheoPhong(int.Parse(comboBox1.SelectedValue.ToString()));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == comboBox2.Text)
                    textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}