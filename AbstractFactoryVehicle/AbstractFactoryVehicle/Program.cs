using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryVehicle
{
    public class Program
    {
        public interface IBike
        {
            void GetDetails();
        }
        public interface ICar
        {
            void GetDetails();
        }
        public class RegularBike : IBike
        {
            public void GetDetails()
            {
                Console.WriteLine("Fetching RegularBike Details..");
            }
        }
        public class SportsBike : IBike
        {
            public void GetDetails()
            {
                Console.WriteLine("Fetching SportsBike Details..");
            }
        }
        public class RegularCar : ICar
        {
            public void GetDetails()
            {
                Console.WriteLine("Fetching RegularCar Details..");
            }
        }
        public class SportsCar : ICar
        {
            public void GetDetails()
            {
                Console.WriteLine("Fetching SportsCar Details..");
            }
        }
        public interface IVehicleFactory
        {
            IBike CreateBike();
            ICar CreateCar();
        }
        public class RegularVehicleFactory : IVehicleFactory
        {
            public IBike CreateBike()
            {
                return new RegularBike();
            }
            public ICar CreateCar()
            {
                return new RegularCar();
            }
        }
        public class SportsVehicleFactory : IVehicleFactory
        {
            public IBike CreateBike()
            {
                return new SportsBike();
            }
            public ICar CreateCar()
            {
                return new SportsCar();
            }
        }

        public static void Main()
        {            
            IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();
            IBike regularBike = regularVehicleFactory.CreateBike();
            regularBike.GetDetails();
            ICar regularCar = regularVehicleFactory.CreateCar();
            regularCar.GetDetails();
//---------------------------------------------------------------------------------------------------------
            IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();
            IBike sportsBike = sportsVehicleFactory.CreateBike();
            sportsBike.GetDetails();
            ICar sportsCar = sportsVehicleFactory.CreateCar();
            sportsCar.GetDetails();
            Console.ReadKey();
        }
    }
}
