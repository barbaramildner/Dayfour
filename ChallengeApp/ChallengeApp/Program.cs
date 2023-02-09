var name = "Anna";
bool woman = true;
int age = 40;

if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (woman == false && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (woman == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else
{
    Console.WriteLine("40 letnia kobieta o imieniu Anna");
}
// Ewa, lat 30
// Niepełnoletni mężczyzna
// Kobieta poniżej 30 lat
// 40 letnia kobieta o imieniu Anna