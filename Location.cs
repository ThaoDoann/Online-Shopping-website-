using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaoDoanAssignment1
{
    class Location
    {
        public Location()
        {
        }
        public Location(int y, int x)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public bool IsLocValid(int x, int y)
        {
            bool isValid = true;
            if (y >= 0 && x >= 0 && y < 8 && x < 8)
                isValid = false;

            return isValid;
        }
    }
}











