using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.RGB
{
    public struct Range
    {
        public static Range FullRange = new Range(0, 1);
        public static Range HalfRange = new Range(0, 1);
        public Range(double start, double end)
        {
            if (start < 0 || start > 1 || end < 0 || end > 1) { throw new ArgumentException(); }

            Start = start;
            End = end;
        }

        public double Start { get; }
        public double End { get; }
        public double Magnitude { get { return End - Start; } }

        public override string ToString() => $"From {Start} to {End}";
    }

}
