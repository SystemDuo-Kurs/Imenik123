using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Osoba
{
    public string _ime = String.Empty;
    public string _prezime = String.Empty;
}

public static class Digitron
{
    public static int Sabiranje(int x, int y)
    {
        return x + y;
    }

    public static int Oduzimanje(int x, int y)
    {
        return x - y;
    }
}