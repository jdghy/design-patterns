namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Classic Approach
            IInternationalFactory factory = new EnglandFactory();
            ILanguage language = factory.CreateLanguage();
            ICapitalCity capital = factory.CreateCapital();

            //Provider Approach
            //Country country = Country.ENGLAND;
            //ILanguage language = InternationalProvider.CreateLangauge(country);
            //ICapitalCity capital = InternationalProvider.CreateCapital(country);

            language.Greet();

            Console.WriteLine("Total Populations: "+ capital.GetPopulation());   
            Console.WriteLine("Top Attraction: " + capital.ListTopAttractions());

        }
    }
}
