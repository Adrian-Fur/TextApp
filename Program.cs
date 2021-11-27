using System.Text;

static string CamelCase(string text)
{
    var splited = text.Split(' ').Select(i => char.ToUpper(i[0]) + i.Substring(1));
    var joined = string.Join("", splited);
    joined = Char.ToLowerInvariant(joined[0]) + joined.Substring(1);
    return joined;
}

static string KebabCase(string input)
{
    var splited = input.Split(' ').Select(i => char.ToLower(i[0]) + i.Substring(1));
    var joined = string.Join("-", splited);
    return joined;
}

static string CamelConverter(string input)
{
    StringBuilder sb = new StringBuilder();

    foreach(char currentChar in input)
    {
        if (char.IsUpper(currentChar))
        {
            sb.Append('-');
            sb.Append(char.ToLower(currentChar));
        }
        else
        {
            sb.Append(currentChar);
        }
    }
    return sb.ToString();
}

static string KebabConverter(string input)
{
    StringBuilder sb = new StringBuilder();

    for(int i = 0; i < input.Length; i++)
    {
        char currentChar = input[i];    

        if(currentChar != '-')
        {
            sb.Append(currentChar);
        }
        else
        {
            char nextChar = input[i + 1];
            sb.Append(nextChar.ToString().ToUpper());
            i++;
        }
    }
    return sb.ToString();   
}

// See https://aka.ms/new-console-template for more information
string input = "";
string result = "";

while (input != "5")

{
    Console.WriteLine("####################");
    Console.WriteLine("Text Application");
    Console.WriteLine("Choose Operation");
    Console.WriteLine("1. Text to camelCase converter");
    Console.WriteLine("2. Text to kebab-case converter");
    Console.WriteLine("3. kebab-case to camelCase converter");
    Console.WriteLine("4. camelCase to kebab-case converter");
    Console.WriteLine("5. Exit");
    Console.WriteLine("####################");

    input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("Enter a text: ");
            input = Console.ReadLine().ToLower();
            result = CamelCase(input);   
            Console.WriteLine($"Text converted to camelCase: {result}");
            Console.WriteLine("");
            break;
        case "2":
            Console.WriteLine("Enter a text: ");
            input = Console.ReadLine().ToLower();
            result = KebabCase(input);
            Console.WriteLine($"Text converted to kebab-case: {result}");
            Console.WriteLine("");
            break;
        case "3":
            Console.WriteLine("Enter a text: ");
            input = Console.ReadLine().ToLower();
            result = KebabConverter(input);
            Console.WriteLine($"kebab-case to camelCase: {result}");
            Console.WriteLine("");
            break;
        case "4":
            Console.WriteLine("Enter a text: ");
            input = Console.ReadLine();
            result = CamelConverter(input);
            Console.WriteLine($"camelCase converted to kebab-case: {result}");
            Console.WriteLine("");
            break;
        case "5":
            Console.WriteLine("Bye Bye");
            break;
        default:
            Console.WriteLine("Wrong input!");
            break;
    }
}

