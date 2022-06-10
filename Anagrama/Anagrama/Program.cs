string FirstStr = Converter("oergig");
string SecndStr = Converter("goergi");
Console.WriteLine(FirstStr);
Console.WriteLine(SecndStr);

CheckIfAnagram(FirstStr, SecndStr);

string Converter(string firststr)
{
    char[] strArr = new char[firststr.Length];
    for(int i = 0; i < firststr.Length; i++)
    {
        strArr[i] = firststr[i];
    }

    Array.Sort(strArr);
    string testStr1 = new string(strArr);
    return testStr1;
}

void CheckIfAnagram(string firststr, string scndstr)
{
    bool isAnagr = false; 
    for (int i = 0; i < Math.Min(firststr.Length, scndstr.Length); i++)
    {
        if (firststr[i] == scndstr[i] )
        {
            isAnagr = true;
        }
        else
        {
            isAnagr = false;
        }
    }
    if (isAnagr)
    {
        Console.WriteLine("The string is anagrama");
    }
    else
    {
        Console.WriteLine("The String is not Anagram");
    }
}

