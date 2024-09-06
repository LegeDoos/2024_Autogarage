using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_Autogarage.BusinessLayer
{
    public class CommercialVehicle : Vehicle
    {

        /// <summary>
        /// Towing weight in kg
        /// </summary>
        public int TowingWeightKg { get; set; }

        public CommercialVehicle(string licencePlate, int towingWeight) 
            : base(licencePlate)
        {
            TowingWeightKg = towingWeight;
        }
    }
}
