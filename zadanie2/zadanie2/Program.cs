// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter username:");

string userName = Console.ReadLine();

Console.WriteLine("Hello " + userName);


Console.WriteLine("Zweryfikuj swoją tożsamość. Ile jest 2+2 ?");

string number = Console.ReadLine();
int FinalNumber = 0;
Int32.TryParse(number, out FinalNumber);

if  (FinalNumber == 4)
{
    Console.WriteLine("Weryfikacja zatwierdzona.");
}
else
{
    Console.WriteLine("Weryfikacja niezatwierdzona");
}