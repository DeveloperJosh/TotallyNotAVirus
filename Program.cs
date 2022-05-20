using System;

namespace FakeVirus
{
    class Virus {
        static void LoadBar(int progress, int total)
        {
            Console.CursorLeft = 0;
            Console.Write("[");
            Console.CursorLeft = 32;
            Console.Write("]"); 
            Console.CursorLeft = 1;
            float onechunk = 30.0f / total;

            int position = 1;
            for (int i = 0; i < onechunk * progress; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            for (int i = position; i <= 31; i++)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            Console.CursorLeft = 35;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(progress.ToString() + " of " + total.ToString() + "    ");
        }
        static void FakeVirus()
        {
            Console.WriteLine("Virus is loading...");
            Console.Beep(1000, 100);
            for (int i = 0; i < 101; i++)
            {
                LoadBar(i, 100);
                System.Threading.Thread.Sleep(10);
            }
            Console.Beep(1000, 100);
            Console.Write("\n Virus installed successfully");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\n You Now Have A Virus");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\nPress Any Key To Leave: ");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Virus.FakeVirus();
        }
    }
}