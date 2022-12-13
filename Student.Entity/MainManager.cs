using Student.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Student.Entity
{
    public class MainManager
    {
        private Students std = new Students();
        private static MainManager _Instance= new MainManager();
        public static MainManager Instance { get { return _Instance; } }
        private MainManager() { }
        public Hashtable studentsList = new Hashtable();
        public void Init() 
        {
            std.LoadStudents();
        }

        public void addStudentToDB(Model.Student s)
        {
            std.addStudent(s);
        }
    }
}
