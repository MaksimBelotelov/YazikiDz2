// Программа выводит третью цифру числа или сообщает, что третьей
// цифры нет

Console.WriteLine("Введите число: ");
int num=int.Parse(Console.ReadLine());
int numcopy=num;
int den=1;
int i=0, j=0;

while(numcopy!=0) //считаем количество цифр в числе
{
    i++;
    numcopy/=10;
}

if(i<3) // Если в числе меньше 3 цифр, третьей цифры нет     
    Console.WriteLine($"В числе {num} нет третьей цифры");
else
{
    Console.WriteLine($"В числе {num} {i} цифр");
    while(j<(i-3)) //получаем нужную степень 10 для знаменателя
    {
        den*=10;
        j++;
    }
    Console.WriteLine("Третья цифра: "+(num/den) % 10);
}
