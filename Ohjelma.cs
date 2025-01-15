#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace tehtG1_2
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using var game = new tehtG1_2();
            game.Run();
        }
    }
}
