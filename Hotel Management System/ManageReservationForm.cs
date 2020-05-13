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
    public partial class ManageReservationForm : Form
    {
        public ManageReservationForm()
        {
            InitializeComponent();
        }

        Reservation reser = new Reservation();
        Client client = new Client();
        Room room = new Room();
       
        private void ManageReservationForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            //populate the datadgridview with reservation datas
            dataGridViewReservation.DataSource = reser.GetAll();
           
        }

        private void buttonAddReservation_Click(object sender, EventArgs e)
        {
            try
            {
                reser.ID = int.Parse(textBoxClietId.Text.ToString());
                reser.TypeRoom = int.Parse(textBoxType.Text.ToString());
                reser.RoomId= int.Parse(textBoxRoomID.Text);
                reser.Date_In = (DateTime)dateTimePickerDateIn.Value;
                reser.Date_Out = (DateTime)dateTimePickerDateIn.Value;
                if (reser.Insert())
                {
                    MessageBox.Show("New Reservation added", "Reservation added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("New Reservation Not added", "Reservation added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch 
            {

                MessageBox.Show("Fill Fields with correct Values", "Incorrect format of Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefraish_Click(object sender, EventArgs e)
        {
            //populate the datadgridview with reservation datas
            dataGridViewReservation.DataSource = reser.GetAll();
        }

        private void dataGridViewReservation_Click(object sender, EventArgs e)
        {
            textBoxIDReservation.Text = dataGridViewReservation.CurrentRow.Cells[0].Value.ToString();
            textBoxClietId.Text = dataGridViewReservation.CurrentRow.Cells[1].Value.ToString();
            textBoxType.Text = dataGridViewReservation.CurrentRow.Cells[2].Value.ToString();
            textBoxRoomID.Text = dataGridViewReservation.CurrentRow.Cells[3].Value.ToString();
            dateTimePickerDateIn.Value=(DateTime)dataGridViewReservation.CurrentRow.Cells[4].Value;
            dateTimePickerDateOut.Value=(DateTime)dataGridViewReservation.CurrentRow.Cells[5].Value;
        }

        private void buttonEditRerservation_Click(object sender, EventArgs e)
        {
            try
            {
                reser.ID = int.Parse(textBoxIDReservation.Text);
                reser.ClientId = int.Parse(textBoxClietId.Text.ToString());
                reser.TypeRoom = int.Parse(textBoxType.Text.ToString());
                reser.RoomId= int.Parse(textBoxRoomID.Text);
                reser.Date_In = (DateTime)dateTimePickerDateIn.Value;
                reser.Date_Out = (DateTime)dateTimePickerDateIn.Value;
                if (reser.Update())
                {
                    MessageBox.Show("Reservation Updated", "update reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Reservation Not Updated", "update reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {

                MessageBox.Show("Fill Fields with correct Values", "Incorrect format of Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveReservation_Click(object sender, EventArgs e)
        {
            try
            {
                reser.ID= int.Parse(textBoxIDReservation.Text);
                if (MessageBox.Show("Are you sure you want to delete this reservation?","Delete reservation",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if (reser.Remove())
                    {
                        MessageBox.Show("Reservation deleted", "delete reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Reservation Not deleted", "delete reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Reservation Not deleted", "delete reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

                MessageBox.Show("Fill Fields with correct Values", "Incorrect format of Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearField_Click(object sender, EventArgs e)
        {
            textBoxIDReservation.Text ="";
            textBoxClietId.Text ="";
            textBoxType.Text ="";
            textBoxRoomID.Text ="";
            dateTimePickerDateIn.Value =DateTime.Now;
            dateTimePickerDateOut.Value = DateTime.Now;
        }

        private void textBoxIDReservation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&(!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBoxClietId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBoxType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBoxRoomID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
