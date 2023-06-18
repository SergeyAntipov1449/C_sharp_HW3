// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string digits = Convert.ToString(number);
if(number.ToString().Length != 5 )
{  
    System.Console.WriteLine("Число не явлется пятизначным");
}
else if (digits[0]==digits[4] && digits[1]==digits[3])
{
    System.Console.WriteLine("Полнидромом");
}
else
{
    System.Console.WriteLine("Число не является является полнидромом");
}
