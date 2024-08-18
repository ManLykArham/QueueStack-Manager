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
            EntriesTextBox.Text = Convert.ToString(myqueue.NumItems());
            Names.Text = myqueue.DisplayQueue();
        }

        private void AddName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RemoveName_Click(object sender, EventArgs e)
        {          
            myqueue.Remove(RemoveTextBox.Text);
            EntriesTextBox.Text = Convert.ToString(myqueue.NumItems());
            Names.Text = myqueue.DisplayQueue();
        }

        private void ShowName_Click(object sender, EventArgs e)
        {
           
        }

        private void reverseBtn_Click(object sender, EventArgs e)
        {
            // Checks if the input is a valid integer
            int kValue;
            if (!int.TryParse(kvalue.Text, out kValue))
            {
                // Shows a message box indicating that the input format is incorrect
                MessageBox.Show("Please enter a valid integer for the reverse value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exits the method to prevent further operations
            }

            // Proceeds with the reversal if the input is valid
            myqueue.Reverse(kValue);
            Names.Text = myqueue.DisplayQueue();
        }


        private void entries_Click(object sender, EventArgs e)
        {

        }
    }
}
