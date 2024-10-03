//Verilmis ededin sade ve ya murekkeb oldugunu yoxlayin.
int num= 8;
if (num < 2)
{
    Console.WriteLine("Ne sade ne de murekkeb ededdir.");
}
else if (num >= 2)
{
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            Console.WriteLine("Bu eded murekkebdir");


        }
        else
        {
            Console.WriteLine("bu eded sadedir");

        }
    }
}
else
{
    Console.WriteLine("Duzgun input deyil");
}