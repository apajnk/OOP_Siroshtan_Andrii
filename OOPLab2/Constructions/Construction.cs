using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2.Constructions
{
    internal class Construction
    {
        public Construction()
        {
            
        }
        public Construction(float hight, float width, int entrances, int humancapacity, string buildmaterial) 
        {
            Height = hight; 
            Width = width;  
            Entrances = entrances; 
            HumanCapacity = humancapacity; 
            BuildMaterial = buildmaterial;
        }
        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public string BuildMaterial { get; set; }
    }
}
//1. Height typu zmiennoprzecinkowego
//2. Width typu zmiennoprzecinkowego
//3. Entrances typu liczba całkowita
//4. HumanCapacity typu liczba całkowita
//5. BuildMaterial typu tekstowego

