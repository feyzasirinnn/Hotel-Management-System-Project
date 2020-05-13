using MySql.Data.MySqlClient;
using System.IO;
using System.Data;

namespace Hotel_Management_System
{
    class Admin:Person //inheritance
    {
        //Fields
        private string _username;
        private string _address;
        private string _password;
        private string _cpassword;
        private MemoryStream _picture;

        //Proprieties
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string CPassword
        {
            get { return _cpassword; }
            set { _cpassword = value; }
        }
        public MemoryStream Picture
        {
            get { return _picture; }
            set { _picture = value; }
        }

        MyDB db = new MyDB();
        //Create a function to add a new admin
        public override bool Insert()
        {
           
            MySqlCommand command = new MySqlCommand("insert into admin(first_name,last_name,username,phone,address,address_mail,password,picture)values(@fn,@ln,@adm,@ph,@add,@em,@pass,@pic)",db.getConnection());
            //@fn,@ln,@adm,@ph,@add,@em,@pass,@pic
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = this.First_name;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = this.Last_name;
            command.Parameters.Add("@adm", MySqlDbType.VarChar).Value = this.Username;
            command.Parameters.Add("@ph", MySqlDbType.Int32).Value = this.Phone;
            command.Parameters.Add("@add", MySqlDbType.Text).Value = this.Address;
            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = this.Email;
            command.Parameters.Add("@pic", MySqlDbType.LongBlob).Value = this.Picture.ToArray();
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = this.Password;
            db.OpenConnection();
            if (command.ExecuteNonQuery()==1)
            {
                db.CloseConnection();
                return true;
            }
            else
            {
                db.CloseConnection();
                return false;
            }
        }

        //Check the if the user name already exist in the database
        public bool CheckAdmin()
        {
            MySqlCommand command = new MySqlCommand("select *from admin where username=@adm", db.getConnection());
            command.Parameters.Add("@adm", MySqlDbType.VarChar).Value = this.Username;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table =new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count>0)
            {
                db.CloseConnection();
                return true;
            }
            else
            {
                db.CloseConnection();
                return false;
            }
            
        }
    }
}
