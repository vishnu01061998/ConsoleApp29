namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter Any Number");
           int num = Convert.ToInt32(Console.ReadLine());
           for (int i = 1; i <= num; ++i)
           {
              if (num % i == 0)
              {
                 Console.WriteLine(i);
              }
           }
        }
        
       
    }
    
}