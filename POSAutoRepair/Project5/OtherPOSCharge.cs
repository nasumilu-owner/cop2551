using System;

namespace Project5
{
    /// <summary>
    /// Simple list item the implements the POSCharge interface
    /// </summary>
    class OtherPOSCharge : POSCharge
    {
        private String name;
        private double labor;
        private double parts;

        /// <summary>
        /// Default construct. Pretty much an empty Charge
        /// </summary>
        public OtherPOSCharge() : this(String.Empty, 0.0, 0.0) { }
        /// <summary>
        /// Constructs a POSCharge with a name and 0.0 cost.
        /// </summary>
        /// <param name="name"></param>
        public OtherPOSCharge(String name) : this(name, 0.0, 0.0) {}

        /// <summary>
        /// Constructs a POSCharge with a name, labor and parts cost.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="labor"></param>
        /// <param name="parts"></param>
        public OtherPOSCharge(String name, double labor, double parts)
        {
            this.name = name;
            this.labor = labor;
            this.parts = parts;
        }

        /// <summary>
        /// Getter/Setter for the service name.
        /// </summary>
        public String Name
        {
            get => this.name;
            set => this.name = value;
        }

        /// <summary>
        /// Getter/Setter for the service labor charge.
        /// </summary>
        public double LaborCharge
        {
            get => this.labor;
            set => this.labor = value;
        }

        /// <summary>
        /// Getter/Setter for the service parts charge.
        /// </summary>
        public double PartsCharge
        {
            get => this.parts;
            set => this.parts = value;
        }

        /// <summary>
        /// Gets the total service charege
        /// </summary>
        public double Charge
        {
            get => this.PartsCharge + this.LaborCharge;
        }

        /// <summary>
        /// Clears the service charge.
        /// 
        /// Set the LaborCharge & PartsCharge equal to 0.0
        /// </summary>
        public void ClearCharge()
        {
            this.labor = 0.0;
            this.parts = 0.0;
        }

        /// <summary>
        /// Override the Object.ToString() method to better display this in
        /// the ListBox control.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.name}: Labor;{this.LaborCharge:C2}; Parts;{this.PartsCharge:C2}";
        }
    }
}
