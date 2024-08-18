using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_A_B
{
    public partial class Form1 : Form
    {
        Queue myqueue;
        public Form1()
        {
            myqueue = new Queue();
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            myqueue.Enqueue(AddName.Text);
            label1.Text = AddName.Text;
            Entries.Text = Convert.ToString(myqueue.NumItems());
            Names.Text = myqueue.DisplayQueue();
        }

        private void AddName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RemoveName_Click(object sender, EventArgs e)
        {
            myqueue.Dequeue();
            Entries.Text = Convert.ToString(myqueue.NumItems());
            Names.Text = myqueue.DisplayQueue();
        }

        private void ShowName_Click(object sender, EventArgs e)
        {
            Names.Text = myqueue.DisplayQueue();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Reverse_Click(object sender, EventArgs e)
        {
            myqueue.reverse(Convert.ToInt32(kvalue.Text));
            Names.Text = myqueue.DisplayQueue();

        }
    }
}