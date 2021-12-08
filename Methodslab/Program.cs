using System;

namespace Methodslab
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = Func(1, 4) + Func(7, 5) + Func(3,2);
            Console.WriteLine("y={0:F2}",y);
            try
            {
                Console.WriteLine("Введите число в 8 c/c:");
                string ch;
                int k = 0;
                do
                {
                    ch = Console.ReadLine();
                    k = 0;
                    for (int i = 0; i < ch.Length; i++)
                    {
                        if (Char.IsDigit(ch[i])&&((int.Parse(ch[i].ToString()) < 0) ||
                                int.Parse(ch[i].ToString()) > 7))
                            {
                                k++;
                            }
                    }
                    if (k > 0) Console.WriteLine("Введите корректные числа:");
                }
                while (k>0);
                Console.WriteLine(toDec(ch));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //5.2 - базовый 
            int[,] mas = new int[6, 4];
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    mas[i, j] = rnd.Next(-10, 11);
                    Console.Write(mas[i,j]+" ");
                }
                Console.WriteLine();
            }
            
            int[] res = MyLib.ClassLib.SumNegative(mas);
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i]+" ");
            }
            Console.WriteLine();
        }
        static double Func(int x,int y)
        {
            return (x+Math.Sin(y)) / (Math.Sin(x)+y);
        }
        static int toDec(string str)
        {
            int s = 0;
            int step = str.Length - 1;
            for (int i = 0; i < str.Length; i++)
            {
                s += int.Parse(str[i].ToString()) * (int)Math.Pow(8, step);
                step--;
            }
            return s;
        }
    }
}
