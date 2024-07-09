using Demo_OO_11_Generique.Models;
using Demo_OO_11_Generique.Utils;


List<string> people = ["Riri", "Fifi", "Zaza", "Della", "Loulou", "Donald"];
List<Maison> maisons = new List<Maison>()
{
    new Maison("Jaune", 12),
    new Maison("Violet", 5),
    new Maison("Blanche", 7)
};
List<int> numbers = [42, -5, 121, -254, 12, 45];


string? r1 = CollectionUtilsV2.GetFirstElement(people, (person) => person.ToUpper().Contains("O")); 
Console.WriteLine($"Premier avec la lettre « o » est {r1}"); // -> Loulou

string? r2 = CollectionUtilsV2.GetFirstElement(people, delegate (string person) { return person.ToLower().Contains("d"); }); 
Console.WriteLine($"Premier avec la lettre « d » est {r2}"); // -> Della

string? r3 = CollectionUtilsV2.GetFirstElement(people, (person) => person.Length >= 5);
Console.WriteLine($"Premier avec au moins 5 caracteres est {r3}"); // -> Della

Maison? m1 = CollectionUtilsV2.GetFirstElement(maisons, (maison) => maison.NbPiece < 10);

CollectionUtilsV2.GetFirstElement(numbers, (nb) =>  nb % 2 == 0);
