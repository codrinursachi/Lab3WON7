/*Ex 2
Scrieti o functie care va determina daca un numar este sau nu patrat perfect. Apelati-o si afisati-i rezultatul
*/

Console.WriteLine("Introduceti un numar pentru a se verifica daca e patrat perfect");
int number=int.Parse(Console.ReadLine()!);
Console.WriteLine($"E patrat perfect? {PerfectSquare(number)}");
bool PerfectSquare(int number) => Math.Sqrt(number) % 1 == 0;