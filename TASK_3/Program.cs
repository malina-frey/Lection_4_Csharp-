﻿/*
определить функцию(метод)Б которая будет принимать числоБ факториал которого нужно вычислить
*/

double Factorial(int n)  //в int переполнение данных, поэтому меняем на double - этот тип позволяет хранить такие данные
{
    if (n == 1) return 1;  //1!=1   0!=1
    else return n * Factorial(n - 1);  //взять факториал предыдущего числа

}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}