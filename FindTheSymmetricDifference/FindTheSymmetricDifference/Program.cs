using System;
using System.Collections.Generic;
using System.Linq;

namespace FindTheSymmetricDifference
{
    internal class Program
    {
        private static readonly int[] Seta  = {1, 2, 3};
        private static readonly int[] Setb = { 5, 2, 1, 4 };

        public static void Main(string[] args)
        {

            HashSet<int> resultSet = CheckDifference(Seta, Setb);
            
            PrintResultSet(resultSet);
            
        }

        #region static methods

        private static HashSet<int> CheckDifference(int[] seta, int[] setb)
        {

            HashSet<int> resultSet = new HashSet<int>();
            
            //Check if  SetA does not contain elements of SetB
            foreach (var item in Setb)
            {
                if (!Seta.Contains(item))
                {
                    resultSet.Add(item);
                }
            }

            //Checls if SetB does not contain elements of SetB
            foreach (var item in Seta)
            {
                if (!Setb.Contains(item))
                {
                    resultSet.Add(item);
                }
            }
            
            return resultSet;
        }

        private static void PrintResultSet(HashSet<int> resultSet)
        {
            foreach (var item in resultSet)
            {
                Console.Write($" {item.ToString()}");
            }
        }
        
        
        #endregion
        
        


       
    }
}