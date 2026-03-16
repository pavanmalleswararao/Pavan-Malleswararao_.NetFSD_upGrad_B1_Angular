using C__Inheritance_Assignment_Banking;
using C__Inheritance_Assignment_E_Commerce;
using C__Inheritance_Assignment_Education;
using C__Inheritance_Assignment_Furniture;
using C__Inheritance_Assignment_Healthcare;
using C__Inheritance_Assignment_Vehicle;

namespace C__Inheritance_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment-1
            Staff s1 = new Doctor()
            {
                StaffId = 101,
                Name = "Dr. Reddy",
                BaseSalary = 50000,
                ConsultationFee = 15000
            };

            Staff s2 = new Nurse()
            {
                StaffId = 102,
                Name = "Priya",
                BaseSalary = 30000,
                NightShiftAllowance = 5000
            };

            Staff s3 = new LabTechnician()
            {
                StaffId = 103,
                Name = "Rahul",
                BaseSalary = 20000,
                EquipmentAllowance = 4000
            };

            Console.WriteLine("Doctor Salary: "+ s1.CalculateSalary());
            Console.WriteLine("Nurse Salary: " + s2.CalculateSalary());
            Console.WriteLine("Lab Techinsion Salary: "+s3.CalculateSalary());
            Console.WriteLine();

            //Assignment-2
            Account acc = new Account(15000)
            {
                AccountNumber = 895962626,
            };
            acc.CalculateInterest();

            SavingsAccount savings = new SavingsAccount(15000);
            savings.CalculateInterest();

            CurrentAccount current = new CurrentAccount(15000);
            current.CalculateInterest();

            Console.WriteLine();
            
            //Assignment-3
            Order o1=new Order() { OrderId=100};
            Order o2 = new StandardOrder() { OrderId=101};
            Order o3=new ExpressOrder() { OrderId=102};
            Order o4 = new InternationalOrder() { OrderId=103};

            Console.WriteLine("Default shipping cost: " + o1.CalculateShippingCost());
            Console.WriteLine("StandardOrder shipping cost: "+o2.CalculateShippingCost());
            Console.WriteLine("ExpressOrder shipping cost: "+o3.CalculateShippingCost());
            Console.WriteLine("InternationalOrder shipping cost: "+o4.CalculateShippingCost());

            Console.WriteLine();

            //Assignment-4
            ElectricCar electric = new ElectricCar();
            electric.VehicleNumber = "AP37AB1234";
            electric.Brand = "Tata Nexon EV";
            electric.FuelType = "Electric";

            electric.StartVehicle();
            electric.ShowCarDetails();
            electric.ShowEletricCarInfo();
            Console.WriteLine();
            
            //Assignment-5
            Student[] students = new Student[]
            {
                new SchoolStudent(1,"Ravi",45),
                new CollegeStudent(2,"Anjali",55),
                new OnlineStudent(3,"Kiran",65)
            };

            foreach (Student student in students)
            {
                Console.WriteLine("Student Id: " + student.StudentId);
                Console.WriteLine("Student Name: " + student.Name);
                Console.WriteLine("Student Marks: " + student.Marks);
                Console.WriteLine("Student Grade: " + student.CalculateGrade());
                Console.WriteLine("----------------------------");
            }

            Console.WriteLine();

            //Assignnment-6
            Console.WriteLine("Select Your Furniture Type:");
            Console.WriteLine("1. Chair");
            Console.WriteLine("2. Cot");

            int choice = Convert.ToInt32(Console.ReadLine());

            Furniture f;
            if (choice == 1)
                f = new Chair();
            else
                f = new Cot();

            f.GetData();
            f.ShowData();
        }
    }
}
