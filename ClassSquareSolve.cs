using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExample
{
    public class ClassSquareSolve
    {
        public string x1(int a, int b, int c)
        {
            double D;
            D = b * b - 4 * a * c;
            if(D >= 0)
                return Math.Round((-b + Math.Sqrt(D))/(2*a),2).ToString();
            return "Действительных корней нет";
        }
        public string x2(int a, int b, int c)
        {
            double D;
            D = b * b - 4 * a * c;
            if (D >= 0)
                return Math.Round((-b - Math.Sqrt(D)) / (2 * a), 2).ToString();
            return "Действительных корней нет";
        }
    }
}
