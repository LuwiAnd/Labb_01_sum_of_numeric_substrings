Console.WriteLine("Write a string of numbers and other characters.");

string userString = Console.ReadLine();

Console.WriteLine("\n\n");
string substring;

char[] digits = new char[]
{
    '0',
    '1',
    '2',
    '3',
    '4',
    '5',
    '6',
    '7',
    '8',
    '9'
};

bool substringIsOk;
bool charIsOk;
long resultat = 0;

int substringStart;
//int substringEnd;
int substringLength;
for(int i = 0; i < userString.Length; i++)
{
    substring = "" + userString[i];
    //substring = userString[i];
    substringIsOk = false;
    substringStart = i;
    //substringEnd = i;
    substringLength = 0;
    for(int j = 1; j + i < userString.Length; j++)
    {
        charIsOk = false;
        for(int k = 0; k < digits.Length; k++)
        {
            if (userString[i + j] == digits[k]) charIsOk = true;
        }
        if (!charIsOk)
        {
            break;
        }

        if (userString[i + j] == userString[i])
        {
            substring += userString[i + j];
            substringIsOk = true;
            //substringEnd = i + j;
            substringLength = j + 1;
            break;
        }else if (i + j >= (userString.Length - 1))
        {
            break;
        }else
        {
            substring += userString[i + j];
        }
    }
    if (substringIsOk)
    {
        //Console.WriteLine(substring);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(userString.Substring(0, substringStart));
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(userString.Substring(substringStart, substringLength));
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(userString.Substring(substringStart + substringLength));
        Console.WriteLine();

        resultat += long.Parse(substring);
    }
}

Console.WriteLine();
Console.WriteLine($"Resultatet blev: {resultat}");