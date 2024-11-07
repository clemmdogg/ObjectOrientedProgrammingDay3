using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay3.Utilities
{
    internal abstract class Vehicle : IWheels
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime LastInspection { get; set; }
        public int MaxRimSize { get; set; }
        public Vehicle(string firstName, string lastName, DateTime productionDate, DateTime lastInspection)
        {
            Brand = firstName;
            Model = lastName;
            ProductionDate = productionDate;
            LastInspection = lastInspection;
        }
        public abstract bool IsNeedingInspection();
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Production Date: {ProductionDate.ToShortDateString()}");
        }
        public abstract void SetTireType(bool isWinterTire);
        public virtual string GetInterfaceInfo()
        {
            IWheels myInterface = this;
            return myInterface.Info();
        }
    }
}
