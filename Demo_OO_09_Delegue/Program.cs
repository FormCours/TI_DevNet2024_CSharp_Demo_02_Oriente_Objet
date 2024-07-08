using Demo_OO_09_Delegue.Utils;

List<int> numbers = [5, 32, 42, 1,  -5, 21, 99, -52, -5, 10, 2, 100];

Console.WriteLine("Trie : Ordre croissant");
Console.WriteLine("**********************");
bool TestCroissant(int val1, int val2)
{
    return val1 > val2;
}
List<int> numbersTrie1 = CollectionUtils.Trier(numbers, TestCroissant);
Console.WriteLine($"Original : {string.Join(" > ", numbers)}");
Console.WriteLine($"Trié     : {string.Join(" > ", numbersTrie1)}");

Console.WriteLine("Trie : Ordre décroissant");
Console.WriteLine("************************");
//TrierDelegate del = delegate (int val1, int val2) { return val1 < val2; };
List<int> numbersTrie2 = CollectionUtils.Trier(numbers, delegate (int val1, int val2) { return val1 < val2; });
Console.WriteLine($"Original : {string.Join(" > ", numbers)}");
Console.WriteLine($"Trié     : {string.Join(" > ", numbersTrie2)}");

Console.WriteLine("Trie : Alphabetique");
Console.WriteLine("************************");
List<int> numbersTrie3 = CollectionUtils.Trier(numbers, (val1, val2) => string.Compare(val1.ToString(), val2.ToString()) > 0);
Console.WriteLine($"Original : {string.Join(" > ", numbers)}");
Console.WriteLine($"Trié     : {string.Join(" > ", numbersTrie3)}");