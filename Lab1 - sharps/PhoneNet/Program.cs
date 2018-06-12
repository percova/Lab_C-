using System;
using System.Globalization;

namespace PhoneNet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter num of nodes: ");
            num = Convert.ToInt32(Console.ReadLine());

            double[,] costs;
            costs = new double[num, num];
            Console.WriteLine("Enter adjacency matrix: ");
            for (int i = 0; i < num; i++)
            {
                string enterString = Console.ReadLine();
                string[] massiveString = enterString.Split(new Char[] { ' ' });
                for (int j = 0; j < massiveString.Length; j++)
                {
                    costs[i, j] = int.Parse(massiveString[j]);
                }

            }

            Graph wiki = new Graph(num, costs);
            wiki.PrimsAlgo();
        }
    }
}