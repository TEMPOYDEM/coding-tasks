using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace task_7_salary_tracker
{
    class Seller : 
    {
        private double salary;

        public double GetSalary(double shifts)
        {
            return shifts * zp_baz / 24;
        }

        public void SetBasicSalary(double salary)
        {
            zp_baz = salary;
        }
    }
}
}
