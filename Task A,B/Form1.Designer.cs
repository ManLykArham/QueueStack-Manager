namespace Task_A_B
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddName = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveName = new System.Windows.Forms.Button();
            this.Names = new System.Windows.Forms.RichTextBox();
            this.kvalue = new System.Windows.Forms.TextBox();
            this.reverseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EntriesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(118, 62);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(146, 20);
            this.AddName.TabIndex = 1;
            this.AddName.TextChanged += new System.EventHandler(this.AddName_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(160, 109);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveName
            // 
            this.RemoveName.Location = new System.Drawing.Point(160, 240);
            this.RemoveName.Name = "RemoveName";
            this.RemoveName.Size = new System.Drawing.Size(75, 23);
            this.RemoveName.TabIndex = 3;
            this.RemoveName.Text = "Remove";
            this.RemoveName.UseVisualStyleBackColor = true;
            this.RemoveName.Click += new System.EventHandler(this.RemoveName_Click);
            // 
            // Names
            // 
            this.Names.Location = new System.Drawing.Point(496, 186);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(169, 148);
            this.Names.TabIndex = 8;
            this.Names.Text = "";
            // 
            // kvalue
            // 
            this.kvalue.Location = new System.Drawing.Point(364, 62);
            this.kvalue.Name = "kvalue";
            this.kvalue.Size = new System.Drawing.Size(146, 20);
            this.kvalue.TabIndex = 10;
            // 
            // reverseBtn
            // 
            this.reverseBtn.Location = new System.Drawing.Point(394, 109);
            this.reverseBtn.Name = "reverseBtn";
            this.reverseBtn.Size = new System.Drawing.Size(75, 23);
            this.reverseBtn.TabIndex = 11;
            this.reverseBtn.Text = "Reverse";
            this.reverseBtn.UseVisualStyleBackColor = true;
            this.reverseBtn.Click += new System.EventHandler(this.reverseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Entries:";
            // 
            // EntriesTextBox
            // 
            this.EntriesTextBox.Location = new System.Drawing.Point(598, 62);
            this.EntriesTextBox.Name = "EntriesTextBox";
            this.EntriesTextBox.Size = new System.Drawing.Size(30, 20);
            this.EntriesTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Reverse Name:";
            // 
            // RemoveTextBox
            // 
            this.RemoveTextBox.Location = new System.Drawing.Point(118, 186);
            this.RemoveTextBox.Name = "RemoveTextBox";
            this.RemoveTextBox.Size = new System.Drawing.Size(146, 20);
            this.RemoveTextBox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Remove Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemoveTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EntriesTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reverseBtn);
            this.Controls.Add(this.kvalue);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.RemoveName);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddName;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveName;
        private System.Windows.Forms.RichTextBox Names;
        private System.Windows.Forms.TextBox kvalue;
        private System.Windows.Forms.Button reverseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EntriesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RemoveTextBox;
        private System.Windows.Forms.Label label4;
    }
}

