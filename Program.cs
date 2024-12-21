using System.ComponentModel;
using System.Text.Json;

class Program
{
    static void Main()
    {   
        string input = Console.ReadLine();

        if(input.Length <= 100){

            List<string> letters = new List<string>();

            foreach (var letter in input)
            {
                if(!letters.Contains(letter.ToString()))
                    letters.Add(letter.ToString());
            }

            if(letters.Count%2 == 0){
                Console.WriteLine("CHAT WITH HER!");
            } else {
                Console.WriteLine("IGNORE HIM!");
            }

        }

    }
}

