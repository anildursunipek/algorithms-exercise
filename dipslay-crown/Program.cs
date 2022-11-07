using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Homework2
{
    class first
    {
        public static void Main(string[] args)
        {
            int num;
            Console.Write("Please enter the number: ");
            num = int.Parse(Console.ReadLine());
            DispCrown(num);
        }
        public static void DispCrown(int n)
        {
            int space = (n * 2) - 2; // 4 için 6 || 5 için 8
            bool flag;
            for (int i = 1; i <= n; i++) // Satır sayısı 
            {
                for (int x = 1; x <= n * 4 - 1; x++) // Sütun sayısı
                {
                    flag = false;
                    for (int y=1; y <= i; y++)
                    { // Bu for döngüsü içerisinde sayı ile uyuşan noktalar test edilir
                        if (x == y || x == y + (space - (2 * (y - 1))) + 1 || x == (y + (space - (2 * (y - 1))) + 1) + (y - 1) * 2 || x == (y + (space - (2 * (y - 1))) + 1) + ((y - 1) * 2) + (space - (2 * (y - 1))) + 1)
                        {
                            Console.Write(y);
                            flag = true;
                            break;
                        }
                    }
                    if(flag == false)
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }
    }

}