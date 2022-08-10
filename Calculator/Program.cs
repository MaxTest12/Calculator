namespace Calculator 
{
    class Program
    {
        static void Main(string[] args)
        {   
            // first number 
            Console.WriteLine("Wpisz pierwszą liczbę:");
              float num_1 = Convert.ToSingle(Console.ReadLine());
            // operator 
            Console.WriteLine("Wpisz Operator:");
            Console.WriteLine("1 - Dodawanie");
            Console.WriteLine("2 - Odejmowanie");
            Console.WriteLine("3 - Mnożenie");
            Console.WriteLine("4 - Dzielenie");
            Console.WriteLine("5 - Dzielenie z resztą");
              int operators = Convert.ToInt32(Console.ReadLine());
            // second number
            Console.WriteLine("Wpisz drugą liczbę:");
              float num_2 = Convert.ToSingle(Console.ReadLine());
          switch(operators)
          {
            case 1:
              Console.WriteLine(num_1 + num_2); 
              break;
            case 2:
              Console.WriteLine(num_1 - num_2);
              break;
            case 3:
              Console.WriteLine(num_1 * num_2);
              break;
            case 4:
              Console.WriteLine(num_1 / num_2);
              break;
            case 5:
              Console.WriteLine(num_1 % num_2);
              break;
          }
        }
    }
}