//Goal of program is to have User input their birthday and have console return User's current age and their Zodiac sign

using Zodiac.AgeChecker;

Console.WriteLine("Please enter your Birth Month: ");

string month = Console.ReadLine() ?? ""; // will need to parse to int? ex. Jan = 01?


Console.WriteLine("Please enter your Birth Day: ");

string day = Console.ReadLine() ?? ""; // will need to parse to int,but what do if user types in day that doesn't exist, like 70?


Console.WriteLine("Please enter your Birth Year: ");

string year = Console.ReadLine() ?? "";

DateTime birthday = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));

ZodiacModel userZodiac = new ZodiacModel().CheckZodiac(birthday);


string today = DateTime.Now.ToString("yyyyMMdd");
string birth = birthday.ToString("yyyyMMdd");


int age = int.Parse(today) - int.Parse(birth);
Console.WriteLine("You are " + string.Concat(age.ToString()[0], age.ToString()[1]) + " years old!");

Console.WriteLine("Your zodiac sign is " + userZodiac.Name + "!");

//Console.WriteLine(birthday.ToString());

