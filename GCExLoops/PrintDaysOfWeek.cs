using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandCircus.LoopExamples
{
    /// <summary>
    /// Set of loop examples that print the days of the week.
    /// </summary>
    public sealed class PrintDaysOfWeek : IPrintLoopExample
    {
        #region Member Variables & Properties

        private const string s_customMessage = "I will do my homework on";
        private readonly string[] s_daysOfWeek = new string[]
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

        private const string s_specialDayOfWeek = "Friday";

        #endregion Member Variables & Properties

        #region Loop Examples

        #region For Loop & Foreach Examples

        /// <summary>
        /// Prints the days of week using a FOR LOOP.
        /// </summary>
        public void ForLoop()
        {
            for (int currentDay = 0; currentDay < NumOfDaysInWeek(); currentDay++)
            {
                Console.WriteLine("{0} {1}", s_customMessage, s_daysOfWeek[currentDay]);
            }
        }

        /// <summary>
        /// Prints the days of week using a FOREACH LOOP.
        /// </summary>
        public void ForLoopEach()
        {
            foreach (string currentDay in s_daysOfWeek)
            {
                Console.WriteLine("{0} {1}", s_customMessage, currentDay);
            }
        }

        #endregion For Loop & Foreach Examples

        #region Do While Examples

        /// <summary>
        /// Prints the days of week using a WHILE LOOP.
        /// </summary>
        public void WhileLoop()
        {
            int currentDay = 0;

            while (currentDay < NumOfDaysInWeek())
            {
                Console.WriteLine("{0} {1}", s_customMessage, s_daysOfWeek[currentDay++]);
            }
        }

        /// <summary>
        /// Prints the days of week using a DO WHILE LOOP.
        /// </summary>
        public void DoWhileLoop()
        {
            int currentDay = 0;

            do
            {
                Console.WriteLine("{0} {1}", s_customMessage, s_daysOfWeek[currentDay++]);
            } while (currentDay < NumOfDaysInWeek());
        }

        #endregion Do While Examples

        #region Continue & Break Examples

        /// <summary>
        /// Prints the days of week using a FOREACH LOOP with CONTINUE.
        /// </summary>
        public void ForLoopEachContinue()
        {
            foreach (string currentDay in s_daysOfWeek)
            {
                if (currentDay.Equals(s_specialDayOfWeek))
                {
                    /* Skip the special day of week, but go
                     * onto printing the subsequent value.*/
                    continue;
                }

                Console.WriteLine("{0} {1}", s_customMessage, currentDay);
            }
        }

        /// <summary>
        /// Prints the days of week using a FOREACH LOOP with BREAK.
        /// </summary>
        public void ForLoopEachBreak()
        {
            foreach (string currentDay in s_daysOfWeek)
            {
                Console.WriteLine("{0} {1}", s_customMessage, currentDay);

                if (currentDay.Equals(s_specialDayOfWeek))
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
        /// Prints the days of the week recursively.
        /// </summary>
        /// <param name="currentDay">Value representing the current day of the week.</param>
        /// <returns>Value representing the next day of the week.</returns>
        public int RecursiveLoop(int currentDay)
        {
            if (currentDay < 0 || currentDay >= NumOfDaysInWeek())
            {
                return -1;
            }

            if (s_daysOfWeek[currentDay].Equals(s_specialDayOfWeek) == false)
            {
                /* Skip the special day of week, 
                 * otherwise print the value.*/
                Console.WriteLine("{0} {1}", s_customMessage, s_daysOfWeek[currentDay]);
            }

            return RecursiveLoop(++currentDay);
        }

        #endregion Recursion Example

        #endregion Loop Examples

        /// <summary>
        /// Finds the length of the week.
        /// </summary>
        /// <returns>Number of days in a week.</returns>
        private int NumOfDaysInWeek()
        {
            return s_daysOfWeek.Length;
        }
    }
}