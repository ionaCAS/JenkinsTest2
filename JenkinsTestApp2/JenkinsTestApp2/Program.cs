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

        Console.WriteLine("                                      ----------         \r\n        -------------            ------_       -----     \r\n     ----            _        ----                 ---_  \r\n   --                  _     --__   --------         --_ \r\n   --                  -------- _----_    -------     ---\r\n  --                 --┐┐_   ┌┌---╞           _--_--_----\r\n --            -------╞ |    |                           \r\n--_    -- --__ - -     ||    |                           \r\n_--_--_-               ||   |X                           \r\n _                     ||   |X                           \r\n                        |   |                            \r\n                        |-  ---                          \r\n                       --    --                          \r\n                      ---    ---                         \r\n                XXXXX -       --X      XXX               \r\n           X X X    XX  XX  X  XXXXX        XX X         \r\n                XXXXXXX X            XXXXXXX             ");

        Console.WriteLine($"It appears now that {plantName} is starting to grow!!!");

        //Growing simulation
        int growTime = 10; //seconds
        for (int i = 1; i <= growTime; i++) {
            Console.WriteLine($"Your plant is growing to... {i} cm tall!");
            Thread.Sleep(1000);
        }

        //add input for how long the plant simulation is to last.
    }
}
