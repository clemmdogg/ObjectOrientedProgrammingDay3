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

            DateTime dateForNeeedingInspection = new DateTime(LastInspection.Year + 4, LastInspection.Month, LastInspection.Day);
            if (DateTime.Now > dateForNeeedingInspection) { isNeedingInspection = true; }
            return isNeedingInspection;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Car: {Brand} {Model}");
        }
    }
}
