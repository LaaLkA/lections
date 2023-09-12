// // =====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "К" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

Console.Clear();

string text = "- Я думаю, - сказать князь, улыбаясь, - что,"
            + " ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string NewText = Replace(text, ' ', '|');
System.Console.WriteLine(NewText);

System.Console.WriteLine();

NewText = Replace(NewText, 'к','К');
System.Console.WriteLine(NewText);

System.Console.WriteLine();

NewText = Replace(NewText, 'с','С');
System.Console.WriteLine(NewText);