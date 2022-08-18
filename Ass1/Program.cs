// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да//

int input = ReadInt("Введите пятизначное число: ");
int last = input % 10;
int count = 10000;
while(count > 100)
{
        if(last == input / count % 10 && input > 10)
        {
            input = input - last*count;
            last = input / 10 % 10;
            count = count / 10;
            Console.WriteLine("Yes");
            break;
        }
        else
        {
        Console.WriteLine("No");
        break;
        }

}




int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}