using System;
using MySql.Data.MySqlClient;
using System.Data;
namespace Hotel_Management_System
{
    class Reservation:BaseClass
    {
        private int id;
        private int client_id;
        private int typeRoom;
        private int room_id;
        private DateTime date_in;
        private DateTime date_out;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int ClientId
        {
            get { return client_id; }
            set { client_id = value; }
        }
        public int TypeRoom
        {
            get { return typeRoom; }
            set { typeRoom = value; }
        }
        public int RoomId
        {
            get { return room_id; }
            set { room_id = value; }
        }
        public DateTime Date_In
        {
            get { return date_in; }
            set { date_in = value; }
        }
        public DateTime Date_Out
        {
            get { return date_out; }
            set { date_out = value; }
        }

        MyDB db = new MyDB();

        public override DataTable GetAll()
        {
            MySqlCommand command = new MySqlCommand("select *from reservation", db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        //create a function to add a new reservation
        public override bool Insert()
        {
            MySqlCommand command = new MySqlCommand("insert into reservation (client_id,type_room,room_id,date_in,date_out)values(@cid,@typ,@rid,@datein,@dateout)", db.getConnection());
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = this.ClientId;
            command.Parameters.Add("@typ", MySqlDbType.Int32).Value = this.TypeRoom;
            command.Parameters.Add("@rid", MySqlDbType.Int32).Value = this.RoomId;
            command.Parameters.Add("@datein", MySqlDbType.Timestamp).Value = this.Date_In;
            command.Parameters.Add("@dateout", MySqlDbType.Timestamp).Value = this.Date_Out;
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

        //Create a function to update reservation
        public override bool Update()
        {
            MySqlCommand command = new MySqlCommand("update reservation set client_id=@cid,type_room=@typ,room_id=@rid,date_in=@datein,date_out=@dateout where id=@id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = this.ID;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = this.ClientId;
            command.Parameters.Add("@typ", MySqlDbType.Int32).Value = this.TypeRoom;
            command.Parameters.Add("@rid", MySqlDbType.Int32).Value = this.RoomId;
            command.Parameters.Add("@datein", MySqlDbType.Timestamp).Value = this.Date_In;
            command.Parameters.Add("@dateout", MySqlDbType.Timestamp).Value = this.Date_Out;
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

        //Create a function to delete reservation reservation
        public override bool Remove()
        {
            MySqlCommand command = new MySqlCommand("delete from reservation where id=@id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = this.ID;
          
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

        //create a function to get room by type
        public DataTable GetRoomByType()
        {
            MySqlCommand command = new MySqlCommand("select id from room where type=@type", db.getConnection());
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = this.TypeRoom;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);


            return table;
        }


    }
}
