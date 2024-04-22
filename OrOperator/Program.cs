// Mata >= 90 OR chemistry >= 90

// mata && chemistry OR mata && biology

int math, biology, chemistry;

Console.WriteLine("Sisesta oma math tulemus: ");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisesta oma biology tulemus: ");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisesta oma chemistry tulemus: ");
chemistry = Int32.Parse(Console.ReadLine());

if((math >= 90 && chemistry >= 90) || (biology >= 90 && chemistry >= 90) || (math >=90 && biology >= 90))
{
    Console.WriteLine("Palju õnne.");
}
else
{
    Console.WriteLine("Proovi uuesti.");
}