using OOP.Constructions.DTO;
using OOP.Constructions.Models;
using OOP.IndustrialHall;
using OOP.ResidentalBuilding;
using OOPLab2.Constructions;
var construction1 = new Construction();
var construction2 = new Construction(20.0f, 40.5f, 4,4, BuildMaterialEnum.Wood);
var construction3 = new Construction(
    new CreateConstructionDTO()
    {
        BuildMaterial = BuildMaterialEnum.Wood,
    });
Console.WriteLine(construction2.Height);
Console.WriteLine(construction2.Width);
Console.WriteLine(construction2.HumanCapacity);
Console.WriteLine(construction2.Entrances);
Console.WriteLine(construction2.BuildMaterial);

Console.WriteLine(construction1.Height);
Console.WriteLine(construction1.Width);
Console.WriteLine(construction1.HumanCapacity);
Console.WriteLine(construction1.Entrances);
Console.WriteLine(construction1.BuildMaterial);

Console.WriteLine(construction3.Height);
Console.WriteLine(construction3.Width);
Console.WriteLine(construction3.Entrances);
Console.WriteLine(construction3.BuildMaterial);
Console.WriteLine(construction1.getSquareCost());

var resbuild = new ResidentialBuilding();
var inhall = new IndustrialHall();
Console.WriteLine(resbuild.Height);
Console.WriteLine(inhall.Width);

