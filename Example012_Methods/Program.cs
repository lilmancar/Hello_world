﻿// Вид 1
void Method1()
{
    Console.WriteLine("Автор Лев");
}
//Method1();
// Вид 2
void Method2(string msq)
{
Console.WriteLine(msq);
}
//Method2(msq: "Текст сообщения");

void Method21(string msq, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msq);
        i++;
    }
}
//Method21(msq: "Текст", 4);
//Method21(count: 4, msq: "новый текст");
// Вид3
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

// Вид 4

///string Method4(int count, string text)
//{
//int i = 0;
//string result = String.Empty;
//while (i < count)
//{
//    result = result + text;
//    i++;
//}
//return result;
//}
//string res = Method4(10, "");
//Console.WriteLine(res);

string Method4(int count, string text)
{

string result = String.Empty;
for( int i = 0; i < count; i++) 
{
    result = result + text;
}
return result;
}
string res = Method4(10, "z");
//Console.WriteLine(res);

for (int i = 2; i <=10; i++)
{
    for (int j = 2; j <=10; j++)
    {
    Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
