using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Management_System
{
    class Room:BaseClass
    {
        private int id;
        private int type;
        private int phone;
        private string reserved;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Reserved
        {
            get { return reserved; }
            set { reserved = value; }
        }
        MyDB db = new MyDB();
        //create a function to get room datas
        public override DataTable GetAll()
        {
            MySqlCommand command = new MySqlCommand("select *from room");
            command.Connection = db.getConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);


            return table;
        }

        //create a function to get room type
        public DataTable getType()
        {
            MySqlCommand command = new MySqlCommand("select *from type", db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);


            return table;
        }
        //create a function to add a new room
        public override bool Insert()
        {
            MySqlCommand command = new MySqlCommand("insert into room(type,phone,reserved) values (@tp,@ph,@rsv)", db.getConnection());
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = this.Type;
            command.Parameters.Add("@ph", MySqlDbType.Int32).Value = this.Phone;
            command.Parameters.Add("@rsv", MySqlDbType.VarChar).Value = this.Reserved;
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

        //Create a function to update a room
        public override bool Update()
        {
            MySqlCommand command = new MySqlCommand("update room set type=@tp,phone=@ph,reserved=@rsv where id=@id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = this.ID;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = this.Type;
            command.Parameters.Add("@ph", MySqlDbType.Int32).Value = this.Phone;
            command.Parameters.Add("@rsv", MySqlDbType.VarChar).Value = this.Reserved;
            db.OpenConnection();
            if (command.ExecuteNonQuery()==1)
            {
                db.CloseConnection();
                return true;
            }
            else
            {
                return false;
            }

        }

        //Create a function to remove a room from the database
        public override bool Remove()
        {
            MySqlCommand command = new MySqlCommand("delete from room where id=@id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = this.ID;
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

        //Check if the room is reserved or not using idRoom
        public bool CheckRoom()
        {
            MySqlCommand command = new MySqlCommand("select  *from room where id=@id and reserved=@rsv", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = this.ID;
            command.Parameters.Add("@rsv", MySqlDbType.VarChar).Value = this.Reserved;
            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
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
