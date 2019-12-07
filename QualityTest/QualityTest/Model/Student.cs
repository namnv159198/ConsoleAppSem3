using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityTest.Model
{
    class Student
    {
        String RollNumber;
        String FullName;
        DateTime Birthday;
        String Email;
        String Phone;
        DateTime CreatedAt;



        public enum Status
        {
            Active = 1,
            Deactive = 0,
        }
        public Status enumStatus;
        
        public string RollNumber1 { get => RollNumber; set => RollNumber = value; }
        public string FullName1 { get => FullName; set => FullName = value; }
        public DateTime Birthday1 { get => Birthday; set => Birthday = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Phone1 { get => Phone; set => Phone = value; }
        public DateTime CreatedAt1 { get => CreatedAt; set => CreatedAt = value; }

        DateTime Datenow = DateTime.Now;
        
        public bool isNewStudent()
        {
            int totalDays = Convert.ToInt32((DateTime.Now - this.CreatedAt.Date).TotalDays);
            if (totalDays > 60)
            {
                return false;
            }
            else
            return true;
          }
        }
       
     
    }

    
    



