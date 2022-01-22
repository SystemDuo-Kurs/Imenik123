bool izlaz = false;
List<string> Imena = new();

do
{
    StampajMeni();
    Console.Write("Izbor? ");
    string izb = Console.ReadLine();
    switch (izb)
    {
        case "1":
            Console.Write("Unesi ime: ");
            Imena.Add(Console.ReadLine());
            break;

        case "2":
            for (int indeks = 0; indeks < Imena.Count; indeks++)
            {
                Console.WriteLine($"{indeks + 1}. {Imena[indeks]}");
            }
            Console.WriteLine("=====================");
            foreach (string ime in Imena)
            {
                Console.WriteLine(ime);
            }

            int index = 0;
            while (index < Imena.Count)
            {
                Console.WriteLine($"{index + 1}. {Imena[index]}");
                index++;
            }
            Console.ReadKey();
            break;

        case "3":
            if (Imena.Remove(Console.ReadLine()))
            {
                Console.WriteLine("Uspesno obrisan");
            }
            else
            {
                Console.WriteLine("Jok");
            }
            Imena.RemoveAt(2);
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