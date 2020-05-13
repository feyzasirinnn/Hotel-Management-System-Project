using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Management_System
{
    class Client:Person //İnheritance
    {
        MyDB db = new MyDB();

       
        //Methods
        //Create a function to add a new client
        public override bool Insert()//polymorphisme
        {
            MySqlCommand command = new MySqlCommand("insert into clients(first_name,last_name,phone,email) values (@fn,@ln,@ph,@em)", db.getConnection());
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = this.First_name;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = this.Last_name;
            command.Parameters.Add("@ph", MySqlDbType.Int32).Value = this.Phone;
            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = this.Email;
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

        //create a function to populate the datagridview with clients Data
        public DataTable GetClient()
        {
            MySqlCommand command = new MySqlCommand("select *from Clients");
            command.Connection = db.getConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);


            return table;
        }

        //update the clients informations

        public bool Update()
        {
            MySqlCommand command = new MySqlCommand("update clients set first_name=@fn,last_name=@ln,phone=@ph,email=@em where id=@id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = this.ID;
            command.Parameters.Add("@ph", MySqlDbType.Int32).Value = this.Phone;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = this.First_name;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = this.Last_name;
            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = this.Email;
            db.OpenConnection();
            if (command.ExecuteNonQuery()==1)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        //Create a Function to Remove Client From the database
        public bool Delete() 
        {
            MySqlCommand command = new MySqlCommand("delete from clients where id=@id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = this.ID;
            db.OpenConnection();
            if (command.ExecuteNonQuery()==1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
