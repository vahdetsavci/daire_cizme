using System;

namespace daire_cizme;

class Program
{
    static void Main(string[] args)
    {
        Yardimci yardimci = new Yardimci();
        
        Basla:
        Console.WriteLine();
        Console.WriteLine("****************************************************");
        Console.WriteLine("İstediğiniz dairenin yarıçapını giriniz!");
        Console.WriteLine("Not: Sadece 0'dan büyük tam sayılar kabul edilir.");
        Console.WriteLine("----------------------------------------------------");
        int yaricap = yardimci.Degerlendir(Console.ReadLine());

        if (yaricap > 0)
            new Daire(yaricap);
        
        Console.WriteLine("Devam etmek için [Enter] tuşuna basın.");
        Console.ReadLine();
        goto Basla;
    }
}
