namespace FigureAreaLibrary
{
    public class Circle : Figure
    {
        private double _radius;
        public double Radius {
            get
            {
                return _radius;
            } 
            set
            {
                _radius = value > 0 ? value : throw new ArgumentException("Radius can't be negative");
            } 
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
