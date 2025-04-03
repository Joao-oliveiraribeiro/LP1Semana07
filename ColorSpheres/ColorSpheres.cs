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

        public void Pop()
        {
            _radius = 0;
        }
        public void Throw()
        {
            if (_radius > 0)
            {
                _timesThrow++;
            }
        }
        public int GetTimesThrown()
        {
            return _timesThrown;
        }
        public override string ToString()
        {
            return $"Sphere(Color: {_color}, Radius: {_radius}, Times Thrown: {_timesThrown})";
        }
    }
}