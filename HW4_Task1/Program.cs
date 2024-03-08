// Aditi Mahangade
// MIS 3013 005
// HW4 Task 1

// Q2

int n;
Console.Write("n = ? ");
string nStr = Console.ReadLine();
n = Convert.ToInt32(nStr);

int facR = Factorial(n);
string outMesStr = string.Format($"{n}!=");
Console.Write(outMesStr);

for(int i = n; i >= 1; i--)
{
    Console.Write(i);
    for(i >= 2)
    {
        Console.Write('*');
    }
}

outMesStr = string.Format($"= {facR}");
Console.WriteLine(outMesStr);

// Q1

Console.WriteLine("m = ? ");
string mStr = Console.ReadLine();
double m = Convert.ToDouble(mStr);

Console.WriteLine("x = ? ");
string xStr = Console.ReadLine();
double x = Convert.ToDoublexStr);

Console.WriteLine("b = ? ");
string bStr = Console.ReadLine();
double b = Convert.ToDouble(bStr);

double result = LineValueForY(m,x,b);
outMesStr = string.Format($"Y = {m:F2} * {x:F2} + {b:F2} = {result:F2}");
Console.WriteLine(outMesStr);

// double r2 = LineValueForY(2, 3, 6);
// double r3 = LineValueForY(6, 3, 6);
// double r4 = LineValueForY(10, 3, 6);

Console.ReadKey();

double LineValueForY(double m, double x, double b)
{
    double result = m * x + b;
    return result;
}

// Q2
int Factorial(int N)
{
    int r = 1;
    for(int i = 1; i <= N; i++)
    {
        r = r + i;
    }

    return r;
}