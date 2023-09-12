// Вид 1 (ничего не принимают и не возвращают)
void Method1()
{
    System.Console.WriteLine("Автор Никита Афонченков");
}
Method1();//Вызов

// Вид 2 (ничего не возвращают, но могут принимать какие-то аргументы)
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения Вид 2");

// Вид 2.1 Если нужно принять более 1 аргумента
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст 2.1", 4); // 1 способ вызова
Method21(count: 4, msg: "Текст 2.1");

// Вид 3 (не принимает аргументы, только возвращает)
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);

// Вид 4 (что-то принимают и что-то возвращают)
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "A");
System.Console.WriteLine(res);
