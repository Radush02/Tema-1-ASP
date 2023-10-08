using System;
using System.Collections.Generic;


class ASP_Tema1
{
    static void Main()
    {
        int i = 0;
        List<Banca> banci = new List<Banca>();
        banci.Add(new Banca("Banca Transilvania"));
        banci.Add(new Banca("Banca Comerciala Romana"));
        int opt;
        Console.WriteLine("Bine ati venit. Alegeti banca pe care doriti sa faceti operatiuni:");
        foreach(Banca b in banci)
        {
            Console.WriteLine($"Banca {++i}) {b.nume}");
        }
        i = 0;
        int bc = int.Parse(Console.ReadLine())-1;

        bool in_curs = true;
        while (in_curs)
        {
            Console.WriteLine("Alegeti operatiunea: 1) Adauga client 2)Afisare clienti 3) Verificare sold client 4) Depunere bani client 5) Retragere bani client 6)Schimbare banca");
            opt = int.Parse(Console.ReadLine())-1;
            switch (opt)
            {
                case 0:
                    banci[bc].adaugaClient();
                    break;
                case 1:
                    foreach (Cont c in banci[bc].conturi)
                    { c.info_client(); }
                    break;
                case 2:
                    Console.Write("Introduceti ID client: ");
                    int nr = int.Parse(Console.ReadLine());
                    try
                    {
                        banci[bc].conturi[nr - 1].afisare_cont();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Nu exista acel client.");
                    }
                    break;
                case 3:
                    Console.Write("Introduceti ID client: ");
                    int nr2 = int.Parse(Console.ReadLine());
                    try
                    {
                        Console.Write("Introduceti suma: ");
                        double suma = double.Parse(Console.ReadLine());
                        banci[bc].conturi[nr2 - 1].depune(suma);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Nu exista acel client.");
                    }
                    break;
                case 4:
                    Console.Write("Introduceti ID client: ");
                    int nr3 = int.Parse(Console.ReadLine());
                    try
                    {
                        Console.Write("Introduceti suma: ");
                        double suma = double.Parse(Console.ReadLine());
                        banci[bc].conturi[nr3 - 1].retragere(suma);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Nu exista acel client.");
                    }
                    break;
                case 5:
                    foreach (Banca b in banci)
                        Console.WriteLine($"Banca {++i}) {b.nume}");
                    i = 0;
                    Console.Write("Introduceti ID banca: ");
                    bc = int.Parse(Console.ReadLine());
                    if (bc > banci.Count)
                        in_curs = false;
           
                    break;
                default:
                    in_curs = false;
                    break;
            }
        }

    }
}