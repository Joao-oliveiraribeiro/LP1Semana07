namespace BetterColorSpheres
{
    public class Sphere
    {
        public Color Color { get; }
        public int Radius { get; private set; }

        private int _timesThrown;
        public int TimesThrown
        {
            get => _timesThrown;
            private set => _timesThrown = value;
        }

        public Sphere(Color color, int radius)
        {
            Color = color;
            Radius = radius;
            TimesThrown = 0;
        }

        public void Pop()
        {
            Radius = 0;
        }
        public void Throw()
        {
            if (Radius > 0)
            {
                TimesThrown++;
            }
        }

        public override string ToString()
        {
            return $"Sphere(Color: {Color}, Radius: {Radius}, Times Thrown: {TimesThrown})";
        }
    }
}