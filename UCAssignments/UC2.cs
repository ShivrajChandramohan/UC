using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCAssignments
{
    public class UC2
    {
        public static void employeewage()
        {
            int Full_Time = 1;
            int emp_rate_per_hr = 20;

            int emphrs = 0;
            int empwage = 0;

            Random random = new Random();
            int empcheck = random.Next(2);

            if (empcheck == Full_Time)
            {
                Console.WriteLine("Employee is Present");
                emphrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                emphrs = 0;
            }

            empwage = emphrs * emp_rate_per_hr;

            Console.WriteLine("Empwage: " + empwage);
        }
    }
}
