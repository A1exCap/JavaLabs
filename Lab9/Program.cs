using System;
using System.IO;

namespace SimpleStreamMerge
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();

            byte[] data1 = new byte[8];
            byte[] data2 = new byte[8];

            for (int i = 0; i < 8; i++)
            {
                data1[i] = (byte)rand.Next(0, 11);
                data2[i] = (byte)rand.Next(0, 11);
            }

            Stream stream1 = new MemoryStream(data1);
            Stream stream2 = new MemoryStream(data2);

            MemoryStream merged = new MemoryStream();

            stream1.CopyTo(merged);
            stream2.CopyTo(merged);

            Console.WriteLine("Merged:");
            merged.Position = 0; 

            for (int i = 0; i < merged.Length; i++)
            {
                Console.Write(merged.ReadByte() + " ");
            }

            stream1.Close();
            stream2.Close();
            merged.Close();

            Console.ReadKey();
        }
    }
}