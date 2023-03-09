using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCAssignments
{
    public class UC3
    {
        public static void Parttimewage()
        {
            int part_time = 1;
            int emp_rate_per_hr = 20;
            int emphr = 0;
            int empwage = 0;

            Random random = new Random();
            int empcheck = random.Next(2);

            if (empcheck == part_time)
            {
                Console.WriteLine("Employee is Present");
                emphr = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                emphr = 0;
            }

            empwage = emphr * emp_rate_per_hr;
            Console.WriteLine("Empwage " + empwage);
        }
    }
}
