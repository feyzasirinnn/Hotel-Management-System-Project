using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Hotel_Management_System
{
    public partial class ManageClientsForm : Form
    {
        public ManageClientsForm()
        {
            InitializeComponent();
        }
        Client client = new Client();
        private void ManageClientsForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            //populate the datagridview
          //  MySqlCommand command = new MySqlCommand("select *from Clients");
            dataGridView1Client.DataSource = client.GetClient();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckFields())
                {
                    client.First_name = textBoxFirstname.Text;
                    client.Last_name = textBoxLastname.Text;
                    client.Phone = int.Parse(textBoxphonenumber.Text);
                    client.Email = textBoxEmail.Text;
                    if (client.Insert())
                    {
                        MessageBox.Show("New Client Added", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("New Client Not Added", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter the Informations first", "Empty Fields", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch 
            {

                MessageBox.Show("Please Enter a valid client id", "Remove Client", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
          
        }

        private void buttonRefraish_Click(object sender, EventArgs e)
        {
            //populate the datagridview
           // MySqlCommand command = new MySqlCommand("select *from Clients");
            dataGridView1Client.DataSource = client.GetClient();
        }


        

        private void dataGridView1Client_Click(object sender, EventArgs e)
        {
            textBoxID.Text =dataGridView1Client.CurrentRow.Cells[0].Value.ToString();
            textBoxFirstname.Text= dataGridView1Client.CurrentRow.Cells[1].Value.ToString();
            textBoxLastname.Text= dataGridView1Client.CurrentRow.Cells[2].Value.ToString();
            textBoxphonenumber.Text= dataGridView1Client.CurrentRow.Cells[3].Value.ToString();
            textBoxEmail.Text= dataGridView1Client.CurrentRow.Cells[4].Value.ToString();
        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckFields())
                {
                    client.ID = int.Parse(textBoxID.Text);
                    client.First_name = textBoxFirstname.Text;
                    client.Last_name = textBoxLastname.Text;
                    client.Phone = int.Parse(textBoxphonenumber.Text);
                    client.Email = textBoxEmail.Text;
                    if (client.Update())
                    {
                        MessageBox.Show("Client Updated", "Edit Client ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Client ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter the Informations first", "Empty Fields", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch 
            {

                MessageBox.Show("Please Enter a valid client id", "Edit Client", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }




        //chech if the fields containt datas
        public bool CheckFields()
        {
            if (textBoxFirstname.Text.Equals("") || textBoxLastname.Text.Equals("") ||
                textBoxphonenumber.Text.Equals("") || textBoxEmail.Text.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                client.ID = int.Parse(textBoxID.Text);
                if (MessageBox.Show("Are you Sure You want to Delete this Client?", "Delete Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (client.Delete())
                    {
                        MessageBox.Show("Client Deleted", "Remove Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Client not Deleted", "Remove Client", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
            catch 
            {

                MessageBox.Show("Please Enter a valid client id", "Remove Client", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void buttonClearField_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxFirstname.Text = "";
            textBoxLastname.Text = "";
            textBoxphonenumber.Text = "";
            textBoxEmail.Text = "";
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxphonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
