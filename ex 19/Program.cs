int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());
int n4 = Convert.ToInt32(Console.ReadLine());
int n5 = Convert.ToInt32(Console.ReadLine());


int[] num = {n1, n2, n3, n4, n5};

if (num[0] == num[4] | num[1]==num[3])
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}