// Программа принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа

Console.Clear();

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

if(num/1000!=0||num/100==0) 
    Console.Write("Вы ввели не трехзначное число!");
else
    Console.WriteLine($"Вторая цифра в числе: "+(num%100)/10);