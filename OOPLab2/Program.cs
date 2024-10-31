using OOP.Constructions.DTO;
using OOPLab2.Constructions;
var construction1 = new Construction();
var construction2 = new Construction(20.0f, 40.5f, 4,4, "Wood");
var construction3 = new Construction(
    new CreateConstructionDTO()
    {
        Width = float.NaN,
        Height = float.NaN,
        
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


