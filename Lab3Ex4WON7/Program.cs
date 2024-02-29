/*Ex 4. Scrieti un program care va inversa elementele unui vector
 Lungimea vectorului va fi citita de la tastatura
 Inversarea elementelor va fi facuta in functia Main (fara o functie dedicate)
 Afisarea vectorului se va face printr-o functie de afisare dedicata*/
Console.WriteLine("Introduceti lungimea vectorului");
int arrayLength = int.Parse(Console.ReadLine()!);
int[] array = new int[arrayLength];
for (int i = 0; i < arrayLength; i++)
{
    Console.WriteLine($"Introduceti elementul {i+1} al vectorului");
    array[i] = int.Parse(Console.ReadLine()!);
}
int[] reversedArray = new int[arrayLength];
for (int i = 0;i < arrayLength; i++)
{
    reversedArray[i] = array[arrayLength-i-1];
}
ShowArray(reversedArray);
void ShowArray(int[] array)=>Console.WriteLine(string.Join(" ", array));