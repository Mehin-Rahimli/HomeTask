//Verilmis 2 mertebeli ededin en boyuk reqemini tapin.
int num = 25;

if (num % 10 > num / 10)
{
    Console.WriteLine(num % 10);
}
else if (num % 10 < num / 10)
{
    Console.WriteLine(num / 10);
}
else
{
    Console.WriteLine("They are equal");
}