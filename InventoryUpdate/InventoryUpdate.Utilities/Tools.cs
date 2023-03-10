using System;
using System.Collections.Generic;

namespace InventoryUpdate.Utilities
{
    public static class Tools
    {
        public static List<int> GenerateRandomNumberList()
        {
            List<int> listOfNumbers = new List<int>();
            Random random = new Random();
            Random randomMax = new Random();
            int randomNumber;

            for (int i = 0; i < randomMax.Next(1, 18); i++)
            {
                do
                {
                    randomNumber = random.Next(0, 18);
                } while (listOfNumbers.Contains(randomNumber));
            
                listOfNumbers.Add(randomNumber);
            }
            
            return listOfNumbers;
        }
    }
}