namespace ColorSpheres
{
    public class Sphere
    {
        private readonly Color _color;
        private int _radius;
        private int _timesThrown;

        public Sphere(Color color, int radius)
        {
            _color = color;
            _radius = radius;
            _timesThrown = 0;
        }

        public Color GetColor() => _color;
    }
}