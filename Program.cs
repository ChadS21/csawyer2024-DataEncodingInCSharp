using System;

namespace csawyer2024_DataEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = args[0];
            Console.WriteLine($"Loading '{filepath}'.");

            string message;
            message = System.IO.File.ReadAllText(filepath);
            Console.WriteLine($"The encrypted message is {message}");

            int shift;
            shift = 1;
            while (shift <= 10)
            {
            Cipher cipher;
            cipher = new Cipher(shift);
            string decrypted;
            decrypted = cipher.Decrypt(message);
            Console.WriteLine($"The decrypted message is: '{decrypted}'");
            shift += 1;
            }
        }
    }
}
