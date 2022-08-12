Console.WriteLine("Введите 3 числа и мы тебе скажем какое из них больше");
int a, b, c;
int max = 0;
Console.WriteLine("Введите свое первое число a ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите свое второе число b ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите свое третье число с ");
c = Convert.ToInt32(Console.ReadLine());

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("max = "); 
Console.WriteLine(max);
