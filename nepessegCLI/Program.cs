using System.Text;

const string path = "H:\\c#\\forms apps\\nepesseg\\nepessegCLI\\src\\adatok-utf8.txt";

List<Orszag> orszagok = [];

using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
{

    _ = reader.ReadLine();

    // while there are still lines to read in the file
    while (!reader.EndOfStream)
    {
        // read the next line and split it by commas
        var s = reader.ReadLine()?.Split(',');

        // if the line has exactly 5 elements, proceed
        if (s?.Length == 5)
            // add a new Orszag (country) object to the list, using the data from the line
            orszagok.Add(new Orszag(
                s[0], // first element: country name
                int.Parse(s[1]), // second element: population, parsed as an integer
                                 // third element: population density, handle special case where the string ends with "g"
                s[2].EndsWith("g") ? int.Parse(s[2].Substring(0, s[2].Length - 1)) * 10000 : int.Parse(s[2]),
                s[3], // fourth element: region
                int.Parse(s[4]) * 1000 // fifth element: area, converted to square meters by multiplying by 1000
            ));
    }

}

Console.WriteLine("4. feladat: ");
Console.WriteLine($"A beolvasott orszagok szama: {orszagok.Count} ");

Console.WriteLine("\n5. feladat: ");
var f5 = orszagok.Single(o => o.Orszagnev == "Kína").Nepsuruseg;
Console.WriteLine($"Kína nepsurusege: {f5} fo/km2 ");

Console.WriteLine("\n6. feladat: ");
var f6 = (float)orszagok.Single(o => o.Orszagnev == "Kína").Nepesseg - orszagok.Single(o => o.Orszagnev == "India").Nepesseg;
Console.WriteLine($"Kínában {f6/1000000:0.00} millio fovel eltek tobben, mint Indiaban. ");

Console.WriteLine("\n7. feladat: ");
var f7 = orszagok.OrderByDescending(o => o.Nepesseg).ToArray()[2];
Console.WriteLine($"A harmadik legnepesebb orszag: {f7.Orszagnev}, lakossaga: {f7.Nepesseg/1000000f:0.00} millio fo ");

Console.WriteLine("\n8. feladat: ");
Console.WriteLine("A kovetkezo orszagok lakossaganak tobb, mint 30%-a a fovarosban lakik: ");
var f8 = orszagok.Where(o => o.Koncentralt);
foreach (var o in f8)
{
    Console.WriteLine($"\t{o.Orszagnev} ({o.Fovaros})");
}