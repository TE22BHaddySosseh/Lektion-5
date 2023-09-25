using System;

Random generator = new Random();

int boxer1hp = 100;
int boxer2hp = 100;

while (boxer1hp > 0 && boxer2hp > 0)
{
    int boxer1dmg = generator.Next(50);
    int boxer2dmg = generator.Next(50);

    boxer1hp = boxer1hp - boxer2dmg;
    boxer2hp = boxer2hp - boxer1dmg;
    Console.WriteLine("Boxer 1 does " + boxer1dmg + " to Boxer 2!");
    Console.WriteLine("Boxer 2 does " + boxer2dmg + " to Boxer 1!");
    Console.WriteLine("Boxer 1: " + boxer1hp + "   Boxer 2: " + boxer2hp);

    Console.WriteLine("Press any button to continue!");
    Console.ReadKey();

        if (boxer1hp < 1)
        {
            Console.WriteLine("Boxer 2 has defeated Boxer 1!");
            Console.WriteLine("Boxer 2 had " + boxer2hp + "hp remaining!");
            Console.WriteLine("Press any button to quit!");
        }

        if (boxer2hp < 1)
        {
            Console.WriteLine("Boxer 1 has defeated Boxer 2!");
            Console.WriteLine("Boxer 1 had " + boxer1hp + "hp remaining!");
            Console.WriteLine("Press any button to quit!");
        }

}


Console.ReadLine();