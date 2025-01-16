﻿using System.Security.Cryptography.X509Certificates;

class Orszag
{
    public string Orszagnev { get; private set; }
    public int Terulet { get; private set; }
    public int Nepesseg { get; private set; }
    public string Fovaros { get; private set; }
    public int FovarosNepesseg { get; private set; }

    public int Nepsuruseg => (int)Math.Round(Nepesseg / (float)Terulet);

    public bool Koncentralt => FovarosNepesseg > Nepesseg * 3;

    public Orszag(string orszagnev, int terulet, int nepesseg, string fovaros, int fovarosNepesseg)
    {
        Orszagnev = orszagnev;
        Terulet = terulet;
        Nepesseg = nepesseg;
        Fovaros = fovaros;
        FovarosNepesseg = fovarosNepesseg;
    }

    public Orszag(string sor)
    {
        // Ebben a konstruktorban is elvégezheti az adatsor felbontását!
        // Ha nem ezt választja, akkor törölje ezt a konstruktort!
    }

    public override string ToString()
    {
        return "";
    }
}
