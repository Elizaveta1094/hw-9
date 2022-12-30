// Задача 64
// Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1.
//Решить с помощью рекурсии.
void Numbers (int num)
{
    if(num == 0)
    {
        return;
    }
    Console.WriteLine($"{num}"); // вывод в обратный порядок. Сначала выводит, потом уменьшает
    Numbers(num - 1);
}
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Numbers(a);