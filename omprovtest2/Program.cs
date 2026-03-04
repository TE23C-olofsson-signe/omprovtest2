using System.Net.Sockets;
using omprovtest2;

List<string> Villains = [];

Villains.Add("DarthVader");
Villains.Add("Magneto");

Console.WriteLine("skriv ett nummer på lektioner");

bool success = false;
string lesson = "";
int sum = 0;

while (!success)
{
    lesson = Console.ReadLine();
    int.TryParse(lesson, out sum);
    if (sum > 0)
    {
        Console.WriteLine($"Du får {sum} lektoner i teori och körning");
        success = true;
    }
    else
    {
        Console.WriteLine("Skriv ett tal högre än 0");
    }
}
int a = 0;
DarthVader le = new();
Magneto ri = new();

while (a != sum)
{

    le.LearnTheory();
    le.LearnDriving();


    ri.LearnTheory();
    ri.LearnDriving();
    ++a;

}
le.TakeTest();
ri.TakeTest();


Console.ReadLine();