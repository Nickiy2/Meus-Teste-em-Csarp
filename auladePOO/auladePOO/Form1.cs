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

namespace auladePOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = tempdb; Integrated Security = True";

            string query = $"INSERT INTO [dbo].[Table] (Jogador, Posicao, Fortuna, Honra) VALUES(@Jogador, @Posicao, @Fortuna, @Honra)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Jogador", textBox1.Text);
                command.Parameters.AddWithValue("@Fortuna", textBox3.Text);
                command.Parameters.AddWithValue("@Posicao", textBox2.Text);
                command.Parameters.AddWithValue("@Honra", textBox4.Text);
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show($"Inserção de {textBox1.Text} realizada com sucesso!");
                else MessageBox.Show("Inserção falhou.");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = tempdb; Integrated Security = True";

            string query = "SELECT Jogador, Posicao, Fortuna, Honra FROM [dbo].[Table]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Jogador:{reader["Jogador"]}, Posição:{reader["Posicao"]}, Fortuna:{reader["Fortuna"]}, Honra:{reader["Honra"]}");
                        Console.ReadLine();
                    }
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
