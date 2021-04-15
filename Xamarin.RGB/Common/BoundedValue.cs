using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.RGB.Common
{
    public struct BoundedValue
    {
        public BoundedValue(double start, double end, double value)
        {
            if (start < 0 || start > 1) { throw new ArgumentException(); }
            if(end < 0 || end > 1) { throw new ArgumentException(); }
            if (value < 0 || value > 1) { throw new ArgumentException(); }

            Start = start;
            End = end;
            Value = value;
        }

        public double Start { get; }
        public double End { get; }
        public double Magnitude { get { return End - Start; } }
        public double Value { get; private set; }

        public override string ToString() => $"From {Start} to {End}, currently at {Value}";
    }
}
