namespace cont
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            lis2 = new ListBox();
            txt1 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(276, 81);
            button1.Name = "button1";
            button1.Size = new Size(150, 23);
            button1.TabIndex = 0;
            button1.Text = "Add al arreglo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(276, 110);
            button2.Name = "button2";
            button2.Size = new Size(150, 20);
            button2.TabIndex = 1;
            button2.Text = "Show list";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lis2
            // 
            lis2.FormattingEnabled = true;
            lis2.ItemHeight = 15;
            lis2.Location = new Point(-1, -1);
            lis2.Name = "lis2";
            lis2.Size = new Size(219, 454);
            lis2.TabIndex = 2;
            // 
            // txt1
            // 
            txt1.Location = new Point(261, 43);
            txt1.Name = "txt1";
            txt1.Size = new Size(190, 23);
            txt1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(276, 136);
            button3.Name = "button3";
            button3.Size = new Size(150, 20);
            button3.TabIndex = 5;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 450);
            Controls.Add(button3);
            Controls.Add(txt1);
            Controls.Add(lis2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private TextBox txt1;
        private ListView listView1;
        private ListBox lis2;
        private Button button3;
    }
}