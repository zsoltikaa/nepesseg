using System.Text;

const string path = "C:\\Users\\zsolt\\source\\repos\\nepesseg\\src\\adatok-utf8.txt";

List<Orszag> orszagok = [];

using (StreamReader sr = new(path, Encoding.UTF8))
{

    _ = sr.ReadLine();

    while (!sr.EndOfStream)
    {
        var s = sr.ReadLine().Split(';');
        orszagok.Add(new(
            orszagnev: s[0],
            terulet: int.Parse(s[1]),
            nepesseg: s[2][^1] == 'g'
                ? int.Parse(s[2][..^1]) * 10000
                : int.Parse(s[2]),
            fovaros: s[3],
            fovarosNepesseg: int.Parse(s[4]) * 1000));
    }

}

Console.WriteLine("4. feladat:");
Console.WriteLine($"a beolvasott orszagok szama: {orszagok.Count}");

Console.WriteLine("\n5. feladat:");
var f5 = orszagok.Single(o => o.Orszagnev == "Kína").Nepsuruseg;
Console.WriteLine($"Kina nepsurusege: {f5} fo/km^2");

Console.WriteLine("\n6. feladat:");
var f6 = orszagok.Single(o => o.Orszagnev == "Kína").Nepesseg
    - orszagok.Single(o => o.Orszagnev == "India").Nepesseg;
Console.WriteLine($"Kinaban {f6 / 1000000f:0.00} millio fovel eltek tobben, mint Indiaban.");

Console.WriteLine($"\n7. feladat");
var f7 = orszagok.OrderByDescending(o => o.Nepesseg).ToArray()[2];
Console.WriteLine($"A harmadik legnepesebb orszag: {f7.Orszagnev}, lakossaga: {f7.Nepesseg / 1000000f:0.00} millio fo");

Console.Write("\n8. feladat: - ");
Console.WriteLine("a kovetkezo orszagok lakossaganak tm 30%-a a fovarosban lakik:");
var f8 = orszagok.Where(o => o.Koncentralt).OrderBy(o => o.Orszagnev);
foreach (var o in f8) Console.WriteLine($"\t{o.Orszagnev} ({o.Fovaros})");