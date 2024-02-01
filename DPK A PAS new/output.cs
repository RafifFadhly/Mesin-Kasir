using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPK_A_PAS_new
{
    public partial class output : Form
    {
        SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-72UC5DDV\SQLEXPRESS;Initial Catalog=penghasilan;Integrated Security=True");
        string sqlstr;
        public output()
        {
            InitializeComponent();
        }

        private void output_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pesananDataSet4.Pesanan' table. You can move, or remove it, as needed.
            this.pesananTableAdapter.Fill(this.pesananDataSet4.Pesanan);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Masukan Metode Pembayaran !");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Masukan Uang Pembayaran !");
            }
            else if (comboBox1.Text == "" && textBox5.Text == "")
            {

            }
            else
            {
                this.Hide();
                sqlstr = "INSERT INTO penghasilan ([User] ,[Metode Pembayaran], [Total Pesanan],[Total Harga],[Harga], [Waktu]) VALUES (@user, @Metode, @Pesanan, @Harga, @harga1, @time)";
                Conn.Open();
                SqlCommand cmd = new SqlCommand(sqlstr, Conn);
                cmd.Parameters.AddWithValue("@user", textBox3.Text);
                cmd.Parameters.AddWithValue("@Harga", textBox1.Text);
                cmd.Parameters.AddWithValue("@Pesanan", textBox2.Text);
                cmd.Parameters.AddWithValue("@Metode", comboBox1.Text);
                cmd.Parameters.AddWithValue("@time", textBox4.Text);
                cmd.Parameters.AddWithValue("@harga1", label6.Text);
                cmd.ExecuteNonQuery();
                PrintDocument();
                Conn.Close();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrintDocument()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font fontHeader = new Font("Arial", 10, FontStyle.Bold);
            Font fontContent = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            float fontHeight = fontHeader.GetHeight();

            int startX = 10; //posisi vertikal
            int startY = 10; //posisi horizontal
            int offset = 40; //posisi pergeseran (y)

            // Logo Toko
            Image logoImage = Image.FromFile("logo.png");
            int logoWidth = 100;
            int logoHeight = 100; 
            int logoX = startX + (e.PageBounds.Width - logoWidth) / 2;
            graphics.DrawImage(logoImage, logoX, startY, logoWidth, logoHeight);
            startY += logoHeight + offset;

            // Nama Toko
            string cafeName = "Cafe Watu";
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            graphics.DrawString(cafeName, fontHeader, brush, new RectangleF(startX, startY, e.PageBounds.Width, fontHeight), format);
            startY += (int)fontHeight + offset;

            // Info Kasir
            string kasir = "Kasir: " + textBox3.Text;
            string waktu = "Waktu: " + textBox4.Text;
            graphics.DrawString(kasir, fontContent, brush, startX, startY);
            startY += (int)fontHeight;
            graphics.DrawString(waktu, fontContent, brush, startX, startY);
            startY += offset;

            // Header Tabel Pesanan
            string header = "Pesanan";
            graphics.DrawString(header, fontHeader, brush, startX, startY);
            startY += (int)fontHeight;

            // Tabel Pesanan
            int rowHeight = 20;
            int tableX = startX;
            int tableY = startY;
            int cellWidth = 120;

            // Tampilan Kolom
            graphics.DrawString("Menu", fontHeader, brush, tableX, tableY);
            graphics.DrawString("Jml", fontHeader, brush, tableX + cellWidth, tableY);
            graphics.DrawString("Harga", fontHeader, brush, tableX + cellWidth * 2 - 90, tableY);
            graphics.DrawString("Diskon", fontHeader, brush, tableX + cellWidth * 2 + 10, tableY);
            tableY += (int)fontHeight;

            // Tampilan tabel Pesanan
            List<string[]> pesananList = GetPesananFromDatabase("Data Source=LAPTOP-72UC5DDV\\SQLEXPRESS;Initial Catalog=Pesanan;Integrated Security=True");

            foreach (string[] pesanan in pesananList)
            {
                string namaPesanan = pesanan[0];
                string jml = pesanan[1];
                string harga = "Rp." + pesanan[2] + ",00";
                string Diskon = pesanan[3];

                // tampilan tabel
                graphics.DrawString(namaPesanan, fontContent, brush, tableX, tableY);
                graphics.DrawString(jml, fontContent, brush, tableX + cellWidth, tableY);
                graphics.DrawString(harga, fontContent, brush, tableX + cellWidth * 2 - 90, tableY);
                graphics.DrawString(Diskon, fontContent, brush, tableX + cellWidth * 2 + 10, tableY);
                tableY += rowHeight;
            }

            // posisi total
            int totalSectionY = Math.Max(tableY, startY) + offset;

            // Total Harga
            string totalHarga       = "Total Harga   : Rp." + textBox1.Text  + ",00";
            graphics.DrawString(totalHarga, fontContent, brush, startX, totalSectionY);

            // Metode Pembayaran
            string metodePembayaran = "Metode bayar  : " + comboBox1.Text;
            graphics.DrawString(metodePembayaran, fontContent, brush, startX, totalSectionY + (int)fontHeight);

            // Total Pesanan
            string totalPesanan     = "Total Pesanan : " + textBox2.Text;
            graphics.DrawString(totalPesanan, fontContent, brush, startX, totalSectionY + (int)fontHeight * 2);
            //bayar
            string bayar = "Uang bayar  : Rp." + textBox5.Text + ",00";
            graphics.DrawString(bayar, fontContent, brush, startX, totalSectionY + (int)fontHeight * 4);

            //kembalian
            int a1, a2, d1;
            a1 = Convert.ToInt32(textBox1.Text);
            a2 = Convert.ToInt32(textBox5.Text);
            d1 = a2 - a1;
            string kembalian = "kembalian  : Rp." + d1 + ",00";
            graphics.DrawString(kembalian, fontContent, brush, startX, totalSectionY + (int)fontHeight * 5);

            // ukuran kertas cetak
            e.PageSettings.PaperSize = new PaperSize("Custom", 80, 397);

            e.HasMorePages = false;
        }


        //database pesanan
        private List<string[]> GetPesananFromDatabase(string connectionString)
        {
            List<string[]> pesananList = new List<string[]>();

            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-72UC5DDV\\SQLEXPRESS;Initial Catalog=Pesanan;Integrated Security=True"))
            {
                conn.Open();

                sqlstr= "SELECT Menu, Jml, Harga, Diskon FROM Pesanan";
                SqlCommand cmd = new SqlCommand(sqlstr, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Menu = reader["Menu"].ToString();
                        string Jml = reader["Jml"].ToString();
                        string Harga = reader["Harga"].ToString();
                        string Diskon = reader["Diskon"].ToString();

                        string[] pesanan = new string[] { Menu, Jml, Harga, Diskon };
                        pesananList.Add(pesanan);
                    }
                }
            }

            return pesananList;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
