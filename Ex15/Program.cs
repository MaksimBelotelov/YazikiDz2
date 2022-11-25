// Программа принимает цифру, обозначающую день недели и проверяет
// является ли он выходным

Console.Clear();

Console.Write("Введите номер дня недели: ");
int num=int.Parse(Console.ReadLine());

if(num > 7 || num < 1) 
    Console.Write("В неделе только 7 дней!");
else
{
    if(num > 0 && num < 6)
        Console.Write("День рабочий");
    else
        Console.Write("День выходной");
}