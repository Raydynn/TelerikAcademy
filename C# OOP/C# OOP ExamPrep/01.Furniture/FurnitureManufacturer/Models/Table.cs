using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    class Table : Furniture, ITable, IFurniture
    {
        public Table(string model, string materialType, decimal price, decimal height, decimal length, decimal width) 
            :base(model, materialType, price, height)
        {
            Length = length;
            Width = width;
        }

        public decimal Width { get; private set; }

        public decimal Length { get; private set; }

        public decimal Area
        {
            get
            {
                return this.Length * this.Width;
            }
        }
    }
}
