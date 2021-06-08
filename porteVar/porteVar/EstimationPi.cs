using System;
using System.Collections.Generic;
using System.Text;

namespace porteVar
{
    // class Pint
    class Point
    {
        public double x,y;
    }

    class EstimationPi
    {
        public static double Approx(Point[] pts)
        {
            int nbPIn = 0;
            for (int i = 0; i < pts.Length; i++)
            {
                if (pts[i].x * pts[i].x + pts[i].y * pts[i].y <= 1)
                {
                    nbPIn++;
                }
            }
            double prob = (double)nbPIn / pts.Length;
            return prob * 4;

        }
}
}
