using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandCircus.LoopExamples
{
    public interface IPrintLoopExample
    {
        /// <summary>
        /// Prints the days of week using a FOR LOOP.
        /// </summary>
        void ForLoop();

        /// <summary>
        /// Prints the days of week using a FOREACH LOOP.
        /// </summary>
        void ForLoopEach();

        /// <summary>
        /// Prints the days of week using a WHILE LOOP.
        /// </summary>
        void WhileLoop();

        /// <summary>
        /// Prints the days of week using a DO WHILE LOOP.
        /// </summary>
        void DoWhileLoop();

        /// <summary>
        /// Prints the days of week using a FOREACH LOOP with CONTINUE.
        /// </summary>
        void ForLoopEachContinue();

        /// <summary>
        /// Prints the days of week using a FOREACH LOOP with BREAK.
        /// </summary>
        void ForLoopEachBreak();

        /// <summary>
        /// Prints the days of the week recursively.
        /// </summary>
        /// <param name="currentDay">Value representing the current day of the week.</param>
        /// <returns>Value representing the next day of the week.</returns>
        int RecursiveLoop(int currentDay);
    }
}