using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class InternationalProvider
    {
        public static ILanguage CreateLangauge(Country country)
        {
            switch (country)
            {
                case Country.ENGLAND:
                    return new English();
                case Country.SPAIN:
                    return new Spanish();
                default:
                    throw new NotSupportedException("Country not supported");
            }
        }

        public static ICapitalCity CreateCapital(Country country)
        {
            switch (country)
            {
                case Country.ENGLAND:
                    return new London();
                case Country.SPAIN:
                    return new Madrid();
                default:
                    throw new NotSupportedException("Country not supported");
            }
        }
}
