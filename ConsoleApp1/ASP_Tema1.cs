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
        Console.WriteLine("Alegeti operatiunea: 1)Afisare clienti 2) Verificare sold client 3) Depunere bani client 4) Retragere bani client");
        opt=int.Parse(Console.ReadLine());
        bool in_curs = false;
        switch (opt)
        {
            case 1:
                foreach (Cont c in banci[bc].conturi)
                    c.info_client();
                break;
            case 2:
                Console.WriteLine("Introduceti ID client");
                int nr = int.Parse(Console.ReadLine());
                try {
                    banci[bc].conturi[nr - 1].afisare_cont();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Nu exista acel client.");
                }
                break;
            default:
                Console.WriteLine("Nu exista aceasta banca. Doriti sa o creati?");
                break;
        }

    }
}