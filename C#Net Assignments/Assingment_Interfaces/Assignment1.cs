using System;
using System.Collections.Generic;
using System.Text;

namespace Assingment_Interfaces_interface
{
    interface GovtRules
    {
        public double EmployeePF(double basicSalary);
        public string LeaVeDetails();
        public double gratuityAmount(float serviceCompleted, double basicSalary);
    }
    class TCS:GovtRules
    {
        private int empid;
        private string name, dept, desg;
        private double basicSalary;
        
        public TCS(int empid,string name,string dept,string desg,double basicSalary)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }

        public int EmpId => empid;
        public string Name => name;
        public string Dept => dept;
        public string Desg => desg;
        public double BasicSalary => basicSalary;

        public double EmployeePF(double basicSalary)
        {
            double employeePF = basicSalary * 0.12;
            double employerPF = basicSalary * 0.0833;
            double Pension = basicSalary * 0.0367;

            Console.WriteLine($"Employee PF: {employeePF}");
            Console.WriteLine($"Employer PF: {employerPF}");
            Console.WriteLine($"Pension: {Pension}");

            return employeePF+employerPF;
        }

        public string LeaVeDetails()
        {
            return "Leave Details for TCS is \r\n1 day of Casual Leave per month\r\n12 days of Sick Leave per year\r\n10 days of Previlage Leave per year\r\n";
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted > 20)
                return 3 * basicSalary;
            else if (serviceCompleted > 10)
                return 2 * basicSalary;
            else if (serviceCompleted > 5)
                return basicSalary;
            else
                return 0;
        }
    }
    class Accenture : GovtRules
    {
        private int empid;
        private string name, dept, desg;
        private double basicSalary;

        public Accenture(int empid, string name, string dept, string desg, double basicSalary)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }

        public int EmpId=> empid;
        public string Name => name;
        public string Dept => dept;
        public string Desg => desg;
        public double BasicSalary => basicSalary;
        public double EmployeePF(double basicSalary)
        {
            double EmployeePF = basicSalary * 0.12;
            double EmployerPF = basicSalary * 0.12;
            Console.WriteLine($"Employee PF: {EmployeePF}");
            Console.WriteLine($"Employer PF: {EmployerPF}");
            return EmployeePF + EmployerPF;
        }

        public string LeaVeDetails()
        {
            return "Leave Details for Accenture is \r\n2 day of Casual Leave per month\r\n5 days of Sick Leave per year\r\n5 days of Previlage Leave per year\r\n";
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0;
        }
    }
}
