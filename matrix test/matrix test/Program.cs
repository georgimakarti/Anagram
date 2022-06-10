string str = "goergi";
string strrr = "georgi";

//SortingString(str);
//SortingString(strrr);
CheckIfAnagram(str, strrr);



void CheckIfAnagram(string str, string strrr)
{

    string refer = Convert.ToString(SortingString(str))!;
    string referr = Convert.ToString(SortingString(strrr))!;

    Console.WriteLine("{0} {1}", refer, referr);

    for (int i = 0; i < refer.Length; i++)
    {

       if (refer[i] != referr[i])
           {
               Console.WriteLine("The String is not Anagram {0} {1}", refer[i], referr[i]);
               return;
           }
        Console.WriteLine("{0} {1}", refer[i], referr[i]);
    }
    Console.WriteLine("The string is anagrama");
}

List<char> SortingString(string str)
{
    List<char> sortedList = new List<char>();
    sortedList.AddRange(str.ToLower().ToCharArray());
    sortedList.Sort();

    foreach (var i in sortedList)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    return sortedList;
}

