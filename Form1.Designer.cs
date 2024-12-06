namespace Backpropagation
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox10 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            tabPage2 = new TabPage();
            textBox9 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(826, 467);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox10);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(818, 434);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Logic OR";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(272, 217);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(101, 27);
            textBox10.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(101, 27);
            textBox1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(240, 48);
            label3.Name = "label3";
            label3.Size = new Size(317, 37);
            label3.TabIndex = 16;
            label3.Text = " Logic OR Gate operation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 124);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 15;
            label2.Text = "Inputs:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 124);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 14;
            label1.Text = "Result:";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(527, 282);
            button3.Name = "button3";
            button3.Size = new Size(83, 43);
            button3.TabIndex = 13;
            button3.Text = "Test";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(330, 282);
            button2.Name = "button2";
            button2.Size = new Size(177, 43);
            button2.TabIndex = 12;
            button2.Text = "Train the Neural Net";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(195, 282);
            button1.Name = "button1";
            button1.Size = new Size(120, 43);
            button1.TabIndex = 11;
            button1.Text = "Create BPNN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox3
            // 
            textBox3.AcceptsReturn = true;
            textBox3.BackColor = Color.White;
            textBox3.Location = new Point(424, 172);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(101, 27);
            textBox3.TabIndex = 10;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox9);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(textBox8);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(818, 434);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Logic AND";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(449, 150);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.ScrollBars = ScrollBars.Vertical;
            textBox9.Size = new Size(266, 170);
            textBox9.TabIndex = 28;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(145, 249);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(101, 27);
            textBox7.TabIndex = 27;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(145, 216);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(101, 27);
            textBox8.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(232, 39);
            label4.Name = "label4";
            label4.Size = new Size(337, 37);
            label4.TabIndex = 25;
            label4.Text = " Logic AND Gate operation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 123);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 24;
            label5.Text = "Inputs:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(303, 123);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 23;
            label6.Text = "Result:";
            // 
            // button4
            // 
            button4.Location = new Point(518, 347);
            button4.Name = "button4";
            button4.Size = new Size(83, 43);
            button4.TabIndex = 22;
            button4.Text = "Test";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(321, 347);
            button5.Name = "button5";
            button5.Size = new Size(177, 43);
            button5.TabIndex = 21;
            button5.Text = "Train the Neural Net";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(186, 347);
            button6.Name = "button6";
            button6.Size = new Size(120, 43);
            button6.TabIndex = 20;
            button6.Text = "Create BPNN";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox4
            // 
            textBox4.AcceptsReturn = true;
            textBox4.BackColor = Color.White;
            textBox4.Location = new Point(303, 150);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(101, 27);
            textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(145, 183);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(101, 27);
            textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(145, 150);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(101, 27);
            textBox6.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 491);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Backpropagation";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TabPage tabPage2;
        private Label label2;
        private Label label3;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox1;
    }
}
