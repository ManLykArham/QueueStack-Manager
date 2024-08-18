using System.Text;
using System;
using System.Windows.Forms;

namespace Task_A_B
{
    class Queue
    {
        // MaxSize of the array
        private readonly int maxsize = 10;
        // Array holding data
        private string[] store;
        // Position of the head
        private int head = 0;
        // Position of the tail
        private int tail = 0;
        // Number of items in the queue
        private int numItems = 0;

        // Returns the number of items in the queue
        public int NumItems()
        {
            return numItems;
        }

        // Constructor to initialize the queue with a default size of 10
        public Queue()
        {
            store = new string[maxsize];
        }

        // Constructor to initialize the queue with a custom size
        public Queue(int size)
        {
            maxsize = size;
            store = new string[maxsize];
        }

        // Adds a new item to the tail of the queue
        public string Enqueue(string value)
        {
            // Checks if the input value is empty or null
            if (string.IsNullOrWhiteSpace(value))
            {
                // Shows a message box indicating that the value cannot be empty
                MessageBox.Show("Cannot add an empty item to the queue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Returns null or some other indication that the operation was not successful
            }

            // Checks if the queue is full
            if (numItems == maxsize)
            {
                MessageBox.Show("Queue is full", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            // Stores the value at the tail position and move the tail position forward
            store[tail] = value;
            tail = (tail + 1) % maxsize;
            numItems++;

            // Returns the added value
            return value;
        }


        // Removes and returns the item at the head of the queue
        public string Dequeue()
        {
            // Checks if the queue is empty
            if (numItems == 0)
            {
                // Shows a message box indicating the queue is empty
                MessageBox.Show("Queue is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Exits the method to prevent further operations
            }


            // Retrieves the item at the head position and clear the value
            string headItem = store[head];
            store[head] = null;
            head = (head + 1) % maxsize;
            numItems--;

            // Returns the removed item
            return headItem;
        }

        // Removes a specific item from the queue
        public void Remove(string item)
        {
            bool found = false;

            // Loops through the queue to find the item
            for (int i = 0; i < maxsize; i++)
            {
                if (store[i] == item)
                {
                    store[i] = null;
                    found = true;
                    numItems--;
                    break;
                }
            }

            if (!found)
            {
                // Shows a message box indicating the item was not found
                MessageBox.Show("Item not found in the queue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Shifts all elements after the removed item forward
            for (int i = 0; i < maxsize - 1; i++)
            {
                if (store[i] == null && store[i + 1] != null)
                {
                    store[i] = store[i + 1];
                    store[i + 1] = null;
                }
            }

            // Adjusting head and tail if necessary
            head = store[0] == null ? (head + 1) % maxsize : head;
            tail = (head + numItems) % maxsize;
        }

        // Returns a string representation of the queue's contents
        public string DisplayQueue()
        {
            StringBuilder names = new StringBuilder();

            // Loops through the queue
            for (int i = 0; i < maxsize; i++)
            {
                if (!string.IsNullOrEmpty(store[i]))
                {
                    names.Append(store[i]);
                    names.Append("\n");
                }
            }

            // Returns the string of names
            return names.ToString();
        }

        // Reverses a portion of the queue using a stack
        public void Reverse(int value)
        {
            // Validate the range to reverse
            if (value > numItems)
            {
                // Shows a message box indicating the value exceeds the number of items in the queue
                MessageBox.Show("Value exceeds the number of items in the queue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exits the method to prevent further operations
            }

            Stack mystack = new Stack();  // Creates a new stack

            // Pushes the specified number of items onto the stack
            for (int i = 0; i < value; i++)
            {
                mystack.Push(Dequeue());
            }

            // Pops items off the stack and enqueue them back into the queue
            while (mystack.NumItems() > 0)
            {
                Enqueue(mystack.Pop());
            }
        }
    }
}
