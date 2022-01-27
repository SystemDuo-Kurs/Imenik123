List<Osoba> osobas = new();
bool izlaz = false;

do
{
    StampajMeni();

    Digitron.Oduzimanje(2, 3);
    Console.Write("Izbor? ");

    string izb = Console.ReadLine();
    switch (izb)
    {
        case "1":
            Unos();
            break;

        case "2":
            Ispis();
            Console.ReadKey();
            break;

        case "3":
            Brisanje();
            break;

        case "4":
            Console.WriteLine("Vozdra");
            izlaz = true;
            break;

        default:
            Console.WriteLine("Jok :/");
            break;
    }
    Console.Clear();
} while (!izlaz);

void StampajMeni()
{
    Console.WriteLine("*********************");
    Console.WriteLine("~~1. Unos osobe~~");
    Console.WriteLine("~~2. Prikaz osoba~~");
    Console.WriteLine("~~3. Brisanje~~");
    Console.WriteLine("~~4. Izlaz~~");
    Console.WriteLine("*********************");
}

void Unos()
{
    /*Osoba o = new();
    Console.Write("Unesi ime: ");
    o._ime = Console.ReadLine();
    Console.Write("Unesi prezime: ");
    o._prezime = Console.ReadLine();
    osobas.Add(o);*/
    osobas.Add(new());
    Console.Write("Unesi ime: ");
    osobas.Last()._ime = Console.ReadLine();
    Console.Write("Unesi prezime: ");
    osobas.Last()._prezime = Console.ReadLine();
}

void Ispis()
{
    int dex = 0;
    foreach (Osoba o in osobas)
    {
        Console.WriteLine($"{++dex}. {o._ime} {o._prezime}");
    }
}

void Brisanje()
{
    Console.Write("Unesite indeks: ");
    int i = int.Parse(Console.ReadLine()) - 1;

    if (i >= 0 && i < osobas.Count)
    {
        osobas.RemoveAt(i);
    }
    else
    {
        Console.WriteLine("Jooook");
        Console.ReadKey();
    }
}