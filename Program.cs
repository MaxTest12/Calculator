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
              string operators = Console.ReadLine();
            // second number
            Console.WriteLine("Wpisz drugą liczbę:");
              float num_2 = Convert.ToSingle(Console.ReadLine());
            // Sum
            if(operators == "+")
            {
              Console.WriteLine(num_1+num_2);  
            }   
            // substraction 
            else if(operators == "-")
            {
              Console.WriteLine(num_1 - num_2);
            }    
            // multiplication
            else if(operators == "*")
            {
              Console.WriteLine(num_1 * num_2);
            }
            // divide 
            else if(operators == ":")
            {
              Console.WriteLine(num_1 / num_2);
            }
            //Modulo
            else if(operators == "%")
            {
              Console.WriteLine(num_1 % num_2);
            }
            else 
            {
              Console.WriteLine("nie ma takiego operatora");
            }
        }
    }
}