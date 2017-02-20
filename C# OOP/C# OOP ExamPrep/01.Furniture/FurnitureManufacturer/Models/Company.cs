using FurnitureManufacturer.Interfaces;
using Furnitures.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    class Company : ICompany
    {
        private ICollection<IFurniture> furnitureList;
        private string name;
        private string regNumber;


        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitureList = new List<IFurniture>();
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnitureList;
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
                Validator.CheckIfStringIsNullOrEmptyOrLessThan(value, 5, "Name cannot be empty, null or with less than 5 symbols.");
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.regNumber;
            }
            private set
            {
                long useless;
                if (value.Length != 10 && long.TryParse(value, out useless) == false)
                {
                    throw new ArgumentException("Registration number must be exactly 10 symbols and must contain only digits. ");
                }
                else
                {
                    this.regNumber = value;
                }
            }
        }

        public void Add(IFurniture furniture)
        {
            furnitureList.Add(furniture);
        }

        public string Catalog()
        {
            throw new NotImplementedException();
        }

        public IFurniture Find(string model)
        {
            foreach (var furniture in furnitureList)
            {
                if (furniture.Model.ToLower() == model.ToLower())
                {
                    return furniture;
                }
            }
            return null;

        }

        public void Remove(IFurniture furniture)
        {
            furnitureList.Remove(furniture);
        }
    }
}
