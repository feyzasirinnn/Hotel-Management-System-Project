using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Hotel_Management_System
{
    abstract class BaseClass
    {
        public virtual bool Insert()
        {
            return true;
        }
        public virtual bool Update()
        {
            return true;
        }
        public virtual bool Remove()
        {
            return true;
        }
        public virtual DataTable GetAll()
        {
            DataTable table = new DataTable();
            return table;
        }

    }
}
