

var test1 = "Mr John Smith";
var result1 = test1.Replace(" ", "%20");

var test2 = "Mr John Smith    ".ToCharArray();
URLify(test2);




System.Console.WriteLine(result1);
System.Console.WriteLine(test2);
System.Console.WriteLine();
static void URLify(char[] charArray)
{
    bool firstChar = false;
    int backIndex = charArray.Length - 1;
    for (int i = charArray.Length - 1; i >= 0; i--)
    {
        if (!firstChar)
            if (charArray[i] != ' ')
                firstChar = true;

        if (firstChar)
        {
            if (charArray[i] == ' ')
            {
                charArray[backIndex] = '0';
                charArray[backIndex -= 1] = '2';
                charArray[backIndex -= 1] = '%';
                backIndex -= 1;
            }
            else
            {
                charArray[backIndex] = charArray[i];
                backIndex--;
            }

        }
    }
}