using System;
using System.Collections.Generic;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yanacaq daxil edin(L):");
            decimal fual = Convert.ToDecimal(Console.ReadLine());

            List<Car> Cars = new List<Car>();

            Cars.Add(new Car("BMW", "X7", 5, 18));
            Cars.Add(new Car("Mercedes-Benz", "E500", 5, 20));
            Cars.Add(new Car("Mercedes-Maybach", "S650", 5, 23));
            Cars.Add(new Car("Lada", "Niva", 3, 11));
            Cars.Add(new Car("Toyota", "Land Cruiser", 5, 19));

            foreach (var item in Cars)
            {
                Console.WriteLine($"Brand: {item.Brand}, Model: {item.Model}, DoorCount: {item.DoorCount},  {item.FillInfo(fual)}");
            }
        }
    }
}
