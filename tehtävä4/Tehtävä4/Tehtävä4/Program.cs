using Tehtävä4;

internal class Program
{
    private static void Main(string[] args)
    {
        Albumi albumi = new Albumi();
        albumi.Artisti = "Pop Smoke";
        albumi.Nimi = "Meet the Woo";
        albumi.Genre = "Rap";
        albumi.Kappalemäärä = 5;
        albumi.Hinta = 5;


        albumi.Kappalelisäys("Meet the Woo");
        albumi.Kappalelisäys("Welcome to the party");
        albumi.Kappalelisäys("Hawk Em");
        albumi.Kappalelisäys("Scenario");
        albumi.Kappalelisäys("Dior");

        albumi.albumitulostus();
        albumi.biisitulostus();
    }
}