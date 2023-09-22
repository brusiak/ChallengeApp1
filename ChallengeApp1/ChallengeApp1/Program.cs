// praca domowa

var name = "Ewa";
char sex = 'K';
var age = 33;

if (name == "Ewa" && age == 25 && sex == 'K')
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" && sex == 'K' && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if (name == "Ewa" && age <= 17  && sex == 'k')
{
    Console.WriteLine("Niepelnoletni Mezczyzna");
}