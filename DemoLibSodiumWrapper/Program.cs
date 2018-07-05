using System;
using System.Security.Cryptography;
using System.Text;
using NitraLibSodium;

namespace DemoLibSodiumWrapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            Init();
            Console.ReadLine();
        }

        static void Init()
        {
            byte[] output = new byte[64];
            byte[] input = Encoding.UTF8.GetBytes("Test Message for hasing");
            NitraLibSodium.Hash.Sha512.CryptoSha512(output, input, 64);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in output)
                stringBuilder.AppendFormat("{0:X2}", b);
            Console.WriteLine(stringBuilder.ToString());

            
        }
    }
}
