namespace MultiWindowForm
{
    public partial class MainForm : Form
    {
        private NewCustomerForm _customerForm;
        private List<Customer> _customerList;
        public MainForm()
        {
            InitializeComponent();
            _customerForm = new NewCustomerForm(this);
            _customerList = new List<Customer>();
            reloadDataGrid();
        }

        private void reloadDataGrid()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = _customerList;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _customerForm.ShowDialog();
        }

        public void AddCustomer(Customer customer)
        {
            _customerList.Add(customer);
            reloadDataGrid();
        }

        public void EditCustomer(int id, Customer updatedCustomer)
        {
            MessageBox.Show("Main form is editing the customer now.");

            //find customer out of list by id
            var cust = _customerList.Find(c => c.CustomerId == id);

            if (cust != null)
            {
                //process the discovered customer
                cust.Name = updatedCustomer.Name;
                cust.PhoneNumber = updatedCustomer.PhoneNumber;
                cust.Email = updatedCustomer.Email;

                reloadDataGrid();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {

            //get the row out of datagrid view.
            Customer cust;

            //get the position of the item from the data grid view.
            var index = dgvCustomers.SelectedRows[0].Index;

            //Get the exact customer out of the array.
            cust = _customerList[index];

            //load the customer into the form
            _customerForm.LoadCustomer(cust);

            _customerForm.ToggleEdit(true);

            //show the form
            _customerForm.Show();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditCustomer.Visible = true;
        }
    }
}
