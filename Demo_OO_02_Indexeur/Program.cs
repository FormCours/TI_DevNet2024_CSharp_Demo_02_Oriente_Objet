using Demo_OO_02_Indexeur.Models;


CommuneIndexeur c = new CommuneIndexeur();
Commune commune = new Commune()
{
    CodePostal = "4347",
    Nom = "Fexhe le haut Clocher",
    NbHabitant = 100
};
Commune commune2 = new Commune()
{
    CodePostal = "4000",
    Nom = "Liege",
    NbHabitant = 1000
};
Commune commune3 = new Commune()
{
    CodePostal = "4500",
    Nom = "Huy",
    NbHabitant = 150
};

c._communes.Add(commune);
c._communes.Add(commune2);
c._communes.Add(commune3);

//Commune result = c.Get("4347");

//Dictionary<string,Commune> c2 = new Dictionary<string,Commune>();
//c2.Add(commune.CodePostal, commune);

//result = c2["4347"];

Commune? result = c["4347"];
Console.WriteLine(result?.Nom);

result = c[5];
Console.WriteLine(result?.Nom);