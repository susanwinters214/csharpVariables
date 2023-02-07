using System.Text.RegularExpressions;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
      
            string name = "Susan";
            int age = 99;
         
            bool isHungry = true;
           double weight = 150.50;
           decimal balance = 12875.25m;
           char section = 'W';


            Console.WriteLine($"A lady named {name} is {age} today and it is {isHungry} that she is hungry! She is in section {section}.  She weighs {weight} and has a bank balance of {balance}. ");
           

            Console.ReadLine();
            
        }
    }
}
