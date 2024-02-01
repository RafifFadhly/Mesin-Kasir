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
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-72UC5DDV\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True");
        Menu menu = new Menu();
        public string sqlstr;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            sqlstr = "SELECT * FROM Login WHERE nama = @nama";
            SqlCommand cmd2 = new SqlCommand(sqlstr, conn);
            cmd2.Parameters.AddWithValue("@nama", textBox1.Text);
            cmd2.ExecuteNonQuery();
            SqlDataReader dri = cmd2.ExecuteReader();
            if (dri.Read())
            {
                label3.Text = dri[1].ToString();
            }
            else
            {

            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlstr;
            conn.Open();
            sqlstr = "SELECT * FROM Login WHERE nama = @nama AND password = @password";
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            cmd.Parameters.AddWithValue("@nama", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            SqlDataReader dri = cmd.ExecuteReader();
            if (dri.Read())
            {
                this.Hide();
                menu.Show();
                setting();
                if (label3.Text == "pegawai")
                {
                    menu.fileToolStripMenuItem.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show(" Salah Password", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            menu.label1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void setting() //nampilin jumlah penghasilan dari mesin kasir
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
                menu.textBox1.Text = "Rp." + totalHarga.ToString() + ",00";
            }
        }
    }
}