using System;

namespace HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введиту сумму кредита");
            var summ = Console.ReadLine();
            var s = double.Parse(summ);
            Console.WriteLine("Введите значение %");
            var prosent = Console.ReadLine();
            var p = float.Parse(prosent);
            int m;
            for (m = 0; m < 13; m++) ;
            {
                if (m < 13) ;
                Console.WriteLine("Сумма:" + (s / m + (s - (s - m) * p / 100 / 12)));

            }



        }
    }


}
