﻿using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Entities.Services;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        CustomerOperations customerOperations=new CustomerOperations();
        private void btnCustomerCreate_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerName = txtCustomerName.Text,
                CustomerSurname = txtCustomerSurname.Text,
                CustomerBalance = decimal.Parse(txtCustomerBalance.Text),
                CustomerCity = txtCustomerCity.Text,
                CustomerShoppingCount = int.Parse(txtCustomerShoppingCount.Text),
            };
            customerOperations.AddCustomer(customer);
            MessageBox.Show("Müşteri ekleme işlemi başarılı","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Customer> customers = customerOperations.GetAllCustomer();
            dataGridView1.DataSource = customers;

        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            string customerId = txtCustomerId.Text;
            customerOperations.DeleteCustomer(customerId);
            MessageBox.Show("Müşteri başarıyla silindi");
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            string id= txtCustomerId.Text;
            var updatedCustomer = new Customer()
            {
                CustomerId =id,
                CustomerName = txtCustomerName.Text,
                CustomerBalance = decimal.Parse(txtCustomerBalance.Text),
                CustomerCity = txtCustomerCity.Text,
                CustomerSurname = txtCustomerSurname.Text,
                CustomerShoppingCount = int.Parse(txtCustomerShoppingCount.Text)
            };
            customerOperations.UpdateCustomer(updatedCustomer);
            MessageBox.Show("Müşteri başarıyla güncellendi");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGetByCustomerId_Click(object sender, EventArgs e)
        {
            string id=txtCustomerId.Text;
            Customer customers= customerOperations.GetCustomerById(id);
            dataGridView1.DataSource=new List<Customer> {customers};
        }
    }
}
