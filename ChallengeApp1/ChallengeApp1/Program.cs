// praca domowa

string imie = "Ewa";
string plec = "kobieta";
int wiek = 33;

if (plec.ToLower() == "kobieta" && wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}
else if (imie == "Ewa" && wiek == 33)
{
    Console.WriteLine("Ewa, lat 33.");
}
else if (wiek < 18)
{
    Console.WriteLine("Niepełnoletni.");
}
else
{
    Console.WriteLine("Inne.");
}