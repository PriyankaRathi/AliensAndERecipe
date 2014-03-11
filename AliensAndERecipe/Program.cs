using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliensAndERecipe
{
    class Program
    {
        static int N, Q;
        static List<List<int>> aliens;
        static List<List<int>> list;

        static void Main(string[] args)
        {
            getData();
            getResults();
            Console.Read();
        }

        private static void getResults()
        {
            Console.WriteLine();
            Console.WriteLine("Output:");
            
            foreach (List<int> alien in aliens)
            {
                alien.RemoveAt(0);
                int result = 0;
                foreach (List<int> interval in list)
                {
                    var cnt = from a in alien
                              where a >= interval[0] && a < interval[1]
                              select a;
                    if (cnt.Count() > 0)
                        result++;
                }
                Console.WriteLine(result);
            }
        }

        private static void getData()
        {
            Console.WriteLine("Input:");
            N = Convert.ToInt32(Console.ReadLine()); //Number of recipes
            int n = N;
            list = new List<List<int>>();
            while (n != 0)			      // N recipes live time interval
            {
                string[] s = Console.ReadLine().Split(' ');
                list.Add(Array.ConvertAll(s, a => int.Parse(a)).ToList());
                n--;
            }
            Q = Convert.ToInt32(Console.ReadLine());	// Number of Alien groups
            int q = Q;

            aliens = new List<List<int>>();
            while (q != 0)
            {
                string[] s = Console.ReadLine().Split(' ');	//Input is no. aliens in gorup time for each alien when they visit earth
                aliens.Add(Array.ConvertAll(s, a => int.Parse(a)).ToList());
                q--;
            }
        }
    }
}

/*

Sample Input - 
4
1 4
3 10
2 6
5 8
3
1 5
2 2 6
3 1 10 9

Output:
3
4
2

Explanation:
Given videos of 4 recipes in the following closed intervals.
1. [ 1 , 4 ]
2. [ 3 , 10 ]
3. [ 2 , 6 ]
4. [ 5 , 8 ]
In the first query, only one alien arrives at t = 5 and can download 3 recipes 2, 3, 4.
In the second query, two aliens arrive at t = 2 and 6. They can learn all the 4 recipes.
In the third query, three aliens arrive at t = 1, 10 and 9. They can learn only two recipes, 1 and 2.

*/