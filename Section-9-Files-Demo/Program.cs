using System;
using System.IO;

namespace CsharpFundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");

            var path = @"/Users/faysalregal/Desktop/C# Fundamentals/Section 9 Working with Files/Demo/Path2/il_1588xN.2017618038_lcju.webp";

            // File.Copy(@"/Users/faysalregal/Desktop/C# Fundamentals/Section 9 Working with Files/Demo/Path1/il_1588xN.2017618038_lcju.webp", @"/Users/faysalregal/Desktop/C# Fundamentals/Section 9 Working with Files/Demo/Path2/il_1588xN.2017618038_lcju.webp", true);
            //File.Delete(path);
            if (File.Exists(path))
            {
                Console.WriteLine("Great Stuff!");
            }


        }
    }
}
