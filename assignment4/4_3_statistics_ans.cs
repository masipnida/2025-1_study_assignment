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

            for(int i = 1; i <= stdCount; i++)
            {
                m_average += data[i, 2];
                s_average += data[i, 3];
                e_average += data[i, 4];
            }
            m_average /= stdCount;
            s_average /= stdCount;
            e_average /= stdCount;

            string m = m_average.ToString("#.##");
            string s = s_average.ToString("#.##");
            string e = e_average.ToString("#.##");

            Console.WriteLine($"Average Scores:\nMath: " + m + "\nScience: " + s + "\nEnglish: " + e);

            double[] max = new double[3];
            double[] min = new double[3];

            for (int i = 0; i < 3; i++)
            {
                max[i] = data[1, 2 + i];
                min[i] = data[1, 2 + i];
                for(int j = 2; j <= stdCount; j++)
                {
                    if (max[i] < data[j, 2 + i])
                    {
                        max[i] = data[j, 2 + i];
                    }
                    if (min[i] > data[j, 2 + i])
                    {
                        min[i] = data[j, 2 + i]; 
                    }
                }
            }

            Console.WriteLine($"Max and min Scores:\nMath: ({max[0]}, {min[0]})\nScience: ({max[1]}, {min[1]})\nEnglish: ({max[2]}, {min[2]})");

            string[] rank = new string[stdCount];
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
