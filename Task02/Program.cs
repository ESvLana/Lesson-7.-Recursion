// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int functionAkkerman = Akkerman(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0)
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return Akkerman(m - 1, Ack(m, n - 1));
        }
    }
}
