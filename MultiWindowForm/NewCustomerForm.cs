using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiWindowForm
{
    public partial class NewCustomerForm : Form
    {
        private MainForm _mainForm;
        public NewCustomerForm(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // create a customer.
            // load it with data from the form.
            Customer customer = new Customer
            {
                CustomerId = 0,
                Name = txtName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Email = txtEmail.Text,
            };

            // send data to AddCustomer on parent form.
            _mainForm.AddCustomer(customer);

            //clear customer form
            //close NewCustomerForm
        }
    }
}
