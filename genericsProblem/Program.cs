/*Uma empresa de consultoria deseja avaliar a performance de produtos,
funcionários, dentre outras coisas. Um dos cálculos que ela precisa é encontrar
o maior dentre um conjunto de elementos. Fazer um programa que leia um
conjunto de N produtos, conforme exemplo, e depois mostre o mais caro deles.
*/

using genericsProblem.Services;

List<int> list = new List<int>();

Console.WriteLine("Enter N: ");
int n = int.Parse(Console.ReadLine());

for(int i = 0 ; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    list.Add(x);
}
CalculationService calculationService = new CalculationService();

int max = calculationService.Max(list);

Console.WriteLine("Max: " + max);