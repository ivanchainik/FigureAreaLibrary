namespace FigureAreaLibrary
{
    public class Triangle : Figure
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        public double FirstSide{ 
            get 
            {
                return _firstSide;
            }
            set 
            {
                if(IsNotZeroValue(value) && IsValidValues(value, _secondSide, _thirdSide))
                {
                    _firstSide = value;
                }
                else
                {
                    throw new ArgumentException("Side values are not correct for a triangle");
                }
            }
        }
        public double SecondSide
        {
            get
            {
                return _secondSide;
            }
            set
            {
                if (IsNotZeroValue(value) && IsValidValues(_firstSide, value, _thirdSide))
                {
                    _secondSide = value;
                }
                else
                {
                    throw new ArgumentException("Side values are not correct for a triangle");
                }
            }
        }
        public double ThirdSide
        {
            get
            {
                return _thirdSide;
            }
            set
            {
                if (IsNotZeroValue(value) && IsValidValues(_firstSide, _secondSide, value))
                {
                    _thirdSide = value;
                }
                else
                {
                    throw new ArgumentException("Side values are not correct for a triangle");
                }
            }
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if(IsNotZeroValue(firstSide) && IsNotZeroValue(secondSide) && IsNotZeroValue(thirdSide) && IsValidValues(firstSide, secondSide, thirdSide))
            {
                _firstSide = firstSide;
                _secondSide = secondSide;
                _thirdSide = thirdSide;
            }
            else
            {
                throw new ArgumentException("Side values are not correct for a triangle");
            }
        }

        private bool IsNotZeroValue(double side)
        {
            if(side > 0)
            {
                return true;
            }
            return false;
        }

        private bool IsValidValues(double firstSide, double secondSide, double thirdSide)
        {
            if(firstSide + secondSide > thirdSide && 
                secondSide + thirdSide > firstSide && 
                thirdSide + firstSide > secondSide)
            {
                return true;
            }
            return false;
        }

        public override double GetArea()
        {
            var HalfPerimetr = (FirstSide + SecondSide + ThirdSide) / 2;

            return Math.Sqrt(HalfPerimetr * (HalfPerimetr - FirstSide) * (HalfPerimetr - SecondSide) * (HalfPerimetr - ThirdSide));
        }

        public bool IsRightTriangle()
        {
            double[] SortedArraySides = new double[3] { FirstSide, SecondSide, ThirdSide }.OrderByDescending(x => x).ToArray();

            if(Math.Pow(SortedArraySides[0], 2) == Math.Pow(SortedArraySides[1], 2) + Math.Pow(SortedArraySides[2], 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
