/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

/*Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = A;
for (int i = 1; i < B; i++)
{result *= A;}
Console.WriteLine($"А в степени В = {result}");*/

int exp(int num, int deg)
{
    int result = num;
    for (int i = 1; i < deg; i++)
    {
        result *= num;
    }
    return result;
}
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int res = exp(A , B);
Console.WriteLine($"А в степени В = {res}");