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

            for (m = 1; m <= 12; m++)
            {
                double w = s / 12;
                double summ1 = (w + (s - (w * m) * p / 100 / 12));

                if (m <= 12) ;

                Console.WriteLine("Сумма за месяц" + m + ":" + (summ1 - s));
            }
        }
    }

}








