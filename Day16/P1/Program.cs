namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int count=0,avg=0;
            for (int i = 0; i < 10; i++)
            {
                Random A= new Random();
                int num = A.Next(1,50);
                list.Add(num);
            }
            Console.WriteLine("所有元素：");
            foreach (int i in list)
            {
                count += i;
                Console.Write($"{i}-");
            }
            avg=count/list.Count;
            Console.WriteLine($"-总和:{count}-平均值:{avg}");
        }
    }
}
