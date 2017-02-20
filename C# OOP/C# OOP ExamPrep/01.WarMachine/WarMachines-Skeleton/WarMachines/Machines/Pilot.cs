using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Common;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> machines;

        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfNull(name, "Name cannot be Null.");
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            Validator.CheckIfNull(machine, "Machine cannot be added to pilot");
            
            this.machines.Add(machine);
        }

        public string Report()
        {
            var sortedMachines = this.machines
                .OrderBy(m => m.HealthPoints)
                .ThenBy(m => m.Name);

            var result = new StringBuilder();

            var noMachinesMaybe =
                this.machines.Count > 0
                ? this.machines.Count.ToString()
                : "no";

            var pluralMachinesMaybe =
                this.machines.Count == 1
                ? "machine"
                : "machines";

            result.AppendLine(string.Format("{0} - {1} {2}", this.Name, noMachinesMaybe, pluralMachinesMaybe));

            foreach (var machine in sortedMachines)
            {
                result.AppendLine(machine.ToString());
            }

            return result.ToString().Trim();
        }

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }
    }
}
