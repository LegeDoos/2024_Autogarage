using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_Autogarage.BusinessLayer
{
    /// <summary>
    /// Represents the vehicle
    /// </summary>
    public class Vehicle
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        
        /// <summary>
        /// The license plate of the vehicle
        /// </summary>
        public string LicencePlate { get; set; }

        public CarOwner CarOwner{ get; set; }

        public Vehicle(string licencePlate)
        {
            LicencePlate = licencePlate;
        }

        /// <summary>
        /// Check the length of the license plate
        /// (requirement V3)
        /// </summary>
        /// <returns>AAA true if the license plate is correct</returns>
        public bool CheckLicensePlate()
        {
            if (LicencePlate.Length != 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        // data access methods

        public void Create()
        {
            if (CheckLicensePlate())
            {
                // ga naar de DAL en maak aan
            }
            else
            {
                // geef een foutmelding
            }
        }
    }
}
