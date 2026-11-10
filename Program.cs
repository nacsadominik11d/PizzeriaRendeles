using PizzeriaRendeles;

List<Rendeles> Rendelesek = new List<Rendeles>();

string[] beolvas = File.ReadAllLines("rendelesek.txt");

Console.WriteLine($" Napi Rendelések:");

foreach (string sor in beolvas)
{
    Rendeles peldany = new Rendeles(sor);
    Rendelesek.Add(peldany);
    Console.WriteLine(peldany);
}
Console.WriteLine($"Statisztika:");
int bevetel = Rendelesek.Sum(x => x.FizetendoDij());
bevetel = 0;
foreach (Rendeles aktualis in Rendelesek)
{
    bevetel += aktualis.PizzakSzama * 2500 + aktualis.TavolsagKm * 300; ;
}
Console.WriteLine($"Pizzéria teljes napi bevétele: {bevetel} Ft");
Rendeles leg = Rendelesek.MaxBy(x => x.PizzakSzama);
Console.WriteLine($"Legtöbb pizzát rendelő vásárló: {leg.VevoNev} ({leg.PizzakSzama} db)");
