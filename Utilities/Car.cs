using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay3.Utilities
{
    internal class Car : Vehicle
    {
        public Car(string firstName, string lastName, DateTime productionDate, DateTime lastInspection) : base(firstName, lastName, productionDate, lastInspection)
        {

        }
        public override bool IsNeedingInspection()
        {
            bool isNeedingInspection = false;

            if (DateTime.Now > new DateTime(LastInspection.Year + 2, LastInspection.Month, LastInspection.Day) &&
                 DateTime.Now > new DateTime(ProductionDate.Year + 4, ProductionDate.Month, ProductionDate.Day))
            { 
                isNeedingInspection = true; 
            }
            return isNeedingInspection;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Car: {Brand} {Model}");
        }
        public override void SetTireType(bool isWinterTire)
        {
            if (isWinterTire) {this.MaxRimSize = 16;}
            else { this.MaxRimSize = 22; }
        }
    }
}
