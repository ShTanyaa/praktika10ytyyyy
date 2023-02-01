using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика_10_14_задание
{
    class Program
    {
        static  void create(int n,int m)
        {
            Random rnd = new Random();
            int[,] mas = new int[n, m];
            for(int i=0;i<n;i++)
            {
                for(int j = 0;j < m;j++)
                {
                    mas[i, j] = rnd.Next(0, 2);
                }
            }
        }
        static void print(int[,] mas,int n,int m)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = rnd.Next(0, 2);
                    Console.Write( mas[i, j]) ;
                }
                Console.WriteLine();
            }
        }
        static void zad(int[,] mas,int n,int m,int num)
        {
            int x = 0;
            for(int j=0;j<mas.GetLength(1);j++)
            {
                if (mas[num - 1, j] == 0) x++;
                
            }
            Console.WriteLine($"вагон-{num}");
            Console.WriteLine($"свободных мест в вагоне-{x}");
        }
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Random rnd = new Random();
                    int[,] mas = new int[10, 36];
                    print(mas, 10, 36);
                    Console.WriteLine("введи номер вагона ");
                    int num = int.Parse(Console.ReadLine());
                    zad(mas, 10, 36, num);
                }
                catch
                {
                    Console.WriteLine("error");
                }
                
            }
            

        }
    }
}
