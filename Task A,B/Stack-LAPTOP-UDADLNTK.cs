using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A_B
{
    internal class Stack
    {
        private const int maxsize = 10;
        private int top = 0;
        private string[] array = new string[maxsize];

        public void Push(string value)
        {
            array[top] = value;
            top++;
        }

        public string Pop()
        {
            top--;
            return array[top];
        }
    }
}
