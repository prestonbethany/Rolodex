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
        private int CustomerCount;
        private bool IsEditing;
        private int CurrentSelectionId;
        public NewCustomerForm(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
            CustomerCount = 1;
            IsEditing = false;
            CurrentSelectionId = -1;
        }

        public void ToggleEdit(bool newState)
        {
            IsEditing = newState;
            
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
        }

        public void LoadCustomer(Customer customer)
        {
            CurrentSelectionId = customer.CustomerId;
            txtName.Text = customer.Name;
            txtEmail.Text = customer.Email;
            txtPhoneNumber.Text = customer.PhoneNumber;
        }

        private void CreateCustomer()
        {
            if (IsValidCustomer())
            {
                // create a customer.
                // load it with data from the form.
                Customer customer = new Customer
                {
                    CustomerId = CustomerCount,
                    Name = txtName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Email = txtEmail.Text,
                };

                // send data to AddCustomer on parent form.
                _mainForm.AddCustomer(customer);
                CustomerCount++;
            }
        }

        private bool IsValidCustomer()
        {
            if (txtName.Text == "" || txtEmail.Text == "" || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("You need to include a name, email, and phone number");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void EditCustomer()
        {
            MessageBox.Show("Form is being edited");
            if (IsValidCustomer())
            { 
                _mainForm.EditCustomer(CurrentSelectionId, new Customer
                {
                    CustomerId = CurrentSelectionId,
                    Name = txtName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Email = txtEmail.Text,
                });
                CurrentSelectionId = -1;
                ToggleEdit(false);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                EditCustomer();
            }
            else
            {
                //create a new customer
                CreateCustomer();
            }


            //clear customer form
            ClearForm();

            //close NewCustomerForm
            Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
