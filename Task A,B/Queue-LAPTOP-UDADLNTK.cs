using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_A_B
{
    class Queue
    {
        private readonly int maxsize = 10;// MaxSize of the array
        private string[] store;//Array holding data
        private int head = 0;//Position of the head
        private int tail = 0;//Position of the tail
        private int numItems;//Number of items in the queue

        public int NumItems()
        {
            return numItems;  
        }

        public Queue()
        {
            store = new string[maxsize];
        }

        public Queue(int size)
        {
            maxsize = size;
            store = new string[maxsize];
        }

        public string Enqueue(string value)//Add to tail
        {
            numItems++;
            store[tail] = value;
            string name = store[tail];
            if (++tail == maxsize)
            {
                tail = 0;
            };
            //display = Convert.ToString(value);
            return name;

        }

        public string Dequeue()//Remove at head
        {
            numItems--;
            string headItem;
            headItem = store[head];
            store[head] = String.Empty;
            if (++head == maxsize)
            {
                head = 0;
            };

            return headItem;

        }

        public string Peek()
        {
            string headItem;
            headItem = store[head];
            if (++head == maxsize)
            {
                head = 0;
            };
            return headItem;
        }

        public int Length()
        {
            return store.Length;
        }

        public bool IsEmpty()
        {
            return tail != head;
        }

        public bool IsFull()
        {
            return tail == head;
        }

        public string DisplayQueue()
        {
            //StringBuilder sb = new StringBuilder();
            //foreach (string p in store)
            //{
            //    sb.AppendFormat("{0}\n", p);
            //}
            //return sb.ToString();
            StringBuilder names = new StringBuilder();
            for (int i = 0; i < store.Length; i++)
            {
                string name = store[i];
                names.Append(name);
                names.AppendFormat("\n");
            }
            return names.ToString();

        }



        /*StringBuilder rNames = new StringBuilder();
        public string Reverse(int k)
        {
                if (k > 0)
                {
                    //Reverse(k - 1);

                    string name = store[k];
                    rNames.Append(name);
                    rNames.AppendFormat("\n");
                    Reverse(k - 1);

                }
               return rNames.ToString();
        }*/

        public void reverse(int value)
        {
            Stack mystack = new Stack();
            for (int i=0; i<value; i++)
            {
                mystack.Push(Dequeue());
            }
            head = head - value;
            tail = 0;

            for (int i=0; i<value; i++)
            {
                store[i] = Enqueue(mystack.Pop());
            }
        }
    }
    
}

