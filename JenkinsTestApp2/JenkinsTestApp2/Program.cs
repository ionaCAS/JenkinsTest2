using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

class Program {

    static void Main(string[] args)
    {
        string plantName = "testName";

        //check jenkins args
        if (args.Length > 0 && !string.IsNullOrEmpty(args[0])) {
            plantName = args[0];
        }

        Console.WriteLine("Testing plant simulator!!!");
        Console.WriteLine(" _,-._\r\n/ \\_/ \\\r\n>-(_)-<       \r\n\\_/ \\_/\r\n  `-'");

        Console.WriteLine("It appears you are now the proud parent of a small little seed, what do you wish to name it?");

        Console.WriteLine($"Ahh... You have named it {plantName}! So sweet of you.");
    }
}
