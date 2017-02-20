using FurnitureManufacturer.Interfaces;
using Furnitures.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public abstract class Furniture : IFurniture
    {
        private string model;
        private decimal price;
        private decimal height;

        public Furniture(string model, string materialType, decimal price, decimal height)
        {
            this.model = model;
            this.Material = materialType;
            this.price = price;
            this.height = height;
        }

        public virtual decimal Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                Validator.CheckIfDecLessThanZero(value, "Height cannot be zero or less meters");

                this.height = value;
            }
        }

        public virtual string Material { get; protected set; }
        

        public virtual string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Model cannot be null or empty");
                if (value.Length < 3)
                {
                    throw new InvalidOperationException("Model should be longer than 3 symbols");
                }
                this.model = value;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                Validator.CheckIfDecLessThanZero(value, "Price cannot be zero or less");
                this.price = value;
            }
        }
    }
}
