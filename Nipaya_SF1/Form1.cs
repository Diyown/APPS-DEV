using System.Text.RegularExpressions;
namespace Nipaya_SF1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string name;
        string email1;
        int ticket = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            isValid_email(txtEmail.Text);

            if (name != null && email1 != null && ticket != 0)
            {
                MessageBox.Show("ORDER NOTED");

                name = "";
                email1 = "";
                ticket = 0;

                txtEmail.Text = "";
                txtName.Text = "";
                txtTickets.Text = "";
            }
            else
            {
                MessageBox.Show("INVALID INPUT");
            }
        }

        public bool isValid_email(string email)
        {
            Regex check = new Regex(@"^\w+[\w-\-]+\@\w{5,7}\.[a-z]{2,3}$");
            bool valid = false;
            valid = check.IsMatch(email);

            if (valid == true)
            {
                email1 = email;
                return true;
            }
            else
            {
                MessageBox.Show("E-Mail Format is Incorrect");
                return false;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            name = txtName.Text;
        }

        private void txtTickets_TextChanged(object sender, EventArgs e)
        {
            string getTickets = txtTickets.Text;

            if(Int32.TryParse(getTickets, out int num))
            {
                if(num > 0)
                {
                    ticket = num;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addEvent.Items.Add("Dione Concert");
            addEvent.Items.Add("James Concert");
            addEvent.Items.Add("Kyle Concert");
            addEvent.Items.Add("Brandon Concert");
            addEvent.Items.Add("Jude Concert");
        }
    }
}
 