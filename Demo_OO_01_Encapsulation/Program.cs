
using Demo_OO_01_Encapsulation.Models;

// ---- V1 ----
// Déclaration + Initialisation (Nouvelle instance via "new")
PersonV1 p1 =  new PersonV1();

// Utilisation des setters
p1.SetFirstname("Della");
p1.SetLastname("Duck");
p1.SetBirthdate(new DateTime(1988, 12, 1));

// Utilisation des getters
string name1 = p1.GetFirstname() + " " + p1.GetLastname();
int age1 = p1.GetAge();
Console.WriteLine($"{name1} / {age1} ans");

// ---- V2 ----
// Déclaration + Initialisation 
PersonV2 p2 = new PersonV2();

// Utilisation des setters via les propriétés
p2.Firstname = "Zaza";
p2.Lastname = "Vanderquack";
p2.BirthDate = new DateTime(2013, 5, 9);

// Utilisation des getters via les propriétés
string name2 = p2.Firstname + " " + p2.Lastname;
int age2 = p2.Age;
Console.WriteLine($"{name2} / {age2} ans");