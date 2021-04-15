using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.RGB
{
    /// <summary>
    /// Struct to define a range in between 0 and 1 for you colour cycling.
    /// </summary>
    public struct Range
    {
        /// <summary>
        /// Constructor with start and end value parameters for the range.
        /// </summary>
        /// <param name="start">Start value of your range.</param>
        /// <param name="end">End value of your range.</param>
        public Range(double start, double end)
        {
            if (start < 0 || start > 1 || end < 0 || end > 1) { throw new ArgumentException(); }

            Start = start;
            End = end;
        }

        /// <summary>
        /// Start value of the range.
        /// </summary>
        public double Start { get; }; 

        /// <summary>
        /// End value of the range.
        /// </summary>
        public double End { get; }

        /// <summary>
        /// ToString() override.
        /// </summary>
        /// <returns>A string indicating the range.</returns>
        public override string ToString() => $"From {Start} to {End}";
    }

}
