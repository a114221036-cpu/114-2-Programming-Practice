using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dn, p, nd, i, r, q;
            int[] N = new int[10];
            Console.Write("輸入十進位數字dn(>0): ");
            dn = int.Parse(Console.ReadLine());
            Console.Write("輸入要轉成幾進位p(0 ~ 9): ");
            p = int.Parse(Console.ReadLine());
            nd = -1; q = dn;
            while (q != 0)
            {
                r = q % p;
                N[++nd] = r;
                q = q / p;
                Console.Write($"{N[nd]}\n");

            }
            nd = nd + 1;
            Console.Write($"共有幾個位數 = {nd}\n:", nd);
            for (i = nd - 1; i >= 0; i--)
                Console.Write($"{N[i]}");

            Console.Write("\n程式即將結束，請按任意一建結束!    ");
            Console.Read();
        }
    }
}
