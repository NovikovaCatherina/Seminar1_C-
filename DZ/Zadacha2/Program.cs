Console.WriteLine("Введи 2 числа и мы тебе скажем какое из них больше");
int a, b;
Console.WriteLine("Введи свое первое число a ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи свое второе число b ");
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Число " + a + " больше чем " + b);
}
else if (a == b)
{
    Console.WriteLine("Числа " + a + " и " + b + " равны");
}
else
{
    Console.WriteLine("Число " + b + " больше чем " + a);
}

