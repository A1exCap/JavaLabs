namespace Lab6
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class Program
    {


        static void Main(string[] args)
        {
            Dictionary<Test, Test> countries = new Dictionary<Test, Test>
            {
                { new Test{Id = 10, Name = "test1" }, new Test{Id = 10, Name = "test1" } },
               { new Test{Id = 10, Name = "test1" }, new Test{Id = 10, Name = "test1" } },
               { new Test{Id = 10, Name = "test1" }, new Test{Id = 10, Name = "test1" } },
               { new Test{Id = 10, Name = "test1" }, new Test{Id = 10, Name = "test1" } },
               { new Test{Id = 10, Name = "test1" }, new Test{Id = 10, Name = "test1" } },
               { new Test{Id = 10, Name = "test1" }, new Test{Id = 10, Name = "test1" } },
            };

            while (true)
            {
                Console.WriteLine("Enter action: 0. Exit 1. Get capital by name 2. Add country 3. Delete country 4. Write All countries");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int action))
                {

                    //switch (action)
                    //{
                    //    case 0:
                    //        return;

                    //    case 1:
                    //        Console.WriteLine("Enter country name:");
                    //        string? country = Console.ReadLine();
                    //        if (country != null && countries.ContainsKey(country))
                    //        {
                    //            Console.WriteLine($"Capital of {country} is {countries[country]}");
                    //        }
                    //        else
                    //        {
                    //            Console.WriteLine("Country not found.");
                    //        }
                    //        break;

                        //case 2:
                        //    string? newCountry, newCapital;
                        //    Console.WriteLine("Enter new country name:");
                        //    newCountry = Console.ReadLine();
                        //    Console.WriteLine("Enter its capital:");
                        //    newCapital = Console.ReadLine();
                        //    if (newCountry != null && newCapital != null)
                        //    {
                        //        countries.Add(newCountry, newCapital);
                        //        Console.WriteLine($"Added {newCountry} with capital {newCapital}");
                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine("Invalid input.");
                        //    }
                        //    break;

                        //case 3:
                        //    string? countryToDelete;
                        //    Console.WriteLine("Enter country name to delete:");
                        //    countryToDelete = Console.ReadLine();
                        //    if (countryToDelete != null && countries.ContainsKey(countryToDelete))
                        //    {
                        //        countries.Remove(countryToDelete);
                        //        Console.WriteLine($"Deleted {countryToDelete}");
                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine("Country not found.");
                        //    }
                        //    break;
                        //case 4:
                        //    Console.WriteLine("All countries and their capitals:");
                        //    foreach (var kvp in countries)
                        //    {
                        //        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                        //    }
                        //    Console.WriteLine();
                        //    break;

                    //    default:
                    //        Console.WriteLine("Invalid action.");
                    //        break;
                    //}
                }
                else
                {
                    Console.WriteLine("It's not a number!");
                }
            }
        }
    }
}
