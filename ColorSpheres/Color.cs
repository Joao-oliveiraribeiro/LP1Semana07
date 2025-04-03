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

        public int GetGrey()
        {
            return (_red+ _green+ _blue)/3;
        }
        private int Clamp(int value)
        {
            return Math.Max(0, Math.Min(255, value));
        }
        public override string ToString()
        {
            return $"Color(R:{_red}, G: {_green}, B: {_blue}, A: {_alpha})";
        }
    }
}