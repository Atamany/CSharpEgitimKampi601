using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres;Password=1234";
        void GetAllCustomer()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Customer";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DataGridView1.DataSource = dataTable;
            connection.Close();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            GetAllCustomer();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerCity = txtCustomerCity.Text;
            string customerSurname = txtCustomerSurname.Text;
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO Customer (CustomerName,CustomerCity,CustomerSurname) VALUES (@p1,@p2,@p3)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", customerName);
            command.Parameters.AddWithValue("@p2", customerCity);
            command.Parameters.AddWithValue("@p3", customerSurname);
            command.ExecuteNonQuery();
            MessageBox.Show("Müşteri Eklendi!");
            connection.Close();
            GetAllCustomer();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(txtCustomerId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "DELETE FROM Customer WHERE CustomerId=@p1";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", customerId);
            command.ExecuteNonQuery();
            MessageBox.Show("Müşteri Silindi!");
            connection.Close();
            GetAllCustomer();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerCity = txtCustomerCity.Text;
            string customerSurname = txtCustomerSurname.Text;
            int customerId = Convert.ToInt32(txtCustomerId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "UPDATE Customer SET CustomerName=@p1,CustomerCity=@p2,CustomerSurname=@p3 WHERE CustomerId=@p4";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", customerName);
            command.Parameters.AddWithValue("@p2", customerCity);
            command.Parameters.AddWithValue("@p3", customerSurname);
            command.Parameters.AddWithValue("@p4", customerId);
            command.ExecuteNonQuery();
            MessageBox.Show("Müşteri Güncellendi!");
            connection.Close();
            GetAllCustomer();

        }
    }
}
