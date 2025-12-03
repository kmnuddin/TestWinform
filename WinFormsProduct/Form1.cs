using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using WinFormsProduct.DB;
using WinFormsProduct.Data;

namespace WinFormsProduct
{
    public partial class Form1 : Form
    {
        private SalesContext _db;
        public Form1()
        {
            InitializeComponent();
            _db = new SalesContext();
            _db.Database.Initialize(false);
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Name = txtCustomerName.Text,
                Email = txtCustomerEmail.Text
            };
            _db.Customers.Add(customer);
            _db.SaveChanges();
        }
    }
}
