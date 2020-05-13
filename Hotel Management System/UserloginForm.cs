using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    public partial class UserloginForm : Form
    {
        public UserloginForm()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void UserloginForm_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            label1.BackColor = Color.FromArgb(100, 0, 0, 0);
            labelusername.BackColor = Color.FromArgb(100, 0, 0, 0);
            labelpassword.BackColor = Color.FromArgb(100, 0, 0, 0);
            labelGotoCreate.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void labelGotoCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminRegister frm = new AdminRegister();
            frm.Show(this);
        }

        private void labelGotoCreate_MouseEnter(object sender, EventArgs e)
        {
            labelGotoCreate.ForeColor = Color.Yellow;
        }

        private void labelGotoCreate_MouseLeave(object sender, EventArgs e)
        {
            labelGotoCreate.ForeColor = Color.White;
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (username.Trim().Equals(""))
            {
                MessageBox.Show("Enter your username to login", "Empty Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (password.Trim().Equals(""))
            {
                MessageBox.Show("Enter your password to login", "Data Empty", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {

                MyDB db = new MyDB();
                MySqlCommand command = new MySqlCommand("select *from admin where username=@us and password=@pass", db.getConnection());
                command.Parameters.Add("@us", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    MainForm frm = new MainForm();
                    frm.Show(this);
                }
                else
                {
                    MessageBox.Show("Wrong Username or password", "Wrong login Information ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPassword.Text = "";
                    textBoxUsername.Text = "";
                }
            }

        }
    }
}
