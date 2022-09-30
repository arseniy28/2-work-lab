//Чистяков Арсений 22 ИСП 2/2 Вариант 
//Два автомобиля едут навстречу друг другу с постоянными скоростями V1 и V2 км/час. Определить, через какое время автомобили встретятся, если расстояние между ними было S км.


Console.WriteLine("Скорость 1 авто:");
double var1 = double.Parse(Console.ReadLine());
Console.WriteLine("Скорость 2 авто:");
double var2 = double.Parse(Console.ReadLine());
Console.WriteLine("Расстояние:");
double var3 = double.Parse(Console.ReadLine());
var result = var3 / (var1 + var2);
Console.WriteLine($"Автомобили встретятся через={result}");
Console.ReadLine();