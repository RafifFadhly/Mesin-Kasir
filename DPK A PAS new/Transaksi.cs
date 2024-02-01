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
    public partial class Transaksi : Form
    {
        SqlConnection Conn = new SqlConnection("Data Source=LAPTOP-72UC5DDV\\SQLEXPRESS;Initial Catalog=Pesanan;Integrated Security=True");
           
        public decimal dsk, jml, hrg, total;
        string sqlstr;
        public Transaksi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conn.Close();

            if (MessageBox.Show("Anda yakin ?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                hitung();
                reset();
            }

            this.pesananTableAdapter.Fill(this.pesananDataSet3.Pesanan);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Conn.Close();
            sqlstr = "TRUNCATE TABLE Pesanan";
            Conn.Open();
            SqlCommand cmd1 = new SqlCommand(sqlstr, Conn);
            cmd1.ExecuteNonQuery();
            Conn.Close();
            this.pesananTableAdapter.Fill(this.pesananDataSet3.Pesanan);
            this.menuTableAdapter.Fill(this.menuDataSet3.Menu);
            reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conn.Close();
            Conn.Open();
            sqlstr = "DELETE FROM Pesanan WHERE Kode = @kode AND Jml = @Jml";
            SqlCommand cmd1 = new SqlCommand(sqlstr, Conn);
            cmd1.Parameters.AddWithValue("@kode", textBox1.Text);
            cmd1.Parameters.AddWithValue("@Jml", textBox4.Text);
            cmd1.ExecuteNonQuery();
            Conn.Close();
            this.pesananTableAdapter.Fill(this.pesananDataSet3.Pesanan);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-72UC5DDV\\SQLEXPRESS;Initial Catalog=Menu;Integrated Security=True");
            conn.Open();
            sqlstr = "SELECT * FROM Menu WHERE Kode = @kode";
            SqlCommand cmd2 = new SqlCommand(sqlstr, conn);
            cmd2.Parameters.AddWithValue("@kode", textBox1.Text);
            cmd2.ExecuteNonQuery();
            SqlDataReader dri = cmd2.ExecuteReader();
            if (dri.Read())
            {
                comboBox1.Text = dri[0].ToString();
                textBox1.Text = dri[1].ToString();
                textBox2.Text = dri[2].ToString();
                textBox3.Text = dri[3].ToString();
                textBox4.Text = "0";
                textBox5.Text = "0";
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

        private void Transaksi_Load(object sender, EventArgs e)
        {
            TampilBarang();
            // TODO: This line of code loads data into the 'menuDataSet3.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.menuDataSet3.Menu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conn.Close();

            if(textBox3.Text == "0" || textBox3.Text == "" || textBox4.Text == "0" || textBox4.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("isi dulu semuanya !");
            }
            else
            {
                tambah();
            }

            this.pesananTableAdapter.Fill(this.pesananDataSet3.Pesanan);
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
                textBox4.Text = "0";
                textBox5.Text = "0";
            }
            else
            {

            }
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
            this.Hide();
            Conn.Close();
            sqlstr = "TRUNCATE TABLE Pesanan";
            Conn.Open();
            SqlCommand cmd1 = new SqlCommand(sqlstr, Conn);
            cmd1.ExecuteNonQuery();
            Conn.Close();
        }

        private void kalkulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kalkulator diskon = new Kalkulator();
            diskon.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void reset() //buat reset semua textbox dan combo box
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
        }

        public void hitung() //hitung total pesanan dan total harga pesanan
        {
            output bar = new output();
            bar.textBox3.Text = label10.Text;
            Conn.Open();
            sqlstr = "SELECT COALESCE(SUM(Harga),0) as TotalHarga FROM Pesanan";
            SqlCommand cmd = new SqlCommand(sqlstr, Conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int totalHarga = Convert.ToInt32(reader["TotalHarga"]);
                reader.Close();
                sqlstr = "SELECT COALESCE(SUM(Jml),0) as TotalJml FROM Pesanan";
                SqlCommand cmd1 = new SqlCommand(sqlstr, Conn);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    int totalJml = Convert.ToInt32(reader1["TotalJml"]);
                    reader1.Close();
                    if (totalJml != 0 && totalHarga != 0)
                    {
                        DateTime waktu = DateTime.Now;
                        bar.Show();
                        bar.textBox1.Text = totalHarga.ToString();
                        bar.label6.Text = totalHarga.ToString();                        //total harga
                        bar.textBox2.Text = totalJml.ToString();                        //total pesanan
                        bar.dataGridView2.DataSource = pesananTableAdapter.GetData();   //refresh tabel output
                        bar.textBox4.Text = waktu.ToShortDateString();                  //waktu
                        Conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("isi pesanan dulu");
                    }
                }
            }
        }
        public void tambah() //nambah pesanan
        {
            jml = Convert.ToDecimal(textBox4.Text);
            hrg = Convert.ToDecimal(textBox3.Text);
            dsk = Convert.ToDecimal(textBox5.Text);
            total = (hrg - (hrg * (dsk / 100))) * jml; 

            Conn.Open();
            double totald = Convert.ToDouble(total);
            sqlstr = "INSERT INTO Pesanan ([Kode], [Menu], [Jml], [Harga], [Diskon]) VALUES (@kode, @nama, @Jml, @harga, @Diskon)";
            SqlCommand cmd1 = new SqlCommand(sqlstr, Conn);
            cmd1.Parameters.AddWithValue("@kode", textBox1.Text);
            cmd1.Parameters.AddWithValue("@nama", textBox2.Text);
            cmd1.Parameters.AddWithValue("@Jml", jml);
            cmd1.Parameters.AddWithValue("@harga", totald);
            cmd1.Parameters.AddWithValue("@Diskon", dsk + "%");
            cmd1.ExecuteNonQuery();
            Conn.Close();
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
