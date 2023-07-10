using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public abstract class Shape
    {
        protected virtual bool IsExists { get { return false; } }
        public virtual double GetArea() => 0;
    }

    public class Rectangle : Shape
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        protected override bool IsExists
        {
            get { return width > 0 && height > 0; }
        }

        public override double GetArea()
        {
            if (!IsExists)
                return base.GetArea();

            return width * height;
        }
    }

    public class Square : Rectangle
    {
        public Square(int side) : base(side, side) {}
    }

    public class Ellipse : Shape
    {
        private int xrad , yrad;

        public Ellipse(int xrad, int yrad)
        {
            this.xrad = xrad;
            this.yrad = yrad;
        }

        protected override bool IsExists
        {
            get { return xrad > 0 && yrad > 0; }
        }

        public override double GetArea()
        {
            if (!IsExists)
                return base.GetArea();

            return Math.PI* xrad *yrad;
        }
    }

    public class Circle : Ellipse
    {
        public Circle(int rad) : base(rad, rad) { }
    }

    public class Triangle : Shape
    {
        private int a, b, c;

        protected override bool IsExists
        {
            get { return a > 0 && b > 0 && c > 0 && !(a + b <= c || a + c <= b || b + c <= a); }
        }

        private bool IsRight
        {
            get
            {
                if (!IsExists)
                    return false;

                int max = Math.Max(a, Math.Max(b, c));
                if (max.Equals(a)) return (b * b + c * c).Equals(a * a);
                if (max.Equals(b)) return (a * a + c * c).Equals(b * b);
                if (max.Equals(c)) return (a * a + b * b).Equals(c * c);

                return false;
            }
        }

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double GetArea()
        {
            if (!IsExists)
                return base.GetArea();

            if (IsRight)
            {
                int max = Math.Max(a, Math.Max(b, c));

                if (max.Equals(a)) return b * c / 2.0;
                if (max.Equals(b)) return a * c / 2.0;
                if (max.Equals(c)) return a * b / 2.0;
            }

            double p = (a + b + c) / 2.0;
            double space = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return space;
        }
    }
}

