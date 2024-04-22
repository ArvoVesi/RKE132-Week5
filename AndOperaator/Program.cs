//Mata >= 90 ; Bioloogia >= 90; Keemia >= 90

int mata, bioloogia, keemia;

Console.WriteLine("Sisesta oma mata tulemus: ");
mata = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisesta oma bioloogia tulemus: ");
bioloogia = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisesta oma keemia tulemus: ");
keemia = Int32.Parse(Console.ReadLine());

if (mata >=90 && bioloogia >= 90 && keemia >= 90)
{
    Console.WriteLine("Palju õnne.");
}
else
{
    Console.WriteLine("Proovi uuesti.");
}