using Demo_OO_07_Constructeur.Models;

Console.WriteLine("Moto");
Console.WriteLine("****");
Vehicule m1 = new Moto("BMW", "K1000", 25_423, 120);
Console.WriteLine("\n");

Console.WriteLine("Voiture 1");
Console.WriteLine("*********");
Vehicule v1 = new VoitureV1("Lada", "942", 1, 431_512, "Blanche");
Console.WriteLine("\n");

Console.WriteLine("Voiture 2");
Console.WriteLine("*********");
Vehicule v2 = new VoitureV1("Skoda", "Octavia", 31_555, 10, "Orange", 750, 5 );
Console.WriteLine("\n");

