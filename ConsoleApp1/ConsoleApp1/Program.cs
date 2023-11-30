
var name = "Ewa";
var sex = "kobieta";
int wiek = 33;

if (sex == "kobieta" && wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}
else if (name == "Ewa" && wiek == 33)
{
    Console.WriteLine("Ewa, lat 33.");
}
else if (wiek < 18)
{
    Console.WriteLine("Niepełnioletnia Kobieta.");
}
else
{
    Console.WriteLine("Inne.");
}