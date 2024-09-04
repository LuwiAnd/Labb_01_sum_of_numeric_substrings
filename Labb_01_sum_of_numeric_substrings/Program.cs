Console.WriteLine("Write a string of numbers and other characters.");

string myString = Console.ReadLine();
//string myString = "8348";

Console.WriteLine("\n\n\n");
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
for(int i = 0; i < myString.Length; i++)
{
    substring = "" + myString[i];
    //substring = myString[i];
    substringIsOk = false;
    substringStart = i;
    //substringEnd = i;
    substringLength = 0;
    for(int j = 1; j + i < myString.Length; j++)
    {
        charIsOk = false;
        for(int k = 0; k < digits.Length; k++)
        {
            if (myString[i + j] == digits[k]) charIsOk = true;
        }
        if (!charIsOk)
        {
            break;
        }

        if (myString[i + j] == myString[i])
        {
            substring += myString[i + j];
            substringIsOk = true;
            //substringEnd = i + j;
            substringLength = j + 1;
            break;
        }else if (i + j >= (myString.Length - 1))
        {
            break;
        }else
        {
            substring += myString[i + j];
        }
    }
    if (substringIsOk)
    {
        //Console.WriteLine(substring);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(myString.Substring(0, substringStart));
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(myString.Substring(substringStart, substringLength));
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(myString.Substring(substringStart + substringLength));
        Console.WriteLine();

        resultat += long.Parse(substring);
    }
}

Console.WriteLine($"Resultatet blev: {resultat}");