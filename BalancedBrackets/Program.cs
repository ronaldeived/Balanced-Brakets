
Dictionary<char, char> bracketsPairs = new Dictionary<char, char>
{
        { '(', ')' },
        { '[', ']' },
        { '{', '}' },
};

string IsValid(string input)
{
    if (input.Count() == 0) return "Is Valid";

    Stack<char> bracketsOpen = new Stack<char>();

    foreach (char i in input)
    {
        if (bracketsPairs.ContainsKey(i)) bracketsOpen.Push(i);
        else if (bracketsPairs.Values.Contains(i))
        {
            if (bracketsOpen.Count == 0) return "Is Invalid";

            var openingBracket = bracketsOpen.Pop();

            if (bracketsPairs[openingBracket] != i)
            {
                return "Is Invalid";
            }
        }
    }

    return bracketsOpen.Count == 0 ? "Is Valid" : "Is Invalid";
}


Console.WriteLine(IsValid("(){}[]"));
Console.WriteLine(IsValid("[{()}](){}"));
Console.WriteLine(IsValid("[]{()"));
Console.WriteLine(IsValid("[{)]"));