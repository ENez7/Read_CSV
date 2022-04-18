List<string> usernames = new List<string>();
List<string> comments = new List<string>();

Console.WriteLine("sda");
Console.ReadLine();

using (var reader = new StreamReader(@"C:\Users\enriq\Desktop\comments-columns.csv"))
{
    while (!reader.EndOfStream)
    {
        string line = reader.ReadLine()!;
        var values = line.Split(';');
        usernames.Add(values[0]);
        comments.Add(values[1]);
    }
    reader.Close();
}

print(usernames);
Console.WriteLine("===============================");
print(comments);

Console.ReadLine();

void print(List<string> list)
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}