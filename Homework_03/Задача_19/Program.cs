Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа принимает на вход пятизначное  число ");
Console.WriteLine("И проверяет, является ли оно палиндромом. ");
Console.WriteLine("Введите пятизначное число : ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 9999 || n > 100000){
    n = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Число не пятизначное ");
     Console.WriteLine("Введите пятизначное число : ");
}

if (Convert.ToString(n)[0] == Convert.ToString(n)[4] && Convert.ToString(n)[1] == Convert.ToString(n)[3]){
Console.WriteLine("Число является палиндромом. ");
} 
else
Console.WriteLine("Число не является палиндромом. ");