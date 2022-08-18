// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int input = ReadInt("Введите число: ");
int count = 1;
while(count <= input)
{
    Console.Write(Cube(count) + " ");
    count++;
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Cube(int x)
{
    return x*x*x;
}