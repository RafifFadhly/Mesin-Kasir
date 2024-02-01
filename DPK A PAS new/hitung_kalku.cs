using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPK_A_PAS_new
{
    //kalkulator
    public class kalku
    {
        public decimal bill1, bill2, hasil;
        public decimal Bill1(decimal bil1, string tex)
        {
            if (tex == "%")
            {
                bill1 = bil1 / 100;
            }
            else
            {
                bill1 = bil1;
            }
            return bill1;
        }
        public decimal Bill2(decimal bil2, string tex)
        {
            if (tex == "%")
            {
                bill2 = bil2 / 100;
            }
            else
            {
                bill2 = bil2;
            }
            return bill2;
        }
        public decimal hitung(string text, decimal x,decimal y)
        {
            penjumlahan plus = new penjumlahan();
            pengurangan min = new pengurangan();
            pembagian bagi = new pembagian();
            perkalian kali = new perkalian(); 
            switch (text)
            {
                case "+":
                    {
                        hasil = plus.main(x, y);
                        break;
                    }
                case "-":
                    {
                        hasil = min.main(x, y);
                        break;
                    }
                case ":":
                    {
                        hasil = bagi.main(x, y);
                        break;
                    }
                case "x":
                    {
                        hasil = kali.main(x, y);
                        break;
                    }
            }
            return hasil;
        }
        public virtual decimal main(decimal bill1, decimal bill2)
        {
            return hasil;
        }
    }
    public class penjumlahan : kalku
    {
        public override decimal main(decimal bill1, decimal bill2)
        {
            return hasil = bill1 + bill2;
        }
    }
    public class pengurangan : kalku
    {
        public override decimal main(decimal bill1, decimal bill2)
        {
            return hasil = bill1 - bill2;
        }
    }
    public class pembagian : kalku
    {
        public override decimal main(decimal bill1, decimal bill2)
        {
            return hasil = bill1 / bill2;
        }
    }
    public class perkalian : kalku
    {
        public override decimal main(decimal bill1, decimal bill2)
        {
            return hasil = bill1 * bill2;
        }
    }

    public class data
    {
        public void Batas()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-72UC5DDV\SQLEXPRESS;Initial Catalog=penghasilan;Integrated Security=True");
            DateTime waktu = DateTime.Now;
            Conn.Open();
            string sqlstr = "DELETE FROM penghasilan WHERE [Waktu] != '" + waktu.ToShortDateString() + "'";
            SqlCommand cmd1 = new SqlCommand(sqlstr, Conn);
            cmd1.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
