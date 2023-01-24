using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace product1
{
    internal class employee
    {

        protected int id;
        protected string name;
        protected double basic, hra, da, ta, gross, pf,bonus,commission;
        private static int count;
        public employee(string name, double basic)
        {
            count++;
            id = count;
            this.name = name;
            this.basic = basic;
        }

        public virtual void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            ta = basic * 0.10;
            pf = basic * 0.12;

            gross = (basic + hra + da + ta) - pf;
        }
        public string EmployeeDetails()
        {
            return $"Id ={id} , Name ={name}, Basic Salary ={basic}, Gross of Employee ={gross}";
        }


        public class Manager : employee
        {
            private double food, ma;
            
            public Manager(string name, double basic) : base(name, basic)
            {

            }
            public override void CalculateSalary()
            {
                hra = basic * 0.40;
                da = basic * 0.20;
                ta = basic * 0.10;
                pf = basic * 0.12;
                food = basic * 0.05;
                ma = basic * 0.12;
                gross = (basic + hra + da + ta + food) - (pf + ma);
            }
            public string DisplayManagerDetails()
            {
                return $"Id ={id} , Name ={name}, Basic Salary ={basic}, Gross of Manager ={gross}";
            }

        }
    }
}
