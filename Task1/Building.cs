using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Building
    {
        string address;
        int length;
        int width;
        int height;

        int Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 1000)
                    length = 1000;
                else if (value < 30)
                    length = 1000;
                else
                    length = value;
            }
        }
        int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 18)
                    width = 18;
                else if (value < 10)
                    width = 10;
                else
                    width = value;
            }
        }
        int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 75)
                    height = 75;
                else if (value < 4)
                    height = 4;
                else
                    height = value;
            }
        }
        public Building(string address, int length, int width, int height)
        {
            this.address = address;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public string Print()
        {
            return $" {address} {length} {width} {height}";
        }
    }
}
