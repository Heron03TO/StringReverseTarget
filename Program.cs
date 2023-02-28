string inputString = "Eu vou conseguir a aprovação, se tudo der certo";
string reversedString = "";

for (int i = inputString.Length - 1; i >= 0; i--)
{
    reversedString += inputString[i];
}

Console.WriteLine(reversedString);

