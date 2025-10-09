using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            char[] Array = { 'n', 'l', 't', 'u', 'i', 'k', 'n', 'i', 't', 'i', 'p', 'z', '2', '1', '-', '2' };
            Console.WriteLine(Array);
            // 2
            string str1 = new string(Array, 0, 9) + new string(Array, 12, 4);
            Console.WriteLine(str1);
            // 3
            string str2 = new string(str1.Reverse().ToArray());
            Console.WriteLine(str2);
            // 4
            string str3 = str1.ToUpper();
            Console.WriteLine(str3.Equals(str1));
            // 5
            string institute = new string(str1.ToCharArray(), 4, 5);
            Console.WriteLine(institute);
            // 6
            string str4 = str1 + str3;
            Console.WriteLine(str4);
            // 7
            int indexOfFirstLetter = str1.IndexOf('i');
            Console.WriteLine($"first i: {indexOfFirstLetter}");
            int indexOfLastLetter = str1.LastIndexOf('i');
            Console.WriteLine($"last i: {indexOfLastLetter}");
            // 8
            StringBuilder data = new StringBuilder("Мулька Олексій Андрійович 10.01.2007");
            Console.WriteLine(data);
            // 9
            data.Remove(data.ToString().IndexOf('1'), 6);
            Console.WriteLine(data);
            // 10
            data.Insert(data.ToString().Length, " Червоноград");
            Console.WriteLine(data);
            // 11
            data.Append(" чоловіча");
            Console.WriteLine(data);
            // 12
            int symbolLength = data.Length;
            Console.WriteLine($"Symbol Length: " + symbolLength);
            int bytesLength = Encoding.UTF8.GetBytes(data.ToString()).Length;
            Console.WriteLine($"Byte Length: " + bytesLength);
            // 13
            int firstIndexOfYear = data.ToString().IndexOf("2");
            data.Remove(firstIndexOfYear, data.ToString().Length - firstIndexOfYear);
            Console.WriteLine(data);
            // 14
            Console.WriteLine(data.ToString().Substring(0, 6).Reverse().ToArray());
        }
    }
}
