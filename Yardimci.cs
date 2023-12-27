using System;

namespace daire_cizme;

class Yardimci
{
    internal int Degerlendir(string yaricap)
    {
        try
        {
            int _yaricap = int.Parse(yaricap);
            if (_yaricap < 1)
                throw new Exception();

            return _yaricap;
        }
        catch(FormatException) // int olmayan değer hatası
        {
            Hata("Herhangi bir sayı girmediniz!");
        }
        catch (Exception)      // Pozitif olmayan değer girişi hatası
        {
            Hata("Pozitif olmayan bir değer girdiniz!");
        }
        return 0;   // Hata alınırsa 0 return edilir.
    }

    private void Hata(string mesaj)
    {
        Console.WriteLine(mesaj);
        System.Threading.Thread.Sleep(2000);
    }
}