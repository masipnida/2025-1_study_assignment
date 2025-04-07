using System;
using System.Linq;

namespace statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] data = {
                {"StdNum", "Name", "Math", "Science", "English"},
                {"1001", "Alice", "85", "90", "78"},
                {"1002", "Bob", "92", "88", "84"},
                {"1003", "Charlie", "79", "85", "88"},
                {"1004", "David", "94", "76", "92"},
                {"1005", "Eve", "72", "95", "89"}
            };
            // You can convert string to double by
            // double.Parse(str)

            int stdCount = data.GetLength(0) - 1;
            // ---------- TODO ----------
            double m_average = 0;
            double s_average = 0;
            double e_average = 0;

            for(int i = 1; i < stdCount; i++)
            {
                m_average += data[i, 2];
                s_average += data[i, 3];
                e_average += data[i, 4];
            }
            m_average /= stdCount;
            s_average /= stdCount;
            e_average /= stdCount;

            Console.WriteLine("Math: "+m_average);
            Console.WriteLine("Average Scores:");
            Console.WriteLine("Average Scores:");
            Console.WriteLine("Average Scores:");
            // --------------------
        }
    }
}

/* example output

Average Scores: 
Math: 84.40
Science: 86.80
English: 86.20

Max and min Scores: 
Math: (94, 72)
Science: (95, 76)
English: (92, 78)

Students rank by total scores:
Alice: 2nd
Bob: 5th
Charlie: 1st
David: 4th
Eve: 3rd

*/
