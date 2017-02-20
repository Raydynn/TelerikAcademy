using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Tank : Machine, ITank
    {
        private const int healthPoints = 100;
        private const int defenseChange = 30;
        private const int attackChange = 40;

        private bool defenseMode = false;

        public Tank(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints, healthPoints)
        {
            ToggleDefenseMode();
        }

        public bool DefenseMode
        {
            get
            {
                return defenseMode;
            }
        }

        public void ToggleDefenseMode()
        {
            
            defenseMode = !defenseMode;

            if (defenseMode == true)
            {
                this.AttackPoints -= attackChange;
                this.DefensePoints += defenseChange;
            }
            else
            {
                this.AttackPoints += attackChange;
                this.DefensePoints -= defenseChange;
            }
        }

        public override string ToString()
        {
            var baseString = base.ToString();

            var result = new StringBuilder();
            result.Append(baseString);
            result.Append(string.Format(" *Defense: {0}", this.defenseMode ? "ON" : "OFF"));

            return result.ToString();
        }
    }
}
