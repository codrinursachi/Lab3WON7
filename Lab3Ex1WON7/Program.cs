/*Ex 1
Scrieti o functie care va calcula suma cifrelor unui numar.
*/
Console.WriteLine("Introduceti un numar pentru a i se calcula suma cifrelor");
int number = Math.Abs(int.Parse(Console.ReadLine()!));
Console.WriteLine(ComputeDigitSum(number));
int ComputeDigitSum(int number) => number == 0 ? 0 : 
                                   number % 10 + ComputeDigitSum(number / 10);