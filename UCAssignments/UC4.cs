using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCAssignments
{
    public class UC4
    {
        public const int full_time = 1;
        public const int part_time = 2;

        public static void switchcase()
        {
            int emp_rate_per_hr = 20;
            int emphr = 0;
            int empwage = 0;

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
            Console.WriteLine("Empwage " + empwage);
        }
    }
}
