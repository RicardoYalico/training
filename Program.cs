using System.ComponentModel;
using System.Text.Json;

class Program
{
    static void Main()
    {   
        string input = Console.ReadLine();

        if(input.Length <= Math.Pow(10,3)){
            string output = input[0].ToString().ToUpper() + input.Remove(0,1);

            Console.WriteLine(output);
        }

    }
}

