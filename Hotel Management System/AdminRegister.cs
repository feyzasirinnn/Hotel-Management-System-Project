using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    public partial class AdminRegister : Form
    {
        public AdminRegister()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void AdminRegister_Load(object sender, EventArgs e)
        {
            
        }

        private void labelGotologin_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserloginForm frm = new UserloginForm();
            frm.Show(this);
           
        }

        private void labelGotologin_MouseEnter(object sender, EventArgs e)
        {
            labelGotologin.ForeColor = Color.Yellow;
        }

        private void labelGotologin_MouseLeave(object sender, EventArgs e)
        {
            labelGotologin.ForeColor = Color.White;
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = ("select image (*.jpg;*.npg;*.gif|*.jpg;*.npg;*.gif)");
            if (opf.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            Admin admin = new Admin();

            admin.First_name = textBoxfirstname.Text;
            admin.Last_name = textBoxlastname.Text;
            admin.Username = textBoxusername.Text;
            admin.Phone = int.Parse(textBoxphone.Text);
            admin.Email = textBoxemailaddress.Text;
            admin.Address = textBoxAddress.Text;
            admin.Password = textBoxPassword.Text;
            admin.CPassword = textBoxPasswordConfirm.Text;
      

            if (Verify())
            {
               
                pictureBox1.Image.Save(admin.Picture, pictureBox1.Image.RawFormat);
                if (textBoxPassword.Text.Equals(textBoxPasswordConfirm.Text))
                {
                    if (!admin.CheckAdmin())
                    {
                        if (admin.Insert())
                        {
                            MessageBox.Show("Your account has been created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This username already ixist please select the different one", "Diplicate username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Confirmation password", "password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Enter your information First", "Data Empty", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        public bool Verify()
        {
            if (textBoxfirstname.Text.Equals("")||textBoxlastname.Text.Equals("")||
                textBoxusername.Text.Equals("")||textBoxAddress.Text.Equals("")||
                textBoxphone.Text.Equals("")||textBoxPassword.Text.Equals("")||
                textBoxemailaddress.Text.Equals("")||pictureBox1.Image==null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void textBoxphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
