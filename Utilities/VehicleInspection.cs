using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay3.Utilities
{
    internal class VehicleInspection
    {
        public void RunVehicleInspection()
        {
            string carBrand = "Audi";
            string carModel = "A6";
            DateTime carProductionDate = new DateTime(2018, 7 , 1);
            DateTime carLastInspection = new DateTime(2022, 12, 8);
            Vehicle car = new Car(carBrand, carModel, carProductionDate, carLastInspection);

            string truckBrand = "Volvo";
            string truckModel = "H6";
            DateTime truckProductionDate = new DateTime(2018, 10, 1);
            DateTime truckLastInspection = new DateTime(2021, 10, 1);
            Vehicle truck = new Truck(truckBrand, truckModel, truckProductionDate, truckLastInspection);

            car.DisplayInfo();
            Console.WriteLine($"Is needing inspection: {car.IsNeedingInspection}");
            Console.WriteLine();
            truck.DisplayInfo();
            Console.WriteLine($"Is needing inspection: {truck.IsNeedingInspection}");
        }
    }
}
