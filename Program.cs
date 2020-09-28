using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p = new int[15];
            Random rand = new Random();
            for (int i = 0; i < p.Length; i++) { 
                p[i] = rand.Next(-10,10);
                Console.Write(p[i] + " ");
            }
            Console.WriteLine();
            int[] m = new int[17];
            for (int i = 0; i < m.Length; i++)
            {
                if(i % 2 == 0)
                {
                    m[i] = i * p[i];
                }
                else
                {
                    m[i] = -p[i];
                }
                Console.Write(m[i] + " ");
            }
            Console.WriteLine("Программа завершена.");
            Console.ReadKey();
        }
        
    }
}
