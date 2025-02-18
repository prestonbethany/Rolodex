namespace MultiWindowForm
{
    public partial class Form1 : Form
    {
        private NewCustomerForm _customerForm;
        private List<Customer> _customerList;
        public Form1()
        {
            InitializeComponent();
            _customerForm = new NewCustomerForm();
            _customerList = new List<Customer>();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _customerForm.ShowDialog();
        }

        public void AddCustomer(Customer customer)
        {
            _customerList.Add(customer);
        }
    }
}
