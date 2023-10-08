using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Cont
{
    private int ID_cont;
    private string nume;
    private string prenume;
    private double balanta;
    public Cont(int id_cont, string nume, string prenume, double balanta)
	{
        this.ID_cont= id_cont;
        this.nume= nume;
        this.prenume= prenume;
        this.balanta= balanta;
    }
    public void schimba_nume(string nume)
    {
        if (nume!="")
        {
            Console.WriteLine($"Nume schimbat din {this.nume} in {nume} ");
            this.nume = nume;
        }
        else
        {
            Console.WriteLine("Nume scris gresit.");
        }
    }
    public void schimba_prenume(string nume)
    {
        if (nume != "")
        {
            Console.WriteLine($"Nume schimbat din {this.prenume} in {nume} ");
            this.nume = nume;
        }
        else
        {
            Console.WriteLine("Nume scris gresit.");
        }
    }
        public void depune(double suma)
    {
        if(suma>0)
        { 
            this.balanta += suma;
            Console.WriteLine($"A fost depusa suma de {suma}. Balanta totala: {balanta}");
        }
        else
        {
            Console.WriteLine("Nu se poate depune o suma negativa.");
        }
    }
    public void retragere(double suma)
    {
        if (suma > 0)
        {
            if (suma > balanta)
                Console.WriteLine("Fonduri insuficiente.");
            else
            {
                balanta -= suma;
                Console.WriteLine($"S-a retras suma de {suma}. Balanta totala: {balanta}");
            }
        }
        else
            Console.WriteLine("Nu se poate retrage o suma negativa");
    }
    public void afisare_cont()
    {
        Console.WriteLine($"ID Cont: {ID_cont}\n Nume: {nume + " " + prenume}\nBalanta: {balanta} RON");
    }
    public void info_client()
    {
        Console.WriteLine($"ID Cont: {ID_cont} Nume: {nume + " " + prenume} Balanta: {balanta} RON");
    }
}
public class Banca
{
    public string nume{ get; set; }
    public List<Cont> conturi { get; set; }
    public Banca(string nume) { this.nume= nume; this.conturi = new List<Cont>(); }
    public void adaugaClient() {
        int ID_Client;
        ID_Client = conturi.Count + 1;
        string nume_aux;
        double balanta_aux;
        string prenume_aux;

        Console.WriteLine("Nume client:");
        nume_aux=Console.ReadLine();
        Console.WriteLine("Prenume client:");
        prenume_aux=Console.ReadLine();
        Console.WriteLine("Balanta: ");
        balanta_aux=int.Parse(Console.ReadLine());
        conturi.Add(new Cont(ID_Client, nume_aux, prenume_aux, balanta_aux));
    }
}