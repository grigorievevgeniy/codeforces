using System;

public class Program
{
    static void Main()
    {
        var countTests = int.Parse(Console.ReadLine());

        for (int t = 0; t < countTests; t++)
        {
            var roomSize = Console.ReadLine().Split(" ");
            var coordinats = Console.ReadLine().Split(" ");

            var w = int.Parse(roomSize[0]);
            var d = int.Parse(roomSize[1]);
            var h = int.Parse(roomSize[2]);

            var a = int.Parse(coordinats[0]);
            var b = int.Parse(coordinats[1]);
            var f = int.Parse(coordinats[2]);
            var g = int.Parse(coordinats[3]);

            var result = h;

            int[] array = new int[4];
            array[0] = b + g + Math.Abs(a - f); //down
            array[1] = (d - b) + (d - g) + Math.Abs(a - f); //up

            array[2] = a + f + Math.Abs(b - g); //left
            array[3] = (w - a) + (w - f) + Math.Abs(b - g); //right

            int tmpMin = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (tmpMin > array[i])
                {
                    tmpMin = array[i];
                }
            }

            result += tmpMin;

            Console.WriteLine(result);
        }
    }
}