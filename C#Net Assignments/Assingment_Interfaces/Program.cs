using Assingment_Interfaces_Abstract;
using Assingment_Interfaces_interface;

namespace Assingment_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment-1
            Console.WriteLine("======TCS========");
            TCS tcs = new TCS(101,"Pavan","IT","Developer",50000);
            Console.WriteLine($"ID: {tcs.EmpId}, Name: {tcs.Name}, Department: {tcs.Dept}, Designation: {tcs.Desg}, Salary: {tcs.BasicSalary}");
            tcs.EmployeePF(tcs.BasicSalary);
            Console.WriteLine("Leave Details: "+tcs.LeaVeDetails());
            Console.WriteLine("Gratuity: "+tcs.gratuityAmount(6,tcs.BasicSalary));
            Console.WriteLine();

            Console.WriteLine("========Accenture=======");
            Accenture acc = new Accenture(102, "Ravi", "HR", "Manager", 60000);
            Console.WriteLine($"ID: {acc.EmpId}, Name: {acc.Name}, Department: {acc.Dept}, Designation: {acc.Desg}, Salary: {acc.BasicSalary}");
            acc.EmployeePF(acc.BasicSalary);
            Console.WriteLine("Leave Details: "+acc.LeaVeDetails());
            Console.WriteLine("Gratuity: "+acc.gratuityAmount(6,acc.BasicSalary));
            Console.WriteLine();

            //Assignment-2
            TotalSales totalSales = new TotalSales();
            Console.WriteLine("Daily Sales: "+totalSales.DailySales());
            Console.WriteLine("Montly Sales: "+totalSales.MonthlySales(totalSales.DailySales()));
            Console.WriteLine("Annual sales: "+totalSales.YearlySales());
        }
    }
}
