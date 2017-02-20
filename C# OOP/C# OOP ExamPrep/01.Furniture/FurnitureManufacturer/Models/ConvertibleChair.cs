using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted = false;


        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs) 
            : base(model, materialType, price, height, numberOfLegs)
        {

        }

        public bool IsConverted
        {
            get
            {
                return isConverted;
            }
        }

        public override decimal Height
        {
            get
            {
                if (isConverted == true)
                {
                    return 0.10m;
                }
                else
                {
                    return base.Height;
                }
            }

            protected set
            {
                base.Height = value;
            }
        }

        public void Convert()
        {
            this.isConverted = !this.isConverted;
        }
    }
}
