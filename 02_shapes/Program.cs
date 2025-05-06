using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_interface
{
    interface IShape
    {
        void Draw();
        
        double Area  { get; set; }
        char Symbol { get; set; }
        string Color { get; set; }
    }

    class Triagnle : IShape
    {
        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int x = 0; x <= i; x++)
                {
                    Console.Write(Symbol);
                }

                Console.WriteLine();
            }
        }

        public int Height { get; set; }
        
        public double Area { get; set; }
        public char Symbol { get; set; }
        public string Color { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triagnle tr = new()
            {
                Height = 10,
                Symbol = '#',
                Color = "Red"
            };
            
            tr.Draw();
        }
    }
}
