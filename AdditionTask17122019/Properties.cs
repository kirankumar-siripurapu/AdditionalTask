using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask17122019
{
    class Properties
    {
        // direct assigment
        private int length, width, height=30, volume;

        //using set and get accesories
        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (this.length < 0)
                {
                    throw new Exception(" The value of length cannot be negative");

                }
                this.length = value;
            }
        }

        //using encapsulation
        public void Width(int width)
        {
                if (width < 0)
                {
                    throw new Exception(" The value of length cannot be negative");

                }
                this.width = width;
        }
        public int GetHeight()
        {
            return this.height;
        }
        public int Volume
        {
            get
            {
                return this.volume;
            }
            set
            {
                this.volume = value;
            }
         
        }

        public void VolumeResult()
        {
            this.volume = this.length * this.width * this.height;
        }
        public int Depth { get; set; }

    }
}
