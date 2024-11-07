using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay3.Utilities
{
    internal class Truck : Vehicle
    {
        public Truck(string firstName, string lastName, DateTime productionDate, DateTime lastInspection) : base(firstName, lastName, productionDate, lastInspection)
        {

        }
        public override bool IsNeedingInspection()
        {
            bool isNeedingInspection = false;

            if (DateTime.Now > new DateTime(LastInspection.Year + 1, LastInspection.Month, LastInspection.Day) &&
                DateTime.Now > new DateTime(ProductionDate.Year + 1, ProductionDate.Month, ProductionDate.Day))
            {
                isNeedingInspection = true;
            }
            return isNeedingInspection;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Truck: {Brand} {Model}");
        }
        public override void SetTireType(bool isWinterTire)
        {
            if (isWinterTire) { this.MaxRimSize = 17; }
            else { this.MaxRimSize = 20; }
        }
    }
}

