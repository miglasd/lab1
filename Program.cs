using System;
namespace ConsoleApp2
{
    public class Program
    {
        static public int Ploscha(int a, int b, int c)
        {
            int S = 2*(a*b+b*c+a*c);
            
            Console.WriteLine(" Площа дорівнює " + S.ToString());
            return S;
        
        }

        static public int Obiem(int a, int b, int c)
        {
           
            int V = a * b * c;
            Console.WriteLine(" Обєм дорівнює " + V.ToString());
            return V;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть a");
            string S1 = Console.ReadLine();
            int a = int.Parse(S1);
            Console.WriteLine("Введiть b");
            string S2 = Console.ReadLine();
            int b = int.Parse(S2);
            Console.WriteLine("Введiть c");
            string S3 = Console.ReadLine();
            int c = int.Parse(S3);
            Ploscha(a, b, c); 
            Obiem(a, b, c); Console.ReadLine();
        }
    }
}