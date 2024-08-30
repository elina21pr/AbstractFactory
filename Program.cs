using System;

namespace AbstractFactory
{

    public abstract class AbstractFactory
    {

        public abstract void CreateCivilCar();
        public abstract void CreateMillitalyTrack();
        public abstract void CreateSportCar();

    }

    public class BMWFactory : AbstractFactory
    {
        public override void CreateCivilCar()
        {
            var car = new CivilCar("BMW", 80);
            car.StartDriving();
            car.Horn();
            Console.WriteLine(" BMW CivilCar is create");
        }

        public override void CreateMillitalyTrack()
        {
            Console.WriteLine(" MillitaryTruck is created");
        }

        public override void CreateSportCar()
        {
            Console.WriteLine(" SportCar is created");
        }


    }

    public abstract class AbstractCivilCar
    {
        private string brand { get; set; }
        private int speed { get; set; }

        protected AbstractCivilCar(string brand, int speed)
        {
            this.brand = brand;
            this.speed = speed;
        }

        public abstract void StartDriving();
        public abstract void Horn();
    }

    public abstract class AbstractMillitaryTruck
    {
        private string brand { get; set; }
        private int speed { get; set; }

        protected AbstractMillitaryTruck(string brand, int speed)
        {
            this.brand = brand;
            this.speed = speed;
        }

        public abstract void StartDriving();
        public abstract void Gun();
    }

    public abstract class AbstractSportCar
    {
        private string brand { get; set; }
        private int speed { get; set; }

        protected AbstractSportCar(string brand, int speed)
        {
            this.brand = brand;
            this.speed = speed;
        }

        public abstract void StartDriving();
        public abstract void Engine();
    }

    public class CivilCar : AbstractCivilCar
    {
        public CivilCar(string brand, int speed)
            : base(brand, speed)
        {
        }
        public override void StartDriving()
        {
            Console.WriteLine("Start driving");
        }
        public override void Horn()
        {
            Console.WriteLine("bip bip");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var bmwFactory = new BMWFactory();

            bmwFactory.CreateCivilCar();
        }
    }

}