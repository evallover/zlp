using System;

namespace piano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteChooseOperation();
 
        }

        static void WriteChooseOperation()
        {
            ConsoleKeyInfo clavisha;
            Console.WriteLine("F1 и F2 - Переключение между октавами");
            Console.WriteLine("F9 - выход из программы.");
            clavisha = Console.ReadKey();

            if (clavisha.Key == ConsoleKey.F1)
            {
                firstoctavia();
            }
            else if (clavisha.Key == ConsoleKey.F2)
            {
                secondoctavia();
            }
            else if (clavisha.Key == ConsoleKey.F9)
            {
                Environment.Exit(0);
            }

        }


        static void firstoctavia()
        {
            int[] firstoctavia = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987, };
            ConsoleKeyInfo clavisha;

            do
            {
                    clavisha = Console.ReadKey();

                if (clavisha.Key == ConsoleKey.A)
                {
                    Console.Beep(firstoctavia[0], 700);
                }

                if (clavisha.Key == ConsoleKey.Q)
                {
                    Console.Beep(firstoctavia[1], 700);
                }
                if (clavisha.Key == ConsoleKey.S)
                {
                    Console.Beep(firstoctavia[2], 700);
                }
                if (clavisha.Key == ConsoleKey.W)
                {
                    Console.Beep(firstoctavia[3], 700);
                }
                if (clavisha.Key == ConsoleKey.D)
                {
                    Console.Beep(firstoctavia[4], 700);
                }
                if (clavisha.Key == ConsoleKey.F)
                {
                    Console.Beep(firstoctavia[5], 700);
                }
                if (clavisha.Key == ConsoleKey.E)
                {
                    Console.Beep(firstoctavia[6], 700);
                }
                if (clavisha.Key == ConsoleKey.G)
                {
                    Console.Beep(firstoctavia[7], 700);
                }
                if (clavisha.Key == ConsoleKey.R)
                {
                    Console.Beep(firstoctavia[8], 700);
                }
                if (clavisha.Key == ConsoleKey.H)
                {
                    Console.Beep(firstoctavia[9], 700);
                }
                if (clavisha.Key == ConsoleKey.T)
                {
                    Console.Beep(firstoctavia[10], 700);
                }
                if (clavisha.Key == ConsoleKey.J)
                {
                    Console.Beep(firstoctavia[11], 700);
                }
                if (clavisha.Key == ConsoleKey.F9)
                {
                    Environment.Exit(0);
                }
            }
            while (clavisha.Key != ConsoleKey.O);

            secondoctavia();
        }

        static void secondoctavia()
        {
            int[] secondoctavia = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            ConsoleKeyInfo clavisha;

            do
            {
                clavisha = Console.ReadKey();

                if (clavisha.Key == ConsoleKey.A)
                {
                    Console.Beep(secondoctavia[0], 700);
                }

                if (clavisha.Key == ConsoleKey.Q)
                {
                    Console.Beep(secondoctavia[1], 700);
                }
                if (clavisha.Key == ConsoleKey.S)
                {
                    Console.Beep(secondoctavia[2], 700);
                }
                if (clavisha.Key == ConsoleKey.W)
                {
                    Console.Beep(secondoctavia[3], 700);
                }
                if (clavisha.Key == ConsoleKey.D)
                {
                    Console.Beep(secondoctavia[4], 700);
                }
                if (clavisha.Key == ConsoleKey.F)
                {
                    Console.Beep(secondoctavia[5], 700);
                }
                if (clavisha.Key == ConsoleKey.E)
                {
                    Console.Beep(secondoctavia[6], 700);
                }
                if (clavisha.Key == ConsoleKey.G)
                {
                    Console.Beep(secondoctavia[7], 700);
                }
                if (clavisha.Key == ConsoleKey.R)
                {
                    Console.Beep(secondoctavia[8], 700);
                }
                if (clavisha.Key == ConsoleKey.H)
                {
                    Console.Beep(secondoctavia[9], 700);
                }
                if (clavisha.Key == ConsoleKey.T)
                {
                    Console.Beep(secondoctavia[10], 700);
                }
                if (clavisha.Key == ConsoleKey.J)
                {
                    Console.Beep(secondoctavia[11], 700);
                }
                if (clavisha.Key == ConsoleKey.F9)
                {
                    Environment.Exit(0);
                }

            }
            while (clavisha.Key != ConsoleKey.F1);

            firstoctavia();
        }

    }
}