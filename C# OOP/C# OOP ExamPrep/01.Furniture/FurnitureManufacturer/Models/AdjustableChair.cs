﻿using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    class AdjustableChair : Chair, IAdjustableChair, IChair, IFurniture
    {
        public void SetHeight(decimal height)
        {
            this.Height = height;
        }

        public AdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            :base(model, materialType, price, height, numberOfLegs)
        {
            
        }
    }
}
