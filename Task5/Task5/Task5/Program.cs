using System;
using System.Collections.Generic;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<byte> Ages = new List<byte>();
            List<byte> ages = new List<byte> { 10, 45, 30, 32, 88, 91, 94 };
            Ages.Add(15);
            Ages.Add(20);
            Ages.AddRange(ages);

            Ages.Remove(45);
            Ages.RemoveAt(2);
            Ages.RemoveRange(2, 2);
            Ages.RemoveAll(e => e > 90);
            foreach (var item in Ages) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
