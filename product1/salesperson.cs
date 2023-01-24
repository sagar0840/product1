using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product1
{
    internal class salesperson
    {
        protected int id;
        protected string name;
        protected double basic, hra, da, ta, gross, pf, bonus, commission;
        private static int count;
        public salesperson(string name, double basic)
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
            bonus = basic * 0.60;
            commission = basic * 0.5;

            gross = (basic + hra + da + ta+bonus+commission) - pf;
        }
        public string salespersonDetails()
        {
            return $"Id ={id} , Name ={name}, Basic Salary ={basic}, Gross of salesperson ={gross}, bonus={bonus},commission={commission}";
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
