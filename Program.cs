//List<string> nevek_1 = new List<string>();
//var nevek_2 = new List<string>();
//List<string> nevek_3 = new();

List<string> nevek = new();
string nev_1 = "Para Zita";

nevek.Add(nev_1);
Console.WriteLine(nevek[0]);

for (int i = 0; i < nevek.Count; i++)
{
    Console.WriteLine($"nevek lista {i + 1}. eleme: {nevek[i]}");
}

string nevekListaUtolsoEleme = nevek.Last();
string nevekListaElsoEleme = nevek.First();

//ha van olyan értékű eleme a listának, akkor eltávolítja azt, és visszatér 'true'val
//ha nincs ilyen értékű eleme, akkor nem csinál semmit, és visszatér 'false'-al
bool sikerult = nevek.Remove("Lapos Elemér");

//nem tér vissza semmivel
//a paraméterben megadott indexedik elemet eltávolítja:
nevek.RemoveAt(0);

string[] megTobbNev = { "Végh Béla", "Lakatos Nintendó", "Kovács Héfaisztosz" };

//a kollekció összes elemét hozzáadja a listához:
nevek.AddRange(megTobbNev);

Console.ReadKey(true);