namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> countriesAndCapitals = new List<string>
            {
                "Ukraine",
                "Kyiv",
                "USA",
                "Washington",
                "France",
                "Paris",
                "Germany",
                "Berlin",
                "Italy",
                "Rome"
            };

            while (true)
            {
                Console.WriteLine("Enter action: 0. Exit 1. Get capital by name 2. Add country 3. Delete country 4. Write All countries");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int action))
                {

                    switch (action)
                    {
                        case 0:
                            return;

                        case 1:
                            Console.WriteLine("Enter country name:");
                            string? country = Console.ReadLine();
                            if (country != null && countriesAndCapitals.Contains(country))
                            {
                                Console.WriteLine($"Capital of {country} is {countriesAndCapitals[countriesAndCapitals.IndexOf(country) + 1]}");
                            }
                            else
                            {
                                Console.WriteLine("Country not found.");
                            }
                            break;

                        case 2:
                            string? newCountry, newCapital;
                            Console.WriteLine("Enter new country name:");
                            newCountry = Console.ReadLine();
                            Console.WriteLine("Enter its capital:");
                            newCapital = Console.ReadLine();
                            if (newCountry != null && newCapital != null)
                            {
                                countriesAndCapitals.Add(newCountry);
                                countriesAndCapitals.Add(newCapital);
                                Console.WriteLine($"Added {newCountry} with capital {newCapital}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input.");
                            }
                            break;

                        case 3:
                            string? countryToDelete;
                            Console.WriteLine("Enter country name to delete:");
                            countryToDelete = Console.ReadLine();
                            if (countryToDelete != null && countriesAndCapitals.Contains(countryToDelete))
                            {
                                countriesAndCapitals.RemoveAt(countriesAndCapitals.IndexOf(countryToDelete) + 1);
                                countriesAndCapitals.Remove(countryToDelete);
                                Console.WriteLine($"Deleted {countryToDelete}");
                            }
                            else
                            {
                                Console.WriteLine("Country not found.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("All countries and their capitals:");
                            
                            var test = countriesAndCapitals.Select(x =>
                            {
                                if (countriesAndCapitals.IndexOf(x) % 2 == 0)
                                {
                                    Console.Write($"Country: {x}\t");
                                }
                                else
                                {
                                    Console.WriteLine($" Capital: {x}");
                                }
                                return x;
                            });

                            test.ToList();

                            Console.WriteLine();
                            break;

                        default:
                            Console.WriteLine("Invalid action.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("It's not a number!");
                }
            }
        }
    }
}
