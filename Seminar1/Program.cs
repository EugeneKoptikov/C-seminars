int a, b;
Console.WriteLine("Программа для сравнения двух чисел, и нахождения среди них наибольшего. Для продолжения нажмите ENTER");
Console.ReadLine();
Console.WriteLine("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите еще число для сравнения: ");
b = Convert.ToInt32(Console.ReadLine());

if (a > b) 
{
	Console.Write("Наибольшее число - ");
	Console.Write(a);
}

if (a < b) 
{
	Console.Write("Наибольшее число - ");
	Console.WriteLine(b);
}

if (a == b) 
{
	Console.WriteLine("Введеные чила равны.");
}
