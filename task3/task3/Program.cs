//Verilmis ededin 2nin quvveti olub olmadigini yoxlayin
float num = 32f;
if (num % 2 != 0 && num < 2)
{
    Console.WriteLine("2nin quvveti deyil");
}

else if (num >= 2)
{
    do
    {

        num = num / 2;
    } while (num > 1);
    if (num == 1)
    {
        Console.WriteLine("2nin quvvetidir");
    }
    else
    {
        Console.WriteLine("2nin quvveti deyil");
    }

}
else
{
    Console.WriteLine("2nin quvveti deyil");
}