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
    public partial class Data_User : Form
    {
        SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-72UC5DDV\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True");
        string sqlstr;
        public Data_User()
        {
            InitializeComponent();
        }

        private void Data_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDataSet1.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter1.Fill(this.loginDataSet1.Login);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("isi semua data dulu");
            }
            else
            {
                Conn.Open();
                sqlstr = "INSERT INTO Login (nama, password, Admin) VALUES (@nama, @password, @admin)";
                SqlCommand cmd1 = new SqlCommand(sqlstr, Conn);
                cmd1.Parameters.AddWithValue("@nama", textBox1.Text);
                cmd1.Parameters.AddWithValue("@password", textBox2.Text);
                cmd1.Parameters.AddWithValue("@admin", comboBox1.Text);
                cmd1.ExecuteNonQuery();
                MessageBox.Show(" Data berhasil ditambahkan!");
                Conn.Close();
                this.loginTableAdapter1.Fill(this.loginDataSet1.Login);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("yakin akan menghapus user " + textBox1.Text + " ?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Conn.Open();
                sqlstr = "Delete Login WHERE nama = @nama";
                SqlCommand cmd = new SqlCommand(sqlstr, Conn);
                cmd.Parameters.AddWithValue("@nama", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("user berhasil di hapus");
                Conn.Close();
                this.loginTableAdapter1.Fill(this.loginDataSet1.Login);
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            this.loginTableAdapter1.Fill(this.loginDataSet1.Login);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Conn.Open();
            sqlstr = "SELECT * FROM Login WHERE nama = @nama";
            SqlCommand cmd2 = new SqlCommand(sqlstr, Conn);
            cmd2.Parameters.AddWithValue("@nama", textBox1.Text);
            cmd2.ExecuteNonQuery();
            SqlDataReader dri = cmd2.ExecuteReader();
            if (dri.Read())
            {
                textBox1.Text = dri[0].ToString();
                textBox2.Text = dri[2].ToString();
                comboBox1.Text = dri[1].ToString();
            }
            else
            {

            }
            Conn.Close();
        }
    }
}
