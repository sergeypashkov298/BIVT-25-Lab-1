﻿namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a > 0 && b > 0) || (a < 0 && b < 0))
                answer = true;
            // end

                return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (d != Math.Round(d))
                answer = true;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if ((double)a%b==0)
                answer = true;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if ((Math.Abs(d) > Math.Abs(f)) && (Math.Abs(d) > Math.Abs(g)))
                answer = d;
            if ((Math.Abs(f) > Math.Abs(g)) && (Math.Abs(f) > Math.Abs(d)))
                answer = f;
            if ((Math.Abs(g) > Math.Abs(d)) && (Math.Abs(g) > Math.Abs(f)))
                answer = g;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
                answer = 0;
            else if ((x > -1) && (x <= 0))
                answer = x + 1;
            else
                answer = 1;
                // end

                return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            if (Math.Sqrt(squareS)>=2*Math.Sqrt((circleS/Math.PI)))
                answer = true;
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0)
                    answer = -1;
            }
            else
            {
                if (f > 0)
                {
                    answer = 1;
                }
                else
                {
                    return answer;
                }
            }
            // end

                return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            
            // end

            return answer;
        }
    }
}