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
    public partial class Data_Menu : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-72UC5DDV\\SQLEXPRESS;Initial Catalog=Menu;Integrated Security=True");
        private string sqlstr;
        public Data_Menu()
        {
            InitializeComponent();
        }


        private void Data_Menu_Load(object sender, EventArgs e)
        {
            TampilBarang();
            // TODO: This line of code loads data into the 'menuDataSet4.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.menuDataSet3.Menu);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox3.Text == "0" || comboBox1.Text == "")
            {
                MessageBox.Show("Isi dulu semua data menu");
            }
            else
            {
                conn.Close();
                conn.Open();
                sqlstr = "INSERT INTO Menu ([Jenis], [Kode], [Nama], [Harga]) VALUES (@jenis, @kode, @nama, @harga)";
                SqlCommand cmd1 = new SqlCommand(sqlstr, conn);
                cmd1.Parameters.AddWithValue("@jenis", comboBox1.Text);
                cmd1.Parameters.AddWithValue("@kode", textBox1.Text);
                cmd1.Parameters.AddWithValue("@nama", textBox2.Text);
                cmd1.Parameters.AddWithValue("@harga", textBox3.Text);
                cmd1.ExecuteNonQuery();
                MessageBox.Show(" Data berhasil ditambahkan!");
                conn.Close();
                this.menuTableAdapter.Fill(this.menuDataSet3.Menu);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("yakin akan menghapus Menu " + textBox2.Text + " ?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Close();
                conn.Open();
                sqlstr = "DELETE FROM Menu WHERE [Kode]=@kode";
                SqlCommand cmd1 = new SqlCommand(sqlstr, conn);
                cmd1.Parameters.AddWithValue("@kode", textBox1.Text);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Menu berhasil di hapus");
                conn.Close();
                this.menuTableAdapter.Fill(this.menuDataSet3.Menu);
            }
            else
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-72UC5DDV\\SQLEXPRESS;Initial Catalog=Menu;Integrated Security=True");
            conn.Open();
            sqlstr = "SELECT * FROM Menu WHERE Kode = @Kode";
            SqlCommand cmd2 = new SqlCommand(sqlstr, conn);
            cmd2.Parameters.AddWithValue("@Kode", textBox1.Text);
            cmd2.ExecuteNonQuery();
            SqlDataReader dri = cmd2.ExecuteReader();
            if (dri.Read())
            {
                comboBox1.Text = dri[0].ToString();
                textBox1.Text = dri[1].ToString();
                textBox2.Text = dri[2].ToString();
                textBox3.Text = dri[3].ToString();
            }
            else
            {

            }
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            this.menuTableAdapter.Fill(this.menuDataSet3.Menu);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-72UC5DDV\\SQLEXPRESS;Initial Catalog=Menu;Integrated Security=True");
            conn.Open();
            sqlstr = "SELECT * FROM Menu WHERE Nama = @Nama";
            SqlCommand cmd2 = new SqlCommand(sqlstr, conn);
            cmd2.Parameters.AddWithValue("@Nama", textBox2.Text);
            cmd2.ExecuteNonQuery();
            SqlDataReader dri = cmd2.ExecuteReader();
            if (dri.Read())
            {
                comboBox1.Text = dri[0].ToString();
                textBox1.Text = dri[1].ToString();
                textBox2.Text = dri[2].ToString();
                textBox3.Text = dri[3].ToString();
            }
            else
            {

            }
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells["Kode"].Value.ToString();
        }
        void TampilBarang()
        {

            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-72UC5DDV\\SQLEXPRESS;Initial Catalog=Menu;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select* from Menu", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Menu");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Menu";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }
    }
}
