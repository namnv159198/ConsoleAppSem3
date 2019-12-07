using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityTest.Model
{
    class StudentController
    {
        public List<Student> listStudent = new List<Student>();

        public void printListStudent()
        {
            Console.WriteLine("---------------------- LIST STUDENT ----------------------");
            int k = 1;
            foreach (Student st in listStudent)
            {
                Console.WriteLine("------------------ Number " + k + " ------------------");
                Console.WriteLine("ID : " + st.RollNumber1);
                Console.WriteLine("Name : " + st.FullName1);
                Console.WriteLine("Birthday :"+ st.Birthday1);
                Console.WriteLine("Email: " + st.Email1);
                Console.WriteLine("Phone : " + st.Phone1);
                k++;
            }
        }
        public Student CreateStudent()
        {

            Student s = new Student();
                Console.WriteLine("Input RollNumber: ");
                String roll = Console.ReadLine();
                Console.WriteLine("Input FullName : ");
                String name = Console.ReadLine();
                Console.WriteLine("Input Birthday : ");
                Console.WriteLine("Input Day : ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Month : ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Year : ");
                int year = Convert.ToInt32(Console.ReadLine());
                DateTime birthday = new DateTime(year, month, day);
                Console.WriteLine("Input Email : ");
                String email = Console.ReadLine();
                Console.WriteLine("Input Phone : ");
                String Phone = Console.ReadLine();
                Console.WriteLine("Input Create At : ");
                Console.WriteLine("Input Day : ");
                int dayCreate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Month : ");
                int monthCreate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Year : ");
                int yearCreate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input  status : (1,Active), (0,Deactive)");
                int status  = Convert.ToInt32(Console.ReadLine());
                s.RollNumber1 = roll;
                s.RollNumber1 = name;
                s.Birthday1 = birthday;
                s.Email1 = email;
                s.Phone1 = Phone;
                if (status == 1)
                {
                    s.enumStatus = Student.Status.Active;
                }
                else
                {
                    s.enumStatus = Student.Status.Deactive;
                }

            return s;
        }
        
    }
}
