using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCAssignments
{
    public class UC5
    {
        public const int full_time = 1;
        public const int part_time = 2;
        public const int emp_rate_per_hr = 20;
        public const int num_of_working_days = 20;
        public static void workingdays()
        {
            int emphr = 0;
            int empwage = 0;
            int totalempwage = 0;

            for (int day = 0; day < num_of_working_days; day++)
            {

                Random random = new Random();
                int empcheck = random.Next(3);

                switch (empcheck)
                {
                    case full_time:
                        emphr = 8;
                        break;
                    case part_time:
                        emphr = 4;
                        break;
                    default:
                        emphr = 0;
                        break;
                }

                empwage = emphr * emp_rate_per_hr;

                totalempwage += empwage;

                Console.WriteLine("Empwage " + empwage);
            }
            Console.WriteLine("Total Emp Wage " + totalempwage);
        }
    }
}
