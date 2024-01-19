using System;
using System.ComponentModel.Design;
using System.Text;
class Program
{
    static void Main()
    {
        StringBuilder stringBuilder = new StringBuilder();
        int sideLength = default;
        int starsCounter = 1;
        char emptySpace = ' ';
        char diamondPart = '*';

        Console.WriteLine("Please entry a int number for a side length value :");

        if (int.TryParse(Console.ReadLine(), out sideLength) && (sideLength >= 3))
        {
            for (int i = 0; i < sideLength; i++)
            {
                for (int k = i; k < sideLength / 2; k++)
                {
                    stringBuilder.Append(emptySpace);
                }

                for (int j = 0; j < starsCounter; j++)
                {
                    stringBuilder.Append(diamondPart);
                }

                if (starsCounter >= sideLength)
                {
                    stringBuilder.Append('\n');
                    starsCounter -= 2;
                    break;
                }

                starsCounter += 2;
                stringBuilder.Append('\n');
            }

            for (int i = 0; i < sideLength; i++)
            {
                for (int k = 0; k < i + 1; k++)
                {
                    stringBuilder.Append(emptySpace);
                }

                for (int j = 0; j < starsCounter; j++)
                {
                    stringBuilder.Append(diamondPart);
                }

                starsCounter -= 2;
                stringBuilder.Append('\n');
            }

            Console.WriteLine(stringBuilder);
        }
        else
        {
            Console.WriteLine("Wrong Value! :\nGive a value between 3 and infinity");
            return;
        }
    }
}



