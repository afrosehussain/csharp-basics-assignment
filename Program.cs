// See https://aka.ms/new-console-template for more information
using BuildingAHouse;
using BuildingAHouse.Workers;

Owner owner = new Owner("Afrose","Nuzvid","6457428899");
Console.WriteLine(owner.GetName());
Console.WriteLine(owner.GetMobileNo());
owner.GetDetails();
owner.UpdateAddress("Hyderabad");
Console.WriteLine("\n");

Mason mason = new Mason("Raju", "8745632199");
Console.WriteLine(mason.GetName());
Console.WriteLine(mason.GetMobileNo());
mason.GettingPaidByOwner();
mason.Working();
mason.UsesCement();
mason.UsesWater();

Console.WriteLine("\n");

TileLayer tileLayer = new TileLayer("Kaju", "6985471245");
Console.WriteLine(tileLayer.GetName());
Console.WriteLine(tileLayer.GetMobileNo());
tileLayer.GettingPaidByOwner();
tileLayer.Working();
tileLayer.UsesCement();
tileLayer.UsesWater();

Console.WriteLine("\n");

Painter painter = new Painter("Vasu", "632547896");
Console.WriteLine(painter.GetName());
Console.WriteLine(painter.GetMobileNo());
painter.GettingPaidByOwner();
painter.Working();
painter.UsesWater();

Console.WriteLine("\n");

Worker plumber = new Plumber("Ramu", "9632587412");
Console.WriteLine(plumber.GetName());
Console.WriteLine(plumber.GetMobileNo());
plumber.GettingPaidByOwner();
plumber.Working();
plumber.UsesWater();

Console.WriteLine("\n");

Worker electrician = new Electrician("Balu", "9988652379");
Console.WriteLine(electrician.GetName());
Console.WriteLine(electrician.GetMobileNo());
electrician.GettingPaidByOwner();
electrician.Working();
electrician.UsesWater();

