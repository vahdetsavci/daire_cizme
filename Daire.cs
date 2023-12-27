using System;

namespace daire_cizme;

class Daire
{
    static double console_oran;
    double a, b;

    static Daire()
    {
        console_oran = 5.0 / 2.0;
    }

    internal Daire(int yaricap)
    {
        a = console_oran * yaricap;
        b = yaricap;
        Ciz(yaricap, a, b);
    }

    private void Ciz(int yaricap, double a, double b)
    {
        for (int y = -yaricap; y <= yaricap; y++)
        {
            for (double x = -a; x <= a; x++)
            {
                double d = (x / a) * (x / a) + (y / b) * (y / b);
                if (d > 0.90 && d < 1.2)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.Write("\n");
        }
    }
}