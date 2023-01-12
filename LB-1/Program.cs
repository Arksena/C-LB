using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Program
    {
    class Program
    {
        static void Main(string[] args)
        {
            int time;
            Console.WriteLine("Input time");
            time = Convert.ToInt32(Console.ReadLine());
            int h = time / 3600;
            int m = (time - (h * 3600))/60;
            int s = time - ((h * 3600) + (m * 60));
            Console.WriteLine($" {h} hours {m} minutes {s} seconds ");
            Console.ReadKey();

        }
    }
    }