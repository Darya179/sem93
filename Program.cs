//Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());

string GetNat(int a1, int b1)
{
    
            if (a1 == b1)
            {
                return a1.ToString();
            }
            return a1 + " " + GetNat(a1 + 1, b1);
       

}
Console.WriteLine(GetNat(n, m));
