using Microsoft.Azure.Amqp.Framing;
using Microsoft.Owin.BuilderProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MultiBuilding : Building
    {
        int floor;
        int Floor
        {
            get
            {
                return floor;
            }
            set 
            {
                if (value > 25)
                    floor = 25;
                else if (value < 1)
                    floor = 1;
                else 
                    floor= value;
            }
        }
        public MultiBuilding(string address, int length, int width, int height, int floor)
        :base(address, length, width, height)
            {
            this.Floor = floor;
            }

        public string Print()
        {
            string result = base.Print();
            result += $" {floor}";
            return result;
        }
    }
}
    

