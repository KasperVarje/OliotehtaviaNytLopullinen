using Tehtävä8s;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        Henkilö t1 = new Työntekijä("Jussi", "Nokia", 3400, 4);
        Henkilö t2 = new Työntekijä("Johannes", "CGI", 4400, 4);
        Pomo p1 = new Pomo();
        Pomo p2 = new Pomo();

        p1.pomolasku();
    }
}