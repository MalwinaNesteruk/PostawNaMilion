using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostawNaMilion
{
    internal static class InputData
    {
        public static string connString = "Data Source=localhost;Initial Catalog=Pytania;Integrated Security=True;Connect Timeout=30";
        public static int amountLeft = 1000000;
        public static List<int> losts = new List<int>();
        public static int counter = 1;
    }
}
