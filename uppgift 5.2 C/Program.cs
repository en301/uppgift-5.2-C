using System;

namespace uppgift_5_2
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hur många tal vill du skriva in?");
            int antal = int.Parse(Console.ReadLine());
            int[] tal = new int[antal];
            Console.WriteLine("Skriv in "+ antal +" tal");
            for (int i = 0; i < antal; i++)
            {
                tal[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Här är talen du skrev in");
            for (int j = 0;j < antal;j++)
            {
                Console.WriteLine("Tal"+ (j+1) +": "+ tal[j]);
            }
            Console.ReadKey();
        }
    }
}
