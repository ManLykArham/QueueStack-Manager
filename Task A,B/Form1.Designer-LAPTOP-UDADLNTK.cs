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
            this.label1 = new System.Windows.Forms.Label();
            this.ShowName = new System.Windows.Forms.Button();
            this.Names = new System.Windows.Forms.RichTextBox();
            this.Entries = new System.Windows.Forms.Label();
            this.Reverse = new System.Windows.Forms.Button();
            this.kvalue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(120, 225);
            this.AddName.Margin = new System.Windows.Forms.Padding(6);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(288, 31);
            this.AddName.TabIndex = 1;
            this.AddName.TextChanged += new System.EventHandler(this.AddName_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(536, 225);
            this.AddButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 44);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveName
            // 
            this.RemoveName.Location = new System.Drawing.Point(536, 304);
            this.RemoveName.Margin = new System.Windows.Forms.Padding(6);
            this.RemoveName.Name = "RemoveName";
            this.RemoveName.Size = new System.Drawing.Size(150, 44);
            this.RemoveName.TabIndex = 3;
            this.RemoveName.Text = "Remove";
            this.RemoveName.UseVisualStyleBackColor = true;
            this.RemoveName.Click += new System.EventHandler(this.RemoveName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(780, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // ShowName
            // 
            this.ShowName.Location = new System.Drawing.Point(536, 535);
            this.ShowName.Margin = new System.Windows.Forms.Padding(6);
            this.ShowName.Name = "ShowName";
            this.ShowName.Size = new System.Drawing.Size(180, 52);
            this.ShowName.TabIndex = 7;
            this.ShowName.Text = "Show Names";
            this.ShowName.UseVisualStyleBackColor = true;
            this.ShowName.Click += new System.EventHandler(this.ShowName_Click);
            // 
            // Names
            // 
            this.Names.Location = new System.Drawing.Point(120, 485);
            this.Names.Margin = new System.Windows.Forms.Padding(6);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(334, 281);
            this.Names.TabIndex = 8;
            this.Names.Text = "";
            // 
            // Entries
            // 
            this.Entries.AutoSize = true;
            this.Entries.Location = new System.Drawing.Point(1023, 244);
            this.Entries.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Entries.Name = "Entries";
            this.Entries.Size = new System.Drawing.Size(70, 25);
            this.Entries.TabIndex = 9;
            this.Entries.Text = "label2";
            this.Entries.Click += new System.EventHandler(this.label2_Click);
            // 
            // Reverse
            // 
            this.Reverse.Location = new System.Drawing.Point(536, 388);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(150, 37);
            this.Reverse.TabIndex = 10;
            this.Reverse.Text = "Reverse";
            this.Reverse.UseVisualStyleBackColor = true;
            this.Reverse.Click += new System.EventHandler(this.Reverse_Click);
            // 
            // kvalue
            // 
            this.kvalue.Location = new System.Drawing.Point(153, 388);
            this.kvalue.Margin = new System.Windows.Forms.Padding(6);
            this.kvalue.Name = "kvalue";
            this.kvalue.Size = new System.Drawing.Size(288, 31);
            this.kvalue.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.kvalue);
            this.Controls.Add(this.Reverse);
            this.Controls.Add(this.Entries);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.ShowName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveName);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddName);
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowName;
        private System.Windows.Forms.RichTextBox Names;
        private System.Windows.Forms.Label Entries;
        private System.Windows.Forms.Button Reverse;
        private System.Windows.Forms.TextBox kvalue;
    }
}

