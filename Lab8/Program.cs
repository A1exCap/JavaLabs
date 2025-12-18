using System;
using System.Text;

namespace Lab8
{
    class Program
    {
        static byte[] XOREncodeDecode(byte[] data, byte[] key)
        {
            byte[] result = new byte[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                result[i] = (byte)(data[i] ^ key[i % key.Length]);
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            string originalText = "Вихідний модуль, написаний на Java, теж не може уникнути цих процедур, але тут виявляється головна особливість технології Java - програма компілюється у машинні команди не якогось конкретного процесора, а у команди так званої віртуальної машини Java (JVM), яка є сукупністю команд разом з системою їх виконання";
            
            string key = "Мулька Олексій Андрійович";

            Console.WriteLine("=== XOR Кодування/Розкодування ===");
            Console.WriteLine();

            Console.WriteLine($"Оригінальний текст: {originalText}\n");
            Console.WriteLine($"Ключ: {key}");
            Console.WriteLine();

            byte[] originalBytes = Encoding.UTF8.GetBytes(originalText);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            byte[] encodedBytes = XOREncodeDecode(originalBytes, keyBytes);

            string encodedAsString = Encoding.UTF8.GetString(encodedBytes);
            Console.WriteLine($"Спроба вивести як рядок: ");
            Console.WriteLine(encodedAsString);

            byte[] decodedBytes = XOREncodeDecode(encodedBytes, keyBytes);
            string decodedText = Encoding.UTF8.GetString(decodedBytes);

            Console.WriteLine($"Розкодований текст: {decodedText}");
            Console.ReadKey();
        }
    }
}