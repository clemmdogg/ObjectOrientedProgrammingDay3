using ObjectOrientedProgrammingDay3.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace ObjectOrientedProgrammingDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .BuildServiceProvider();

            string carBrand = "Audi";
            string carModel = "A6";
            DateTime carProductionDate = new DateTime(2018, 7, 1);
            DateTime carLastInspection = new DateTime(2018, 12, 8);
            Vehicle car = new Car(carBrand, carModel, carProductionDate, carLastInspection);
            car.SetTireType(false);

            string truckBrand = "Volvo";
            string truckModel = "H6";
            DateTime truckProductionDate = new DateTime(2018, 10, 1);
            DateTime truckLastInspection = new DateTime(2024, 10, 1);
            Vehicle truck = new Truck(truckBrand, truckModel, truckProductionDate, truckLastInspection);
            truck.SetTireType(false);

            car.DisplayInfo();
            Console.WriteLine($"Is needing inspection: {car.IsNeedingInspection()}");
            Console.WriteLine($"Cars max rim size: {car.MaxRimSize}");
            Console.WriteLine();
            truck.DisplayInfo();
            Console.WriteLine($"Is needing inspection: {truck.IsNeedingInspection()}");
            Console.WriteLine($"Truckss max rim size: {truck.MaxRimSize}");

            Console.WriteLine(car.GetInterfaceInfo());
        }
    }
    
}
