﻿
Console.WriteLine("введите номер числа недели");
int a = Convert.ToInt32(Console.ReadLine());
if (a ==1){Console.WriteLine("Это понедельник");}
if (a ==2){Console.WriteLine("Это вторник");}
if (a ==3){Console.WriteLine("Это среда");}
if (a ==4){Console.WriteLine("Это четверг");}
if (a ==5){Console.WriteLine("Это пятница");}
if (a ==6){Console.WriteLine("Это суббота");}
if (a ==7){Console.WriteLine("Это воскресенье");}
else if (a<1||a>7){Console.WriteLine("Это не день недели");}