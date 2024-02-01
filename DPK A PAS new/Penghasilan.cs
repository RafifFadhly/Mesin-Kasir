using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DPK_A_PAS_new
{
    public partial class Penghasilan : Form
    {
        public Penghasilan()
        {
            InitializeComponent();
        }

        private void Pesanan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'penghasilanDataSet2.penghasilan' table. You can move, or remove it, as needed.
            this.penghasilanTableAdapter.Fill(this.penghasilanDataSet2.penghasilan);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("yakin akan menghapus Semua Data ?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-72UC5DDV\SQLEXPRESS;Initial Catalog=penghasilan;Integrated Security=True");
                string sqlstr = "TRUNCATE TABLE penghasilan";
                Conn.Open();
                SqlCommand cmd1 = new SqlCommand(sqlstr, Conn);
                cmd1.ExecuteNonQuery();
                Conn.Close();
                this.penghasilanTableAdapter.Fill(this.penghasilanDataSet2.penghasilan);
                MessageBox.Show(" Semua Data berhasil direset!");
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data data = new data();
            data.Batas();
            this.penghasilanTableAdapter.Fill(this.penghasilanDataSet2.penghasilan);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
