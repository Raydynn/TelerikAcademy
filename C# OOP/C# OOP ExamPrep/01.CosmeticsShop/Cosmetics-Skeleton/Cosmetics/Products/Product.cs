using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    public abstract class Product : IProduct
    {
        private string brand;
        private GenderType gender;
        private string name;
        private decimal price;

        public Product(string brand, GenderType gender, string name, decimal price)
        {
            this.brand = brand;
            this.gender = gender;
            this.name = name;
            this.price = price;
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, 10, 2, "Product brand must be between 2 and 10 symbols long!");
                this.brand = value;
            }
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
            private set
            {
                this.gender = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, 10, 3, "Product brand must be between 3 and 10 symbols long!");
                this.name = value;
            }
        }
        public decimal Price { get; private set; }

        public string Print()
        {
            throw new NotImplementedException();
        }
    }
}
