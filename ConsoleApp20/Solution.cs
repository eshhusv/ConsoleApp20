using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Solution
    {
        private string[] text = Array.Empty<string>();
        private static string temp = "";
        public Solution(string[] text)
        {
            Text = text;
        }

        public string[] Text { get; set; }

        public string[] getSolution(string[] text)
        {
            temp = text[0];
            text[0] = text[text.Length - 1];
            text[text.Length - 1] = temp;
            return text;
        }
    }
}
