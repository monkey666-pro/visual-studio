// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(digui(5));
static int digui(int num)
{
    return num + digui(num - 1);
}
static int fb(int n)
{
    return fb(n - 1) + fb(n -2);
}