using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    class Chair : Furniture, IChair, IFurniture
    {
        public Chair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            :base(model, materialType, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs { get; protected set; }
    }
}
