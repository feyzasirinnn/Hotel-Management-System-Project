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
    public partial class ManageRoomForm : Form
    {
        public ManageRoomForm()
        {
            InitializeComponent();
        }
        Room room = new Room();

        private void ManageRoomForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            //populate the datagridview with room datas
           // MySqlCommand command = new MySqlCommand("select *from room");
            dataGridViewRoom.DataSource = room.GetAll();

        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            try
            {
                room.Type= int.Parse(comboBoxtype.SelectedItem.ToString());
                room.Phone = int.Parse(textBoxPhone.Text);
                room.Reserved = "No";
                if (radioButtonYes.Checked == true)
                {
                    room.Reserved= "Yes";
                }
                else if (radioButtonNo.Checked == true)
                {
                    room.Reserved = "No";
                }
                if (!CheckField())
                {
                    if (room.Insert())
                    {
                        MessageBox.Show("New Room Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("New Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Fill the Fields before Add", "Add Room", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Enter the correct value of fields", "Add Room", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    
            //create a function to check if the fields contain data
            public bool CheckField()
            {
                if (comboBoxtype.SelectedItem==null||textBoxPhone.Text.Trim().Equals(""))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        private void buttonEditRoom_Click(object sender, EventArgs e)
        {
            try
            {
                room.ID = int.Parse(textBoxID.Text);
                room.Type = int.Parse(comboBoxtype.SelectedItem.ToString());
                room.Phone = int.Parse(textBoxPhone.Text);
                room.Reserved = "No";
                if (radioButtonYes.Checked == true)
                {
                    room.Reserved = "Yes";
                }
                else if (radioButtonNo.Checked == true)
                {
                    room.Reserved= "No";
                }
                if (!CheckField())
                {
                    if (room.Update())
                    {
                        MessageBox.Show("Room info Updated", "Room update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Room info Not Updated", "Room update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Fill the field before", "Room update", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Enter the correct value of fields", "update Room", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)||!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridViewRoom_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewRoom.CurrentRow.Cells[0].Value.ToString();
            comboBoxtype.SelectedItem = dataGridViewRoom.CurrentRow.Cells[1].Value.ToString();
            textBoxPhone.Text = dataGridViewRoom.CurrentRow.Cells[2].Value.ToString();
            if (dataGridViewRoom.CurrentRow.Cells[3].Value.ToString()=="Yes")
            {
                radioButtonYes.Checked = true;
            }
            else if (dataGridViewRoom.CurrentRow.Cells[3].Value.ToString() == "No")
            {
                radioButtonNo.Checked = true;
            }

        }

        private void buttonRefraish_Click(object sender, EventArgs e)
        {
            //populate the datagridview with room datas
           // MySqlCommand command = new MySqlCommand("select *from room");
            dataGridViewRoom.DataSource = room.GetAll();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                room.ID = int.Parse(textBoxID.Text);
                if (MessageBox.Show("Are you Sure you Want to delete this Room?", "Remove Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (room.Remove())
                    {
                        MessageBox.Show("Room Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Room Not Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Room not Deleted", "Remove room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

                MessageBox.Show("Enter the correct value of fields", "Delete Room", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ShowTypeForm frm = new ShowTypeForm();
            frm.Show(this);
        }
    }
}
