/*
что же есть рекурсия?
Фибоначчи
1 1 2 3 5 8 13 21
f(n)=f(n-1)+f(n-2)

Каждое следующее число задается через+- предыдущее.
Выведим эти числа
*/

// f(1)=1
//f(2)=1
//f(n)=f(n-1)+f(n-2)
//напишем это кодом

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 50; i++)  //например первые 50 чисел
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}