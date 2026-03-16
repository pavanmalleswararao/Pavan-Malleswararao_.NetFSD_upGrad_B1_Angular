using System;
using System.Collections.Generic;
using System.Text;

namespace C__Inheritance_Assignment_Healthcare
{
    class Staff
    {
        public int StaffId {  get; set; }
        public string Name {  get; set; }
        public double BaseSalary { get; set; }
        public virtual double CalculateSalary()
        {
            return BaseSalary;
        }
    }
    class Doctor : Staff
    {
        public double ConsultationFee{  get; set; }
        public override double CalculateSalary()
        {
            return BaseSalary+ConsultationFee;
        }
    }
    class Nurse : Staff
    {
        public double NightShiftAllowance {  get; set; }
        public override double CalculateSalary()
        {
            return BaseSalary+NightShiftAllowance;
        }
    }
    class LabTechnician : Staff
    {
        public double EquipmentAllowance {  get; set; }
        public override double CalculateSalary()
        {
            return BaseSalary+EquipmentAllowance;
        }
    }
    
}
