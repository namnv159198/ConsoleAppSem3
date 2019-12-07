using QualityTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityTest
{
    class Program
    {
        public static StudentController st = new StudentController();
        public Student student = new Student();
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("------------------ THE  STUDENT MANAGEMENT SYSTEM   ------------------");
                Console.WriteLine("1.CREATE STUDENT.");
                Console.WriteLine("2.PRINT STUDENT.");
                Console.WriteLine("0.Exit");
                do
                {
                    Console.WriteLine("Choose funtion (0/1/2) : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 0 || choice > 2) Console.WriteLine("Error ! Please choose again !");
                } while (choice < 0 || choice > 2);
                switch (choice)
                {
                    case 1:
                        st.CreateStudent();
                        break;
                    case 2:
                        st.printListStudent();
                        break;
                    case 0:
                        return;
                }
            } while (choice != 0);
        }
    }
    
}



