using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandCircus.LoopExamples
{
    /// <summary>
    /// Set of loop examples that print numbers.
    /// </summary>
    public sealed class PrintNumbers : IPrintLoopExample
    {
        #region Member Variables & Properties

        private readonly int[] s_fibonacciNumbers = new int[]
        {
            1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144
        };

        private const int s_specialNumber = 13;

        #endregion Member Variables & Properties

        #region Loop Examples

        #region For Loop & Foreach Examples

        /// <summary>
        /// Prints the numbers from one to ten using a FOR LOOP.
        /// </summary>
        public void ForLoop()
        {
            for (int number = 1; number <= 10; number++)
            {
                Console.Write("  {0}  ", number);
            }
        }

        /// <summary>
        /// Prints the Fibonacci number sequence 
        /// from an array using a FOREACH LOOP.
        /// </summary>
        public void ForLoopEach()
        {
            foreach (int number in s_fibonacciNumbers)
            {
                Console.Write("  {0}  ", number);
            }
        }

        #endregion For Loop & Foreach Examples

        #region Do While Examples

        /// <summary>
        /// Prints the numbers from one to ten using a WHILE LOOP.
        /// </summary>
        public void WhileLoop()
        {
            int number = 1;

            while (number <= 10)
            {
                Console.Write("  {0}  ", number++);
            }
        }

        /// <summary>
        /// Prints the numbers from one to ten using a DO WHILE LOOP.
        /// </summary>
        public void DoWhileLoop()
        {
            int number = 1;

            do
            {
                Console.Write("  {0}  ", number++);
            } while (number < 11);
        }

        #endregion Do While Examples

        #region Continue & Break Examples

        /// <summary>
        /// Prints the Fibonacci number sequence from an 
        /// array using a FOREACH LOOP with CONTINUE.
        /// </summary>
        public void ForLoopEachContinue()
        {
            foreach (int number in s_fibonacciNumbers)
            {
                if (number.Equals(s_specialNumber))
                {
                    /* Skip the special number, but go onto
                     * printing the subsequent value.*/
                    continue;
                }

                Console.Write("  {0}  ", number);
            }
        }

        /// <summary>
        /// Prints the Fibonacci number sequence from
        /// an array using a FOREACH LOOP with BREAK.
        /// </summary>
        public void ForLoopEachBreak()
        {
            foreach (int number in s_fibonacciNumbers)
            {
                Console.Write("  {0}  ", number);

                if (number.Equals(s_specialNumber))
                {
                    /* Special value has already been printed. 
                     * Stop there and don't go onto printing 
                     * any more values beyond this point.*/
                    break;
                }
            }
        }

        #endregion Continue & Break Examples

        #region Recursion Example

        /// <summary>
        /// Prints the Fibonacci number sequence recursively from an array.
        /// </summary>
        /// <param name="currentItem">Value representing the current item in array.</param>
        /// <returns>Value representing the next array item.</returns>
        public int RecursiveLoop(int currentItem)
        {
            if (currentItem < 0 || currentItem >= LengthOfFibonacciArray())
            {
                return -1;
            }

            if (s_fibonacciNumbers[currentItem].Equals(s_specialNumber) == false)
            {
                /* Skip the special number, otherwise print the value.*/
                Console.Write("  {0} ", s_fibonacciNumbers[currentItem]);
            }

            return RecursiveLoop(++currentItem);
        }

        #endregion Recursion Example

        #endregion Loop Examples

        /// <summary>
        /// Finds the length of the Fibonacci number array.
        /// </summary>
        /// <returns>Length of the Fibonacci number array.</returns>
        private int LengthOfFibonacciArray()
        {
            return s_fibonacciNumbers.Length;
        }
    }
}