using System.Collections.Generic;
using System.Data.SQLite;
using System.Reflection.Metadata;
using System.Security.Policy;

namespace Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Addproduct_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection(@"Data Source=.\storage.db");

            sqlite_conn.Open();


            string bob = "INSERT INTO Storage (Product,barcode) VALUES (@rengar,@draven)";

            Random yasuo = new Random();

            int yone = yasuo.Next(10000,99999);

            SQLiteCommand josef = new SQLiteCommand(bob,sqlite_conn);

            string textBox = textBox1.Text;

            josef.Parameters.AddWithValue("@draven", yone);

            josef.Parameters.AddWithValue("@rengar",textBox );

            

            josef.ExecuteNonQuery();

            sqlite_conn.Close();


        }

        private void Removeproduct_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection(@"Data Source=.\storage.db");
            sqlite_conn.Open();

            string bob = "DELETE FROM Storage WHERE Product = @brand;";
            SQLiteCommand josef = new SQLiteCommand(bob, sqlite_conn);

            string textBox = textBox1.Text;           

            josef.Parameters.AddWithValue("@brand", textBox);



            josef.ExecuteNonQuery();

            sqlite_conn.Close();

        }
    }
}