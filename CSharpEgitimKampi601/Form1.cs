using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Services;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerOperations customerOperations = new CustomerOperations();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerName = txtMusteriAd.Text,
                CustomerSurname = txtMusteriSoyad.Text,
                CustomerCity = txtMusteriSehir.Text,
                CustomerBalance = Convert.ToDecimal(txtMusteriBakiye.Text),
                CustomerShoppingCount = Convert.ToInt32(txtMusteriTutar.Text)
            };

            customerOperations.AddCustomer(customer);
            MessageBox.Show("Müşteri eklendi.","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            List<Customer> customers = customerOperations.GetAllCustomer();
            DataGridView1.DataSource = customers;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            string customerId = txtMusteriId.Text;
            customerOperations.DeleteCustomer(customerId);
            MessageBox.Show("Müşteri silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string id = txtMusteriId.Text;
            var updateCustomer = new Customer()
            {
                CustomerId = id,
                CustomerName = txtMusteriAd.Text,
                CustomerSurname = txtMusteriSoyad.Text,
                CustomerCity = txtMusteriSehir.Text,
                CustomerBalance = Convert.ToDecimal(txtMusteriBakiye.Text),
                CustomerShoppingCount = Convert.ToInt32(txtMusteriTutar.Text)
            };
            customerOperations.UpdateCustomer(updateCustomer);
            MessageBox.Show("Müşteri güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnGetById_Click(object sender, EventArgs e)
        {
            string id = txtMusteriId.Text;
            var customer = customerOperations.GetCustomerById(id);
            DataGridView1.DataSource = new List<Customer> { customer };
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
