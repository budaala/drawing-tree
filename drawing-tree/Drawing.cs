using System;

namespace drawing_tree
{
    internal class Drawing
    {
        public void DrawTree(int numberOfFloors)
        {
            int numberOfStars = 1;
            char star = '*';
            char space = ' ';
            int numberOfSpaces = numberOfFloors;

            for (int i = 0; i < numberOfFloors; i++)
            {
                for (int j = numberOfSpaces; j > 0; j--)
                {
                    Console.Write(space);
                }
                for (int k = 0; k < numberOfStars; k++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
                numberOfStars = numberOfStars + 2;
                numberOfSpaces--;
            }
            for (int i = 0; i < numberOfFloors; i++)
            {
                Console.Write(space);
            }
            Console.Write("#");
            Console.WriteLine();
        }
    }
}
