using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GrandCircus.LoopExamples
{
    public sealed class Program
    {
        static void Main(string[] args)
        {
            InitConsoleColours();

            PrintNumbersExamples();
            Console.Clear();
            PrintDaysOfWeekExamples();

            //PauseConsole();
        }

        #region Console Functions

        /// <summary>
        /// Sets the console's foreground and background colours.
        /// </summary>
        private static void InitConsoleColours()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        private static void PauseConsole()
        {
            Console.WriteLine();
            Console.Write("Press the ANY key to continue . . . ");
            Console.ReadKey(true); // Read key but don't display.
            Console.WriteLine();
        }

        #endregion Console Functions

        /// <summary>
        /// Examples that print numbers.
        /// </summary>
        static private void PrintNumbersExamples()
        {
            PrintNumbers numbersExample = new PrintNumbers();

            Console.WriteLine("===== FOR LOOP =====\n");
            numbersExample.ForLoop();
            Console.WriteLine();
            PauseConsole();

            Console.Clear();
            Console.WriteLine("===== FOREACH LOOP =====\n");
            numbersExample.ForLoopEach();
            Console.WriteLine();
            PauseConsole();

            Console.Clear();
            Console.WriteLine("===== WHILE LOOP =====\n");
            numbersExample.WhileLoop();
            Console.WriteLine();
            PauseConsole();

            Console.Clear();
            Console.WriteLine("===== DO WHILE LOOP =====\n");
            numbersExample.DoWhileLoop();
            Console.WriteLine();
            PauseConsole();

            Console.Clear();
            Console.WriteLine("===== FOREACH LOOP CONTINUE =====\n");
            numbersExample.ForLoopEachContinue();
            Console.WriteLine();
            PauseConsole();

            Console.Clear();
            Console.WriteLine("===== FOREACH LOOP BREAK =====\n");
            numbersExample.ForLoopEachBreak();
            Console.WriteLine();
            PauseConsole();

            Console.Clear();
            Console.WriteLine("===== RECURSIVE LOOP =====\n");
            numbersExample.RecursiveLoop(2); // Skip the first 2 items.
            Console.WriteLine();
            PauseConsole();
        }

        /// <summary>
        /// Examples that print the days of the week.
        /// </summary>
        static private void PrintDaysOfWeekExamples()
        {
            PrintDaysOfWeek daysExample = new PrintDaysOfWeek();

            Console.WriteLine("===== FOR LOOP =====\n");
            daysExample.ForLoop();
            PauseConsole();

            Console.Clear();
            Console.WriteLine("===== FOREACH LOOP =====\n");
            daysExample.ForLoopEach();
            PauseConsole();

            Console.Clear();
            Console.WriteLine("===== WHILE LOOP =====\n");
            daysExample.WhileLoop();
            PauseConsole();

            Console.Clear();
            Console.WriteLine("===== DO WHILE LOOP =====\n");
            daysExample.DoWhileLoop();
            PauseConsole();

            Console.Clear();
            Console.WriteLine("===== FOREACH LOOP CONTINUE =====\n");
            daysExample.ForLoopEachContinue();
            PauseConsole();

            Console.Clear();
            Console.WriteLine("===== FOREACH LOOP BREAK =====\n");
            daysExample.ForLoopEachBreak();
            PauseConsole();

            Console.Clear();
            Console.WriteLine("===== RECURSIVE LOOP =====\n");
            daysExample.RecursiveLoop(2); // Start on Wednesday.
            PauseConsole();
        }
    }
}