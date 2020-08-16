using System;

namespace _1_intro
{
    class Triangulo {
        public double A;
        public double B;
        public double C;

        public double Area(){
            double p = (A + B + C) / 2;
            double Area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return Area;
        }
        
    }
}
