//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Программа для сравнения двух чисел, и нахождения среди них наибольшего. Для продолжения нажмите ENTER");

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите еще число для сравнения: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число для сравнения: ");
int e = Convert.ToInt32(Console.ReadLine());


if (a > b && a > e) 
{
	Console.WriteLine("Наибольшее число - " + a);
}
    else if (a < b && b > e) 
    {
    	Console.WriteLine("Наибольшее число - " + b);
    }
        else if (a < e && b < e) 
        {
	        Console.WriteLine("Наибольшее число - " + e);
        }
            else if (a == b && b == e)
            {
                Console.WriteLine("Введенные числа равны");
            }