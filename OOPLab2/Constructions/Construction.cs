using OOP.Constructions.DTO;
using OOP.Constructions.Models;
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
            Height = 11;
            Width = 113;
            Entrances = 1;
            HumanCapacity = 3;
            BuildMaterial = BuildMaterialEnum.Concrete;
        }

        public Construction(CreateConstructionDTO construction)
        {
            Height = construction.Height;
            Width = construction.Width;
            Entrances = construction.Entrances;
            HumanCapacity = 3;
            BuildMaterial = construction.BuildMaterial;
        }

        public Construction(float hight, float width, int entrances, int humancapacity, BuildMaterialEnum buildmaterial)
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
        private BuildMaterialEnum? _buildMaterial { get; set; }
        public BuildMaterialEnum? BuildMaterial
        {
            get
            {
                return _buildMaterial;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Value can not be null");
                }
                _buildMaterial = value;
            }
        }
        public float getSquareCost()
        {
            if (BuildMaterial == BuildMaterialEnum.Concrete)
            {
                return 0.87f * Height * Width * 0.9f;
            }
            else if (BuildMaterial == BuildMaterialEnum.Brik)
            {
                return 0.8f * Height * Width * 0.9f;
            }
            return 0.78f * Height * Width * 0.9f;
        }

    }
}
//1. Height typu zmiennoprzecinkowego
//2. Width typu zmiennoprzecinkowego
//3. Entrances typu liczba całkowita
//4. HumanCapacity typu liczba całkowita
//5. BuildMaterial typu tekstowego


