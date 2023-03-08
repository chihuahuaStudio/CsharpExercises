/*
 * This program returns the Symmetric difference of  two given sets
 * Might add menu and mor set operations
 */


using System;
using System.Collections.Generic;

namespace FindTheSymmetricDifference
{
    internal class Program
    {
        // TODO Add menu
        // TODO Add more set operations
        
        public static void Main(string[] args)
        {
            Console.WriteLine("This programs calculates the Symmetric difference between two sets");
            Console.Write("Please Enter a set of numbers: ");
            string setAString = Console.ReadLine();
            Console.Write("Please Enter a second set of numbers: ");
            string setBString = Console.ReadLine();
            PrintSymmetricDifferenceSet(SymmetircDifference(CreateSet(setAString), CreateSet(setBString)));
        }

        #region static methods

        private static HashSet<int> CreateSet(string intputSet)
        {
            HashSet<int> resultedSet = new HashSet<int>();

            foreach (var element in intputSet)
            {
                resultedSet.Add(Convert.ToInt32(element.ToString()));
            }

            return resultedSet;
        }

        /// <summary>
        /// Checks the symmetric difference of the two sets give as arguments
        /// </summary>
        /// <param name="seta"></param>
        /// <param name="setb"></param>
        /// <returns></returns>
        private static HashSet<int> SymmetircDifference(HashSet<int> seta, 
            HashSet<int> setb)
        {

            HashSet<int> resultSet = new HashSet<int>();
            
            //Check if  SetA does not contain elements of SetB
            foreach (var item in setb)
            {
                if (!seta.Contains(item))
                {
                    resultSet.Add(item);
                }
            }

            //Checls if SetB does not contain elements of SetB
            foreach (var item in seta)
            {
                if (!setb.Contains(item))
                {
                    resultSet.Add(item);
                }
            }
            
            return resultSet;
        }

        /// <summary>
        /// Prints the resulted set
        /// </summary>
        /// <param name="resultSet">the set to be printed</param>
        private static void PrintSymmetricDifferenceSet(HashSet<int> resultSet)
        {

            //Perhaps there is a better way to sort the set.
            SortedSet<int> sortedSet = new SortedSet<int>();
            foreach (var elem in resultSet)
            {
                sortedSet.Add(elem);
            }
            
            Console.Write("The resulted set is: ");
            foreach (var item in sortedSet)
            {
                Console.Write($" {item.ToString()}");
            }
            
            Console.WriteLine();
        }

        private static void PrintSet(HashSet<int> set, char setRank)
        {
            Console.Write($"Set{setRank.ToString()} is: ");
            foreach (var elem in set)
            {
                Console.Write(elem);
            }
            Console.WriteLine();
        }
        
        
        #endregion
        
        


       
    }
}