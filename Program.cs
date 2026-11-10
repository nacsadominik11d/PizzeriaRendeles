using PizzeriaRendeles;

List<Rendeles> Rendelesek = new List<Rendeles>();

string[] beolvas = File.ReadAllLines("rendelesek.txt");

foreach (string sor in beolvas)
{
    Rendeles peldany = new Rendeles(sor);
    Rendelesek.Add(peldany);
    Console.WriteLine(peldany);
}
