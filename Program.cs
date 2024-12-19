using System.ComponentModel;
using System.Text.Json;

class Program
{
    static void Main()
    {   
        List<int> numbers = new() {11, 9, 3, 12, 15, 5, 2,3, 3};
        List<int> output = new List<int>();
        

        for (int i = 0; i < numbers.Count; i++)
        {
            
            for (int j = 0; j < numbers.Count-1; j++)
            {
                if(numbers[j]>numbers[j+1]){
                    int temp = numbers[j];
                    numbers[j] = numbers[j+1];
                    numbers[j+1] = temp;
                }
            }
        }

        Console.WriteLine(string.Join(",",numbers));

    }
}

