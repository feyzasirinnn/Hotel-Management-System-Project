using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    abstract class Person //inheritance Base Class
    {
        //Fields
        private int _id;
        private string _first_name;
        private string _last_name;
        private int _phone;
        private string _email;

        //Proprieties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string First_name
        {
            get { return _first_name; }
            set { _first_name = value; }
        }

        public string Last_name
        {
            get { return _last_name; }
            set { _last_name = value; }
        }
        public int Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        //Method
        public virtual bool Insert()//polymorphisme
        {
            return true;
        }
    }
}
