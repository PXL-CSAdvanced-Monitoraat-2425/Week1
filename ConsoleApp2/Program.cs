using ConsoleApp2;

Console.Write("Geef naam driver: ");
string driverNaam = Console.ReadLine();
Console.Write("Leeftijd: ");
int leeftijd = int.Parse(Console.ReadLine());
Console.Write("Geef merk auto: ");
string merk = Console.ReadLine();
Console.Write("Geef nummerplaat: ");
string nrPlaat = Console.ReadLine();

Driver driverke = new Driver(driverNaam, leeftijd, merk, nrPlaat);
//driverke.Naam = driverNaam;
//driverke.Leeftijd = leeftijd;

PrintDetails(driverke);


void PrintDetails(Driver chauffeur)
{
    Console.WriteLine("Samenvatting");
    Console.WriteLine($"Chauffeur {chauffeur.Naam} ({chauffeur.Leeftijd}) bestuurt auto {chauffeur.MijnAuto.Brand} met nrplaat {chauffeur.MijnAuto.LicensePlate}");
    Console.WriteLine($"Naamkaartje: {chauffeur}");
}