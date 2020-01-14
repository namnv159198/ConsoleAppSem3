using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sample1.Models;
using SQLitePCL;

namespace sample1.Services
{
    public class SQLiteService
    {
        public void createTable()
        {
            SQLiteConnection sqLiteConnection = new SQLiteConnection("SQLiteStudent.db");
            String SqlQuery = "CREATE TABLE  IF NOT EXISTS Students (Id varchar(50) NOT NULL," +
                              " Name varchar(250) unique ," +
                              "Status varchar (50))";
            var statment = sqLiteConnection.Prepare(SqlQuery);
            statment.Step();
        }

        public void createMember(Student student)
        {
            SQLiteConnection sqLiteConnection = new SQLiteConnection("SQLiteStudent.db");
            String SqlQuery = "Insert into Students (Id,Name,Status) values (?,?,?)";
            var statment = sqLiteConnection.Prepare(SqlQuery);
            statment.Bind(1,student.RollNumber);
            statment.Bind(2, student.Name);
            statment.Bind(3, student.Status);
            statment.Step();
        }

        public List<Student> listMember()
        {
            List<Student> listStudent = new List<Student>();
            SQLiteConnection sqLiteConnection = new SQLiteConnection("SQLiteStudent.db");
            String SqlQuery = "SELECT * FROM Students";
            var statment = sqLiteConnection.Prepare(SqlQuery);
            while (statment.Step() == SQLiteResult.ROW)
            {
                Student student = new Student()
                {
                    Name = (string)statment[1],
                };
                listStudent.Add(student);
            }

            return listStudent;
        }
    }
}
