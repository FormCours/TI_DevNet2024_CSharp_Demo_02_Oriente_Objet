using Demo_OO_03_SurchageOperateur.Models;

GroupePersonne groupeA = new GroupePersonne();
groupeA.Ajouter(new Personne { Prenom = "Donald", Nom = "Duck", Age = 34 });
groupeA.Ajouter(new Personne { Prenom = "Daisy", Nom = "Duck", Age = 32 });

GroupePersonne groupeB = new GroupePersonne();
groupeB.Ajouter(new Personne { Prenom = "Riri", Nom = "Duck", Age = 13 });
groupeB.Ajouter(new Personne { Prenom = "Fifi", Nom = "Duck", Age = 14 });
groupeB.Ajouter(new Personne { Prenom = "Loulou", Nom = "Duck", Age = 12 });


GroupePersonne groupeAB = groupeA + groupeB;

Personne della = new Personne { Prenom = "Della", Nom = "Duck", Age = 34 };
groupeAB = groupeAB + della;

Personne zaza = new Personne { Prenom = "Zaza", Nom = "Vanderquack", Age = 13 };
groupeAB = zaza + groupeAB;


if(della == zaza)
{

}