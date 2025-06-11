using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

class Program {

    static void Main(string[] args)
    {
        string plantName = "testName";
        string plantLifespan = "0";

        //check jenkins args
        if (args.Length > 0 && !string.IsNullOrEmpty(args[0]) && !string.IsNullOrEmpty(args[1])) {
            plantName = args[0];
            plantLifespan = args[1];
        }

        Console.WriteLine("Testing plant simulator!!!");
        Console.WriteLine(" _,-._\r\n/ \\_/ \\\r\n>-(_)-<       \r\n\\_/ \\_/\r\n  `-'");

        Console.WriteLine("It appears you are now the proud parent of a small little seed, what do you wish to name it?");

        Console.WriteLine($"Ahh... You have named it {plantName}! So sweet of you.");

        Console.WriteLine("                                      ----------         \r\n        -------------            ------_       -----     \r\n     ----            _        ----                 ---_  \r\n   --                  _     --__   --------         --_ \r\n   --                  -------- _----_    -------     ---\r\n  --                 --┐┐_   ┌┌---╞           _--_--_----\r\n --            -------╞ |    |                           \r\n--_    -- --__ - -     ||    |                           \r\n_--_--_-               ||   |X                           \r\n _                     ||   |X                           \r\n                        |   |                            \r\n                        |-  ---                          \r\n                       --    --                          \r\n                      ---    ---                         \r\n                XXXXX -       --X      XXX               \r\n           X X X    XX  XX  X  XXXXX        XX X         \r\n                XXXXXXX X            XXXXXXX             ");
        
        Console.WriteLine($"\n\nIt appears now that {plantName} is starting to grow!!!");

        //add an input for how long they want their plant to live
        Console.WriteLine($"How long do you want your plant, {plantName}, to thrive for? (seconds)");

        Console.WriteLine($"It appears you have said {plantLifespan}! I hope your plant has a happy life :) Let's watch it grow!");

        //Growing simulation
        int growTime = int.Parse(plantLifespan); //seconds
        if (growTime > 0)
        {
            for (int i = 1; i <= growTime; i++)
            {
                Console.WriteLine($"Your plant is growing to... {i} cm tall!");
                Thread.Sleep(1000);
                if(i == 100)
                {
                    Console.WriteLine("Okay lets speed this up, we don't have all day to keep running!");
                    break;
                }
                
            }
        }

        //if plantLifespan < 20, say it perished away as a seedling
        if(growTime <= 20)
        {
            Console.WriteLine("                                                   ▓▒▒▒░▒▒▒▒▓           \r\n                                       ▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░▒░░▒▓▓▓       \r\n                                     ▓▓▓         ▓▓▒▒▓▒▒▒▒▒▒░░░░▓▓      \r\n                                    ▓▓            ▓▓   ▓▓▓▓▒▒▒░░░░▒     \r\n                                   ▓▓              ▓         ▓▓░░░░▒    \r\n                                   ▓                            ▒▒░     \r\n                                 ░ ▓                                    \r\n                           ░░░█░░░████▓ ▓ ▓▓                            \r\n                      ▓▓▓░░▓░░░▓▓░▓▓█▓▓▓▓▓▓▓▓▓                          \r\n                ▓░░▓ ▓▓░░░▓▓▓▓▓▓░▓▓▓░▒▓▓▒▓▓▓▓▓▓▓ ▒                      \r\n            ░▒░░░▓░░░▓░░▓░░░░▓▒▓▒▓░░░░░▒▒▒▓▓▓▓▓▓▓▓█████▓                \r\n    ▒▒▒░░░░░▓▓░░▒░░░▒▓▓▓░░▒▒░▒▒▒▒▒▒░▓▓▓▒▓▒▓▒▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓ ▒         \r\n   ░▒░░░░▒▒▒▒▒▒ ░░░░▓▓░▒▒▒▒░ ░▒▒ ░▒   ░▒▓▒▒▓▓▓▓▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓ ▒▒▒▒▒▒ \r\n ░░░▒░░▒▒░▒▓░▒░▓▓▒▒▒▒▒▒░▒▒░▒░░░░ ░▒░░░░░▒░ ▒░░░▒▒▒ ▒▒▒ ▒▒▒▒▓▒▒▒▒▒▒▒▒▒▒▒▒\r\n▒▒▒▒░░░▒░▒░░░░░▒▒▒▒▒░▒▒▒░░░░▒ ░░░▒░░  ░░▒▒▒▒▒ ▒▒▒   ▒   ▒▒▒▒▒▒▒▒ ▒ ▒▒▒▒ \r\n   ▒▒░ ░  ░░░░░░ ▒▒▒░▒▒░  ▒▒      ▒     ▒  ▒   ▒         ▒ ▒            ");
            Console.WriteLine($"\n\nPoor {plantName} did not live long enough to become a big plant... Try again!");
        }
        else if (growTime <= 40)
        {
            Console.WriteLine("             |▓▓▓▓▓        \r\n              | ▓▓▓        \r\n           ▓▓|    ▓        \r\n        ▓▓▓▓▓|             \r\n       ▓▓▓   |             \r\n             ||            \r\n              ▓▓▓          \r\n              |▓▓▓▓        \r\n▓▓▓▓▓▓       ||  ▓▓        \r\n   ▓▓        |            ▓\r\n             |         ▓▓▓▓\r\n            ░░░       ▓▓▓▓ \r\n        ░░░░░ ░░░░░ ░░░    \r\n   ░ ░░░              ░░░  ");
            Console.WriteLine($"\n\nWhat a short life you doomed {plantName} to! Only survived till it became a small sucker... Try again!");
        }
        else if (growTime <=100)
        {
            Console.WriteLine("                   ██  ██  \r\n                 █████████ \r\n                ██████████ \r\n     ███████    ███████████\r\n    █████████    ███████   \r\n     ███████   ▓▓ ██ ██    \r\n       ███ ▓▓▓▓     ██     \r\n    █████    ▓    ██████   \r\n   █████████  ▓▓ ████████  \r\n   ██████████   ▓█████████ \r\n ███████████▓  ▓  █ █████  \r\n█████████ █  ▓▓            \r\n ███ █         ▓           \r\n               ▓           \r\n              ░▓░          \r\n          ░░░░░ ░░░░░ ░░░  \r\n     ░ ░ ░              ░░░");
            Console.WriteLine($"\n\nA short but noble life... you tried your best {plantName}!");
        }
        else if(growTime <=500)
        {
            Console.WriteLine("  :::::                    █           █    ██                        \r\n :     :                █████ █ █ █ █████  ████  █             █  █   \r\n:       :             ██████████████████  █████ ███           ██████  \r\n :     :             ████████████|█████    ████  ██ ████      ██ ██   \r\n  :::::               ██  ██████  ██████  ███████████████ █  ██████   \r\n                        █  ██████ ██████████████ ███████████  █  █    \r\n                   █ █ ███ ██ ███  ██ ██ ███████ ███████  █           \r\n              ███ ███████████████ █     | █████████████               \r\n             ███████████████████████     |██████████ █                \r\n             █████████████|██ █████    |█ ███ ███████                 \r\n              █ █   ███    ███ █████  |██████  ██ ██                  \r\n                            █ ||███  | ██████                         \r\n                                ||   |  █  █          .......         \r\n                                  || |            ....       ......   \r\n                                    ||         ...                 ...\r\n                                     |                                \r\n                  ......             |                                \r\n          ........      ....         |                                \r\n      ....                  ..       |                                \r\n                                    ░|░                               \r\n                                ░░░░░ ÷÷÷÷÷÷░░░                       \r\n                           ░ ░ ░÷  ÷÷÷÷÷    ÷ ÷÷░                     \r\n                     ÷  ÷  ÷÷÷  ÷÷÷÷÷÷÷÷ ÷ ÷÷     ÷÷÷÷÷               \r\n                             ÷                                        ");
            Console.WriteLine($"\n\n Wow-ee!! What a fun life! {plantName} managed to live long enough to mature. I wonder what would happen if it lived a bit longer? Say 200ish more days... give or take ;)");
        }
        else if(growTime <=700)
        {
            Console.WriteLine("  :::::                    █           █    ██                        \r\n :     :                █████ █ █ █ █████  oo██  █             █  █   \r\n:       :             ██ooo██o██o█o█████  ██o██ ███           ██████  \r\n :     :             █oo████o████|o████    ████o oo o███o o   ██o██   \r\n  :::::               ██  ███o██  ██████  ████oo██o█o█oo█ █  o█████   \r\n                 o   o  █  ██████ ████████o██o█oo███o█o█████  █o █    \r\n                   █ o ███ █o ██oo ██ ██ ███oo██ █oo████oo█           \r\n              ███ o█o████o███████ █     | ██oooo█oo████               \r\n             o██o████ooo████o███████     |████oo████o█                \r\n             ██o██oo█████o|██ █████    |█ ███ o██████                 \r\n              █ █   ███    ███ █████  |██████  ██ ██                  \r\n                            █ ||███  | ██████                         \r\n                                ||   |  █  █    o     .......         \r\n                                  || |            ....       ......   \r\n                                    ||     o   ...                 ...\r\n                                     |                                \r\n                  ......             |     O     o                    \r\n          ........      ..o.         |    /|\\                         \r\n      ....              o   ..       |     |                          \r\n                           ooo  o   ░|░   | |    o                    \r\n                        o oooo oo░░░░ ÷÷÷÷÷÷░░░ oooooo                \r\n                      o o o░ o ░÷  ÷÷÷÷÷    ÷ ooooo oo                \r\n                     ÷  ÷  ÷÷÷  ÷÷÷÷÷÷÷÷ ÷ ÷÷     o÷÷÷÷               \r\n                             ÷                                        ");
            Console.WriteLine($"Wow! {plantName} lived long enough to drop an apple onto Sir Isaac Newton's Head! Now everyone will stop floating! Thank goodness {plantName} made some delicious fruit!");
        }
        else
        {
            Console.WriteLine("  :::::                    █           █    ██                        \r\n :     :                █████ █ █ █ █████  ████  █             █  █   \r\n:       :             ██████████████████  █████ ███           ██████  \r\n :     :             ████████████|█████    ████  ██ ████      ██ ██   \r\n  :::::               ██  ██████  ██████  ███████████████ █  ██████   \r\n                        █  ██████ ██████████████ ███████████  █  █    \r\n                   █ █ ███ ██ ███  ██ ██ ███████ ███████  █           \r\n              ███ ███████████████ █     | █████████████               \r\n             ███████████████████████     |██████████ █                \r\n             █████████████|██ █████    |█ ███ ███████                 \r\n              █ █   ███    ███ █████  |██████  ██ ██                  \r\n                            █ ||███  | ██████                         \r\n                                ||   |  █  █          .......         \r\n                                  || |            ....       ......   \r\n                                    ||         ...                 ...\r\n                                     |                                \r\n                  ......             |                                \r\n          ........      ....         |                                \r\n      ....                  ..       |                                \r\n                                    ░|░                               \r\n                                ░░░░░ ÷÷÷÷÷÷░░░                       \r\n                           ░ ░ ░÷  ÷÷÷÷÷    ÷ ÷÷░                     \r\n                     ÷  ÷  ÷÷÷  ÷÷÷÷÷÷÷÷ ÷ ÷÷     ÷÷÷÷÷               \r\n                             ÷                                        ");
            Console.WriteLine($"OH MY GOSH! {plantName} has had a fab life! They had so much fun; made friends, flowered and fruited once or twice maybe more, dropped leaves in autumn\n- congrats!~~~");
        }

        //add input for how long the plant simulation is to last.
    }
}
