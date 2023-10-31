Console.WriteLine("enter a number: ");
int number = int.Parse(Console.ReadLine());
int fact = 1, n = 1;
while (n <= number)
{
    fact *= n;
    n++;
}
Console.WriteLine("\n{0}! = {1}\n\n", number, fact);
// پویان نصیری تمرین شماره 5
