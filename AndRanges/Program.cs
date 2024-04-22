// temp <= 0 - jää
//temp > 0 AND temp <= 10, külm
//temp > 10 and <= 15, leige
// temp > 15 and <= 20, soe
// temp > 20 and temp <= 30, kuum
// temp > 30, saun

Console.WriteLine("Sisestage temperatuur");
int temperatuur = Int32.Parse(Console.ReadLine());

if (temperatuur > 30)
{
    Console.WriteLine("Saun");
}
else if(temperatuur <= 30 && temperatuur > 20)
{
    Console.WriteLine("Kuum");
}
else if (temperatuur <= 20 && temperatuur > 15)
{
    Console.WriteLine("Soe");
}
else if (temperatuur <= 15 && temperatuur > 10)
{
    Console.WriteLine("Leige");
}
else if (temperatuur <= 10 && temperatuur > 0)
{
    Console.WriteLine("Kuum");
}
else if (temperatuur <= 0)
{
    Console.WriteLine("Kuum");
}