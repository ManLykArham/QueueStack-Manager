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

        // Pushes a value onto the stack
        public void Push(string value)
        {
            array[top++] = value;
        }

        // Pops a value off the stack
        public string Pop()
        {
            top--;
            string item = array[top];
            array[top] = null;
            return item;
        }

        // Returns the number of items currently in the stack
        public int NumItems()
        {
            return top;
        }
    }
}
