List<string> usernames = new List<string>();
List<string> comments = new List<string>();

// Add your CSV's path
var pathCSV = @"";

using (var reader = new StreamReader(pathCSV))
{
    while (!reader.EndOfStream)
    {
        // Example made with two-column CSV
        string line = reader.ReadLine()!;
        var values = line.Split(';');
        // Add more lists and columns as you need
        usernames.Add(values[0]);
        comments.Add(values[1]);
    }
    reader.Close();
}

Console.ReadLine();

void print(List<string> list)
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}