using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCAssignments
{
    public class UC1
    {
            public static void CheckAttendance()
            {
                int Full_Time = 1;

                Random random = new Random();
                int empcheck = random.Next(2);

                if (empcheck == Full_Time)
                {
                    Console.WriteLine("Employee is Present");
                }
                else
                {
                    Console.WriteLine("Employee is Absent");
                }
            }
      
    }
}

