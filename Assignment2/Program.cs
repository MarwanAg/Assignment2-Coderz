//decleration + initialization
Dictionary<char, int> dictionary = new Dictionary<char, int>();
Console.WriteLine("Enter the word: ");
string text = Convert.ToString(Console.ReadLine());   //string text = "successfully";
int counter = 0;
bool exists = false;

//processing
foreach (char ch1 in text)
{
    counter = 0;
    exists = false;
    foreach (char ch2 in text)
    {
        if (ch1 == ch2)
        {
            counter++;
        }
    }
    foreach (var item in dictionary)
    {
        if (item.Key == ch1)
        {
            exists = true;
            break;
        }

    }
    if (!exists)
    {
        dictionary.Add(ch1, counter);
    }
}

//print
foreach (var item in dictionary)
{
    Console.WriteLine($"{item.Value} : {item.Key}");
}