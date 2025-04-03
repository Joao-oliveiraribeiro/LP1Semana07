using System;

namespace BetterColorSpheres
{
    public class Color
    {
        public int Red {get; }
        public int Green {get; }
        public int Blue {get; }

        private int _alpha;

        public int Alpha
        {
            get => _alpha;
            set => _alpha = Clamp(value);
        }

        public Color(int red, int green, int blue, int alpha = 255)
        {
            Red = Clamp(red);
            Green = Clamp(green);
            Blue = Clamp(blue);
            Alpha = alpha;
        }
    }
}