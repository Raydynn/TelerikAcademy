using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Common;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private List<string> targets;

        public Machine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public double HealthPoints { get; set; }

        public string Name
        {
            get { return this.name; }
            set
            {
                Validator.CheckIfNull(name, "Name cannot be null.");
                
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }

            set
            {
                Validator.CheckIfNull(value, "Pilot cannot be null");
                pilot = value;
            }
        }

        public IList<string> Targets
        {
            get
            {
                return this.targets.AsReadOnly();
            }
        }

        public void Attack(string target)
        {
            Validator.CheckIfStringIsNullOrEmpty(target, "Target cannot be null or empty");
            this.targets.Add(target);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            var targetsAsString = this.targets.Count > 0 ?
                string.Join(", ", this.targets) :
                "None";

            result.AppendLine(string.Format("- {0}", this.name));
            result.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            result.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            result.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            result.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));
            result.AppendLine(string.Format(" *Targets: {0}", targetsAsString));
            result.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));

            return result.ToString();
        }
    }
}
