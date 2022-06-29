int a, b;
Console.WriteLine("Программа для сравнения двух чисел, и нахождения среди них наибольшего. Для продолжения нажмите ENTER");
Console.ReadLine();
Console.WriteLine("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите еще число для сравнения: ");
b = Convert.ToInt32(Console.ReadLine());

if (a > b) 
{
	Console.WriteLine("Наибольшее число - " + a);
	Console.WriteLine("Наименьшее число - " + b);
}

if (a < b) 
{
	Console.WriteLine("Наибольшее число - " + b);
	Console.WriteLine("Наименьшее число - " + a);
}

if (a == b) 
{
	Console.WriteLine("Введеные чиcла равны.");
}
