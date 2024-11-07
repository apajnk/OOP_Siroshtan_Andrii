using OOPLab2.Constructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ResidentalBuilding
{
    internal class ResidentialBuilding : Construction
    {
        public ResidentialBuilding()
        {
        }

        public ResidentialBuilding(int numberOffFloors) 
        {
            NumberOffFloors = numberOffFloors;
        }

        public float NumberOffFloors { get; set; }
    }
}
