using System;
using System.Collections.Generic;
using System.Linq;

public class Avtomobil
{
    public string IshlabChiqaruvchi { get; set; }
    public string Model { get; set; }
    public string Rangi { get; set; }
    public decimal Narxi { get; set; }

    public Avtomobil(string ishlabChiqaruvchi, string model, string rangi, decimal narxi)
    {
        IshlabChiqaruvchi = ishlabChiqaruvchi;
        Model = model;
        Rangi = rangi;
        Narxi = narxi;
    }
}

public class Program
{
    public static void Main()
    {
        List<Avtomobil> avtomobillar = new List<Avtomobil>
        {
            new Avtomobil("Chevrolet", "Cobalt", "Oq", 10000),
            new Avtomobil("Chevrolet", "Malibu", "Qora", 15000),
            new Avtomobil("Toyota", "Camry", "Oq", 12000),
            new Avtomobil("Honda", "Civic", "Qizil", 8000),
            new Avtomobil("Ford", "Focus", "Qora", 7000),
            new Avtomobil("BMW", "X5", "Oq", 20000),
            new Avtomobil("Audi", "A4", "Moviy", 9000),
            new Avtomobil("Mercedes", "C-Class", "Qora", 18000),
            new Avtomobil("Hyundai", "Elantra", "Oq", 11000),
            new Avtomobil("Kia", "Optima", "Yashil", 6000)
        };

        while (true)
        {
            Console.WriteLine("\nTanlovingizni kiriting:");
            Console.WriteLine("1 - Barcha avtomobillar ro'yxati");
            Console.WriteLine("2 - Mashina rangini tanlash");
            Console.WriteLine("3 - Narxi 6000$ dan qimmmat va 12000$ dan arzon bo'lgan avtomobillar ro'yxati");
            Console.WriteLine("0 - Chiqish");

            int tanlov = int.Parse(Console.ReadLine());

            switch (tanlov)
            {
                case 1:
                    BarchaAvtomobillar(avtomobillar);
                    break;
                case 2:
                    OqQoraAvtomobillar(avtomobillar);
                    break;
                case 3:
                    NarxOraliqdagiAvtomobillar(avtomobillar, 6000, 12000);
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Noto'g'ri tanlov. Iltimos, qayta urinib ko'ring.");
                    break;
            }
        }
    }

    public static void BarchaAvtomobillar(List<Avtomobil> avtomobillar)
    {
        Console.WriteLine("Barcha avtomobillar:");
        foreach (var avtomobil in avtomobillar)
        {
            Console.WriteLine($"{avtomobil.IshlabChiqaruvchi} {avtomobil.Model} - {avtomobil.Rangi} - {avtomobil.Narxi}$");
        }
    }

    public static void OqQoraAvtomobillar(List<Avtomobil> avtomobillar)
    {
        var oqQoraAvtomobillar = avtomobillar.Where(a => a.Rangi == "Oq" || a.Rangi == "Qora").ToList();
        Console.WriteLine("Oq va Qora avtomobillar:");
        foreach (var avtomobil in oqQoraAvtomobillar)
        {
            Console.WriteLine($"{avtomobil.IshlabChiqaruvchi} {avtomobil.Model} - {avtomobil.Rangi} - {avtomobil.Narxi}$");
        }
    }

    public static void NarxOraliqdagiAvtomobillar(List<Avtomobil> avtomobillar, decimal startPrice, decimal endPrice)
    {
        var narxOraliqdagiAvtomobillar = avtomobillar.Where(a => a.Narxi > startPrice && a.Narxi < endPrice).ToList();
        Console.WriteLine("\nNarxi 6000$ dan qimmmat va 12000$ dan arzon bo'lgan avtomobillar:");
        foreach (var avtomobil in narxOraliqdagiAvtomobillar)
        {
            Console.WriteLine($"{avtomobil.IshlabChiqaruvchi} {avtomobil.Model} - {avtomobil.Rangi} - {avtomobil.Narxi}$");
        }
    }
}
