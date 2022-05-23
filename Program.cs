/* Ask for valid inputs and outputs
Whatever the interviewer says, write it down
Develop test cases
Don’t be afraid to do this out of order
Don’t be afraid to come back to make more test cases
Call the function with these conditions, print results
Ensure your understanding of the problem
Unless you’re given a signature, write your own signatures
Start with the first test case
If you think of other test cases, don’t try to solve it immediately, add it to the bottom of the list of test cases
Finish all the other test cases, one by one */


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