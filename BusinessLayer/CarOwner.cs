using _2024_Autogarage.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_Autogarage.BusinessLayer
{
    public class CarOwner
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Vehicle> Vehicles { get; set; } = [];

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public CarOwner(string name)
        {
            Name = name;
        }

        // data access methods

        public void Create()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }

        public static List<CarOwner> GetAll()
        {
            // ga naar de dal en haal op
            DAL dal = new DAL();

            List<CarOwner> carOwners;
            carOwners = dal.GetAllCarowners();

            // checks

            return carOwners;
        }

        public static CarOwner GetById(int id)
        {
            // ga naar de dal en haal deze op
            return null;
        }

    }
}
