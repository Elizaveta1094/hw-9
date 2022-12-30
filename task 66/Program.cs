// Задача 66;
// Задайте значение M и N. Напишитн программу, которая найдет сумму натуральных  
// элементов в промежутке от M до N.

int Stepen (int a, int b)
{
    if (a == b)
    {
        return a; 
    }
return a+Stepen(a+1, b);
}
Console.WriteLine("Введите первое число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число В: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Stepen(a,b));