using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_interface
{
    interface ITransport
    {
        double Speed { get; set; }
        int Odometer { get; set; }
        int Gear { get; set; }
        bool IsPowerOn { get; set; }
        
        void Drive();
        void Stop();
        void TurnLeft();
        void TurnRight();
    }
    
    class SportCar : ITransport
    {
        public double Speed { get; set; }
        public int Odometer { get; set; }
        public int Gear { get; set; }
        public bool IsPowerOn { get; set; }
        
        public void Drive()
        {
            Console.WriteLine("Sport car is driving now!");
            IsPowerOn = true;
            Speed += 10;
        }

        public void Stop()
        {
            Console.WriteLine("Sport car stopped!");
            Speed = 0;
            IsPowerOn = false;
        }

        public void TurnLeft()
        {
            Console.WriteLine("Sport car is turning left!");
            Speed -= 7;
        }

        public void TurnRight()
        {
            Console.WriteLine("Sport car is turning right!");
            Speed -= 7;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Sport Car:");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Power: {(IsPowerOn ? "ON" : "OFF")}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SportCar car = new SportCar();
            
            car.Drive();
            car.Stop();
            car.TurnLeft();
            car.Drive();
            car.Drive();
            car.ShowInfo();
            
            car.Stop();
            car.ShowInfo();
        }
    }
}
