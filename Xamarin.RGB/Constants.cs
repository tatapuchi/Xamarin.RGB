using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.RGB
{

    public static class Constants
    {

        public static int Slow_Speed = 200;

        public static int Medium_Speed = 100;

        public static int Fast_Speed = 20;

        public static Range Red_Yellow = new Range();

        public static Range Green_Blue = new Range();

        public static Range Purple_Red = new Range();


    }


    public enum CycleStyle
    {
        Forwards,
        Backwards,
        Breathing
    }

    [Flags]
    public enum ChangeTypes
    {
        None = 0,
        Hue = 1,
        Saturation = 1 << 1,
        Luminosity = 1 << 2,
        Alpha = 1 << 3
    }

    [Flags]
    public enum ColourizerTypes
    {
        None = 0,
        BackgroundColor = 1,
        TextColour = 1 << 1,
        PlaceholderColour = 1 << 2
    }

}
