using Demo_OO_05_Static.Tools;

using static System.Console;
using static System.Math;
//using static Demo_OO_05_Static.Tools.ExempleTool;


Console.WriteLine("Veuillez encoder deux nombre");
Write("> ");
double nb1 = int.Parse(ReadLine()!);

Write("> ");
double nb2 = int.Parse(ReadLine()!);

double res = Round(nb1 / nb2);
WriteLine($"Resultat : {res}");

ExempleTool.Valeur = 50;
