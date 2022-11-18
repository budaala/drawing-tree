using System;

namespace drawing_tree
{
    internal class UserInput
    {
        public int GetNumber(int numOfLayers)
        {
            Console.WriteLine("Number of layers: ");
            try
            {
                numOfLayers = int.Parse(Console.ReadLine());

                return numOfLayers;
            }
            catch
            {
                return 0;
            }
        }
    }
}
