using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dinglemouse.Int123(500);
        }
    }
    public static class Dinglemouse
    {
        public static long Int123(int a)
        {
            uint a1 = (uint)a;
            long b = 123 - a1;
            return b;
        }
    }
}
