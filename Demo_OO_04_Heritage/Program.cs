
using Demo_OO_04_Heritage.Models;
using Demo_OO_04_Heritage.MyEnums;

Formation formation = new Formation();
formation.Nom = "Apprendre à lock son pc 😜";
formation.Personnes.AddRange(new List<Personne>
{
    new Apprenant { Prenom = "Sacha", Genre = Gender.X, DateNaiss = new DateTime(2000, 2, 5) },
    new Formateur {Prenom = "Sebastien", Nom= "Bya", DateNaiss = new DateTime(1991, 3, 27), Genre= Gender.M, Specialisation = "Java" },
    new Apprenant { Prenom = "Mathias", Genre = Gender.M, DateNaiss = new DateTime(1998, 12, 22) },
    new Formateur {Prenom = "Aude", Nom= "Beurive", Genre= Gender.F, Specialisation = "Web" },
    new Formateur {Prenom = "Khun", Nom= "Ly", DateNaiss = new DateTime(1982, 5, 16), Genre= Gender.M, Specialisation= "Math" },
    new Apprenant { Prenom = "Phil", Genre = Gender.M, DateNaiss = new DateTime(1997, 9, 9) },
    new Formateur {Prenom = "Aurélien", Nom= "St", Genre= Gender.M, Specialisation= "JavaScript" }
});

Console.WriteLine("Liste des personnes : ");
foreach (Personne personne in formation.Personnes)
{
    if(personne is Apprenant)
    {
        Console.WriteLine($" - {personne.NomComplet} est un stagiaire !");
    }

    if(personne is Formateur formateur)
    {
        Console.WriteLine($" - {formateur.NomComplet} est formateur en {formateur.Specialisation}");
    }

}