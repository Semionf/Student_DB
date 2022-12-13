using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Model
{
    public class Student
    {
        public string Name { get; set; }
        private int _Age;
        public int Age { get { return _Age; } }
        public string Address { get; set; }
        private int _ID;
        public int ID { get { return _ID; }  }
        public Student(string Name, int Age, string Address, int ID)
        {
            this.Name = Name;
            this._Age = Age;
            this.Address = Address;
            this._ID = ID;
        }
    }
}
