using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var countTests = int.Parse(Console.ReadLine());

        for (int t = 0; t < countTests; t++)
        {
            var peopleCount = int.Parse(Console.ReadLine());
            var dreams = Console.ReadLine().Split(" ");
            var dreamsArray = new int[peopleCount];

            for (int i = 0; i < dreams.Length; i++)
            {
                dreamsArray[i] = int.Parse(dreams[i]);
            }

            var result = 0;

            var binaryString = new string('1', peopleCount);
            var variantCount = Convert.ToInt32(binaryString, 2);


            for (int i = 0; i <= variantCount; i++)
            {
                var currentResult = true;
                string binary = new string(Convert.ToString(i, 2).Reverse().ToArray());
                var goCount = binary.Count(_ => _ == '1');

                for (int j = 0; j < peopleCount; j++)
                {
                    if (binary.Length < j + 1 || binary[j] == '0') //no going
                    {
                        if (goCount >= dreamsArray[j])
                        {
                            currentResult = false;
                            break;
                        }
                    }
                    else //going
                    {
                        if (goCount < dreamsArray[j] + 1)
                        {
                            currentResult = false;
                            break;
                        }
                    }
                }

                if (currentResult)
                {
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
