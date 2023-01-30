using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zodiac.AgeChecker
{
    public class ZodiacModel // properties are: name, date from, date to
    {
        public string Name { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public ZodiacModel CheckZodiac(DateTime birthday) 
        {
            // if entered datetime is X, then zodiac sign is Y
            // have for loop to go through zodiac list, when datetime matches, break loop and return zodiac sign from list

            ZodiacModel ret = null;

            List<ZodiacModel> zodiacs = GetZodiacs(birthday.Year);
            foreach (ZodiacModel zodiac in zodiacs) 
            {
                if (birthday >= zodiac.DateFrom && birthday <= zodiac.DateTo)
                {
                    ret = zodiac; // this is what will use console.WriteLine(zodiac.name) in Main
                }
            }
            return ret;

        }

        private List<ZodiacModel> GetZodiacs(int birthyear) // will become GetZodiacs(int birthyear). Will then get rid of birthdate. all spots of birthdate.year will update to birthyear
        {
            


            return new List<ZodiacModel>()
            {
                new ZodiacModel()
                {
                    DateFrom = new DateTime(birthyear, 01, 01),
                    DateTo = new DateTime(birthyear, 01, 20),
                    Name = "Capricorn"
                },
                new ZodiacModel() // creating an object with these values and then including in the Zodiac list
                {
                    DateFrom = new DateTime(birthyear, 01, 21),
                    DateTo = new DateTime(birthyear, 02, 19),
                    Name = "Aquarius"
                },
                new ZodiacModel()
                {
                    DateFrom = new DateTime(birthyear, 02, 20),
                    DateTo = new DateTime(birthyear, 03, 20),
                    Name = "Pisces"
                },
                new ZodiacModel()
                {
                    DateFrom = new DateTime(birthyear, 03, 21),
                    DateTo = new DateTime(birthyear, 04, 20),
                    Name = "Aries"
                },
                new ZodiacModel()
                {
                    DateFrom = new DateTime(birthyear, 04, 21),
                    DateTo = new DateTime(birthyear, 05, 20),
                    Name = "Taurus"
                },
                new ZodiacModel()
                {
                    DateFrom = new DateTime(birthyear, 05, 21),
                    DateTo = new DateTime(birthyear, 06, 20),
                    Name = "Gemini"
                },
                new ZodiacModel()
                {
                    DateFrom = new DateTime(birthyear, 06, 21),
                    DateTo = new DateTime(birthyear, 07, 21),
                    Name = "Cancer"
                },
                new ZodiacModel()
                {
                    DateFrom = new DateTime(birthyear, 07, 22),
                    DateTo = new DateTime(birthyear, 08, 22),
                    Name = "Leo"
                },
                new ZodiacModel()
                {
                    DateFrom = new DateTime(birthyear, 08, 23),
                    DateTo = new DateTime(birthyear, 09, 21),
                    Name = "Virgo"
                },
                new ZodiacModel()
                {
                    DateFrom = new DateTime(birthyear, 09, 22),
                    DateTo = new DateTime(birthyear, 10, 21),
                    Name = "Libra"
                },
                new ZodiacModel()
                {
                    DateFrom = new DateTime(birthyear, 10, 22),
                    DateTo = new DateTime(birthyear, 11, 21),
                    Name = "Scorpio"
                },
                new ZodiacModel()
                {
                    DateFrom = new DateTime(birthyear, 11, 22),
                    DateTo = new DateTime(birthyear, 12, 21),
                    Name = "Sagittarius"
                },
                new ZodiacModel()
                {
                    DateFrom = new DateTime(birthyear, 12, 22),
                    DateTo = new DateTime(birthyear, 12, 31), 
                    Name = "Capricorn"
                }
            };
        }
    }
}
