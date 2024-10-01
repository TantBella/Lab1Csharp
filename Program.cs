
string stringInput = "29535123p48723487597645723645";

static void FindTheNumbers(string stringInput)
{
    Console.WriteLine("\n");
    string subStr = stringInput;
    //Använder en foor-loop för att gå igenom varje tecken i strängen
    for (int i = 0; i < stringInput.Length; i++)
    //while(stringInput.Length > i)
    {
        //kollar om tecknet är en siffra och sparar isf som firstNumber
        if (char.IsDigit(stringInput[i]))
        {
            char firstNumber = stringInput[i];
            //en inre loop börjar på i och går till slutet av strängen,
            for (int j = i + 1; j < stringInput.Length; j++)
            {
                //om man hittar ett tecken som inte är siffra bryts loopen.
                if (!char.IsDigit(stringInput[j]))
                {
                    break;
                }
                //om nästa tecken är en siffra som är samma som det första så ska det skrivas en en substräng med 
                //första siffran till nästa likadana och de ska skrivas ut
                if (stringInput[j] == firstNumber)
                {
                    string beforeSubstr = stringInput.Substring(0, i);
                    subStr = stringInput.Substring(i, j - i + 1);
                    string afterSubStr = stringInput.Substring(j + 1);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(beforeSubstr);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    //skriver ut substrängen med de matchande siffronra
                    Console.Write(subStr);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(afterSubStr);
                    break;
                }
            }
        }
    }
}


FindTheNumbers(stringInput);


static void AddTheSubStr(string stringInput)
{
    // stor summa är bättre med long än int
    long addNumbers = 0;

    for (int i = 0; i < stringInput.Length; i++)
    {
        if (char.IsDigit(stringInput[i]))
        {
            //char firstNumber = stringInput[i];
            for (int j = i + 1; j < stringInput.Length; j++)
            {
                if (!char.IsDigit(stringInput[j]))
                {
                    break;
                }

                if (stringInput[j] == stringInput[i])
                {
                    string subStr = stringInput.Substring(i, j - i + 1);
                    // omvandla till siffra istället för string
                    addNumbers += Convert.ToInt64(subStr);

                    break;
                }
            }
        }
    }
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\n Summan är: " + addNumbers);
    Console.ResetColor();
}

AddTheSubStr(stringInput);




