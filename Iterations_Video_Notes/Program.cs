using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //iterations for int arrays and string arrays


        //        int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //        for (int i = 0; i < testScores.Length; i++)
        //        {
        //            if (testScores[i] > 85)
        //            {
        //                Console.WriteLine("Passing Test Score;  " + testScores[i]);
        //            }
        //        }

        //        Console.ReadLine();
        //            }


        //                string[] names = { "Jesse", "Erik", "Levi", "Jordan", "Tony", "LaurieSue" };

        //            for (int j = 0; j < names.Length; j++)
        //            {
        //                //  if (names[j] =="Jesse") would pick out only "Jesse " from the array
        //                {
        //                    Console.WriteLine(names[j]); // without the if statement above it will show all of the naes in the array...cool!
        //                }
        //            }



        //                        //iterations for LISTS

        //                        List<int> testScores1 = new List<int>();
        //                        testScores1.Add(98);
        //                        testScores1.Add(7);
        //                        testScores1.Add(88);
        //                        testScores1.Add(91);
        //                        testScores1.Add(76);
        //                        testScores1.Add(86);

        //foreach (int score in testScores1)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + score);
        //    }

        //                        Console.ReadLine();


        //This foreach loop passes the scores from testScores that are greater than 85 to the passingScores list and then counts how many 
        //passing scores there were...
        // Note on naming in foreach loops and Lists: List names are typically plural because ther are more than one entry making it a "List",
        //and then in the foreach look you use the variable part and name it singular indicating you are referring to one of the items in that List..
        //.example passingScores(list name) and score( variable name in the foreach loop referring to the item we are iterating over and checking
        //against the condition set forth in the foreach loop

        List<int> testScores = new List<int>() { 98, 97, 99, 12, 74, 23, 99 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }

        }

        Console.WriteLine(passingScores.Count); // displays that there are 4 passing scores...count is like Length in arrays
        Console.ReadLine();
    }
}
// lists are very useful: they can be used for  passinng info to user in webpages, can be turned into json object ,etc.... 
