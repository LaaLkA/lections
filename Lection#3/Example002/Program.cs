// Цикл for
// Вид 1
string Method4(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(5, "A");
System.Console.WriteLine(res);

// Вид 2
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i}x{j}={i*j}");
    }
    System.Console.WriteLine();
}