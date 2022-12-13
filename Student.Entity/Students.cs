using Student.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Student.Entity
{
    public class Students
    {
        public void LoadStudents()
        {
            SqlQuery.RunCommandResult("Select * from StudentInfo", insertToHashTableFromDB);
        }
        public object insertToHashTableFromDB(SqlDataReader reader)
        {
            MainManager.Instance.studentsList.Clear();
            while (reader.Read())
            {
                string Name = reader.GetString(0);
                int Age = reader.GetInt16(1);
                string Address = reader.GetString(2);
                int ID = reader.GetInt32(3);
                Model.Student student = new Model.Student(Name, Age, Address, ID);
                MainManager.Instance.studentsList.Add(ID, student);
            }
            return MainManager.Instance.studentsList;
        }

        public void addStudent(Model.Student student )
        {
            string Query = string.Format("INSERT INTO StudentInfo (Name, Age, Address, ID) VALUES ('{0}', {1}, '{2}', {3})",student.Name , Convert.ToInt16(student.Age), student.Address, student.ID);
            SqlQuery.RunNonQuery(Query);
        }
    }
}
