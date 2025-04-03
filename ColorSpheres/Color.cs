using System;

namespace ColorSpheres
{
    public class Color
    {
        private readonly int _red, _green; _blue, _alpha;

        public Color(int red, int green, int blue, int alpha = 255)
        {
            _red = Clamp(red);
            _green = Clamp(green);
            _blue = Clamp(blue);
            _alpha = Clamp(alpha);
        }
        public int GetRed() => _red;
        public int GetGreen() => _green;
        public int GetBlue() => _blue;
        public int GetAlpha() => _alpha;

        
    }
}