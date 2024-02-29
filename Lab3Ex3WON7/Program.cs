/*Ex 3
Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul sau citit de la
tastatura. Scrieti functii care vor returna
• Cel mai mare numar din vector
• Cel mai mic numar din vector
• Numerele divizibile cu 3
Dificultate ridicata
• Numerele patrate perfecte din vector
Apelati functiile si afisati-le rezultatele.*/

Console.WriteLine("Introduceti lungimea vectorului");
int arrayLength=int.Parse(Console.ReadLine()!);
int[] array=new int[arrayLength];
for(int i = 0; i < arrayLength; i++)
{
    Console.WriteLine($"Introduceti elementul {i+1} al vectorului");
    array[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Numarul maxim e {MaxArrayNumber(array)}");
Console.WriteLine($"Numarul minim e {MinArrayNumber(array)}");
Console.WriteLine($"Numerele divizibile cu 3 sunt {string.Join(" ", NumbersDivisibleBy3InArray(array))}");
Console.WriteLine($"Numerele patrat perfect sunt {string.Join(" ", PerfectSquaresInArray(array))}");


int MaxArrayNumber(int[] array) => array.Max();
int MinArrayNumber(int[] array) => array.Min();
int[] NumbersDivisibleBy3InArray(int[] array) => array.AsParallel()
                                                      .Where(x => x % 3 == 0)
                                                      .ToArray();
int[] PerfectSquaresInArray(int[] array) => array.AsParallel()
                                           .Where(x => Math.Sqrt(x) % 1 == 0)
                                           .ToArray();