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

namespace DPK_A_PAS_new
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_Menu Data_Menu = new Data_Menu();
            Data_Menu.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_User Data_User = new Data_User();
            Data_User.Show();
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaksi Transaksi = new Transaksi();
            Transaksi.Show();
            Transaksi.label10.Text = label1.Text;
        }

        private void kalkulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kalkulator Kalkulator = new Kalkulator();
            Kalkulator.Show();
        }

        private void penghasilanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Penghasilan Penghasilan = new Penghasilan();
            Penghasilan.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-72UC5DDV\SQLEXPRESS;Initial Catalog=penghasilan;Integrated Security=True");
            string sqlstr = "SELECT COALESCE(SUM(Harga), 0) as TotalHarga FROM penghasilan";
            data data = new data();
            data.Batas();
            Conn.Open();
            SqlCommand cmd = new SqlCommand(sqlstr, Conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int totalHarga = Convert.ToInt32(reader["TotalHarga"]);
                textBox1.Text = "Rp." + totalHarga.ToString() + ",00";
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
