using System.Diagnostics.Metrics;

int number = 4566;
string numberIsString = number.ToString();
char[] digit = numberIsString.ToArray();
int[] numberOfDigits = new int[10];
for (int i = 0; i < numberIsString.Length; i++) numberOfDigits[i] = 0;

foreach (var letter in numberIsString) 
{
    if (letter == '0') numberOfDigits[0] += 1;
    else if (letter == '1') numberOfDigits[1] += 1;
    else if (letter == '2') numberOfDigits[2] += 1;
    else if (letter == '3') numberOfDigits[3] += 1;
    else if (letter == '4') numberOfDigits[4] += 1;
    else if (letter == '5') numberOfDigits[5] += 1;
    else if (letter == '6') numberOfDigits[6] += 1;
    else if (letter == '7') numberOfDigits[7] += 1;
    else if (letter == '8') numberOfDigits[8] += 1;
    else if (letter == '9') numberOfDigits[9] += 1;
}

Console.WriteLine("Wyniki dla liczy : {4566}");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i} => {numberOfDigits[i]}");
}