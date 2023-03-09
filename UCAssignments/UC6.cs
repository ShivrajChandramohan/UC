using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCAssignments
{
    public class UC6
    {
        public const int full_time = 1;
        public const int part_time = 2;
        public const int emp_rate_per_hr = 20;
        public const int num_of_working_days = 20;
        public const int max_hrs_in_month = 100;
        public static void workinghrs()
        {
            int emphr = 0;
            int totalempwage = 0;
            int totalworkingdays = 0;
            int totalemphrs = 0;

            while (totalemphrs < max_hrs_in_month && totalworkingdays < num_of_working_days)
            {
                totalworkingdays++;
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
                totalemphrs += emphr;

                Console.WriteLine("Day " + totalworkingdays + " EmpHrs " + emphr);
            }
            totalempwage = totalemphrs * emp_rate_per_hr;
            Console.WriteLine("Total Emp Wage " + totalempwage);
        }
    }
}
