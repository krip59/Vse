Console.Clear();
Console.WriteLine("Введите первое число");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
int numberb = Convert.ToInt32(Console.ReadLine());
if ((numbera == numberb*numberb)|(numberb == numbera*numbera))
{
Console.Write("Да");
}
else {Console.Write("Нет");
}