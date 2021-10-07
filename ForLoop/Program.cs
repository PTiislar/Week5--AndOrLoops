using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // I will not skateboard in the halls.

            // string message = "I will not skateboard in the halls.".ToUpper();

            for (int i = 0; i < 10; i++) //int i = 0 intersatsiooni algus; i < 10 interatsiooni lopp; i++ = i + i + i... -samm
            {
                Console.WriteLine($"{i+1}. I will not skateboard in the halls.".ToUpper());
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
