namespace MySpecs.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Provides calculation methods
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Return the sum of two values
        /// </summary>
        /// <param name="a">Value 1</param>
        /// <param name="b">Value 2</param>
        /// <returns>The sum of the values</returns>
        public double sum(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Substracts two numbers
        /// </summary>
        /// <param name="a">Value 1</param>
        /// <param name="b">Value 2</param>
        /// <returns>The substraction of the two values</returns>
        public static double Substract(double a, double b)
        {
            return a - b;
        }
    }
}
