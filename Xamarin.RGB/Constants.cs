using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.RGB
{
    /// <summary>
    /// A class containing useful constants for colour changing.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Colours changing at a slow speed.
        /// </summary>
        public static int Slow_Speed = 200;
        /// <summary>
        /// Colours changing at a normal speed.
        /// </summary>
        public static int Medium_Speed = 100;
        /// <summary>
        /// Colours changing at a high speed.
        /// </summary>
        public static int Fast_Speed = 20;


        /// <summary>
        /// Colour range from red to yellow.
        /// </summary>
        public static Range Red_Yellow = new Range();

        /// <summary>
        /// Colour range from green to blue.
        /// </summary>
        public static Range Green_Blue = new Range();


        /// <summary>
        /// Colour range from purple to red.
        /// </summary>
        public static Range Purple_Red = new Range();


    }
}
