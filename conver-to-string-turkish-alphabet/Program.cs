using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;

namespace homework
{
    class number2string
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(yüzler(5));
            //Console.WriteLine(yüzler(7));
            //Console.WriteLine(yüzler(777));
            //Console.WriteLine(yüzler(235));
            //Console.WriteLine(yüzler(475));
            //Console.WriteLine(yüzler(185));
            //Console.WriteLine(yüzler(487));
            //Console.WriteLine(yüzler(647));
            //Console.WriteLine(yüzler(30));
            //Console.WriteLine(yüzler(50));
            //Console.WriteLine(yüzler(300));
            //Console.WriteLine(yüzler(900));
            //Console.WriteLine(yüzler(100));
            //Console.WriteLine(yüzler(10));
            //Console.WriteLine(yüzler(1));
            
            
            int num = 2147483647;
            Console.WriteLine(convertToString(num));
            Console.WriteLine(convertToString(1754383246));
            Console.WriteLine(convertToString(503374689));
            Console.WriteLine(convertToString(127699));
            Console.WriteLine(convertToString(12387));
            Console.WriteLine(convertToString(9544));
            Console.WriteLine(convertToString(587));

        }

        public static string convertToString(int num)
        {
            string text = num.ToString();
            Console.WriteLine(text.Length);
            if (text.Length == 10)
            {
                return yüzler(num / 1000000000) + " milyar " + yüzler((num / 1000000) % 1000) + " milyon " + yüzler((num / 1000) % 1000) + " bin " + yüzler(num % 1000); 
            }
            if(text.Length <= 9 && text.Length >= 7)
            {
                return yüzler((num / 1000000) % 1000) + " milyon " + yüzler((num / 1000) % 1000) + " bin " + yüzler(num % 1000);
            }
            if(text.Length <= 6 && text.Length >= 4)
            {
                return yüzler((num / 1000) % 1000) + " bin " + yüzler(num % 1000);
            }
            if(text.Length <= 3 && text.Length > 0)
            {
                return yüzler(num);
            }
            return "null";
        }

        public static string yüzler(int num)
        {
            String[] birliker = {"","sıfır", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            String[] onluklar = {"", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
            string yüzlük;
            string onluk;
            string birlik;
            string text = "";

            if(num > 99)
            {
                yüzlük= birliker[(num / 100) + 1];
                onluk = onluklar[(num / 10) % 10];
                birlik = birliker[num % 10 + 1];
                text = (num / 100 == 1 ? "" : yüzlük) + " yüz" + " " + (num % 100 == 0 ? "" : onluk + " " + birlik);
                return text.Trim();
            }

            if(num <= 99)
            {
                onluk = onluklar[(num / 10)];
                birlik = birliker[num % 10 + 1];
                text = onluk + " " + ((num % 10 == 0) ? "" : birlik);
                return text.Trim();
            }

            if(num < 10)
            {
                text = birliker[num % 10 + 1];
                return text.Trim();
            }
            return "null";
        }
    }
}