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
    public partial class ShowTypeForm : Form
    {
        public ShowTypeForm()
        {
            InitializeComponent();
        }
        Room room = new Room();
        private void ShowTypeForm_Load(object sender, EventArgs e)
        {
          
            dataGridView1.DataSource = room.getType();

        }
    }
}
