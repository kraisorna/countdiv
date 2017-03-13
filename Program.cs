using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.solution(11,345,17));
            Console.ReadLine();
        }
    }

    class Solution {
        public int solution(int A, int B, int K) {
            int num = 0;
            num = (B / K) - (A / K);
            if ((A % K)==0)
                num++;
            return num;
        }
    }
}
