namespace Exercise4._5;

class Program
{
    static void Main(string[] args)
    {
        #nullable disable
        string message = "";
        
        Console.WriteLine("Welcome to Exercise 4.5 Pre Learning!");
        Console.WriteLine("      Is number Square Root?");
        Console.WriteLine("=====================================");

        Console.WriteLine();
        Console.Write("Please type an integer: ");
        int number = int.Parse(Console.ReadLine());
        message = String.Format("No square root for {0}", number);
        
        for (int i = 0; i < number; i++)
        {
            if(i * i == number){
                message = String.Format("The square root of {0} is {1}", number, i);
                break;
            }
        } 
        Console.WriteLine(message);
    }
}
