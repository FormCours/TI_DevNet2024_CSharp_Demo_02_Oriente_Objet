using Demo_OO_10_Event.Models;

Tamagotchi tamagotchi = new Tamagotchi("Cookie");

tamagotchi.FaimEvent += delegate (Tamagotchi tama, string message)
{
    Console.WriteLine($"{tama.Nom} : {message}");
};

tamagotchi.MortEvent += (tama) =>
{
    Console.WriteLine($"{tama.Nom} est mouru... 😭");
};


int jour = 1;
while (!tamagotchi.EstMouru)
{
    Console.WriteLine($"Jour {jour++}");
    tamagotchi.PasserJournee();

    if(Random.Shared.Next(3)  == 0)
    {
        tamagotchi.Nourrir("Sandwich");
    }

    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine($"RIP !");
