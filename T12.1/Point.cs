using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T12._1
{
    class Point
    {
        /// <summary>
        /// Fields
        /// </summary>
        public int x; public int y;
        /// <summary>
        /// Constructor
        /// </summary>
        public Point() { }
        public Point(int x, int y)
        {
            this.x = x; this.y = y;
        }
        /// <summary>
        /// Output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"x = {x}\ty = {y}";
        }
        /// <summary>
        /// Count distance
        /// </summary>
        /// <returns></returns>
        public double Distance()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }


    }
}
