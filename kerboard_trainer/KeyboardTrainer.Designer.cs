namespace kerboard_trainer
{
    partial class KeyboardTrainer
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
            components = new System.ComponentModel.Container();
            text_label = new Label();
            richTextBox1 = new RichTextBox();
            timer_label = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timeNumericUpDown = new NumericUpDown();
            languageComboBox = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            regenerateButton = new Button();
            historyButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            wordsNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)timeNumericUpDown).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wordsNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // text_label
            // 
            text_label.AutoSize = true;
            text_label.Dock = DockStyle.Fill;
            text_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            text_label.ForeColor = SystemColors.Control;
            text_label.Location = new Point(0, 0);
            text_label.Name = "text_label";
            text_label.Size = new Size(119, 41);
            text_label.TabIndex = 0;
            text_label.Text = "Words: ";
            text_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ControlDark;
            richTextBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(16, 111);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(747, 210);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // timer_label
            // 
            timer_label.AutoSize = true;
            timer_label.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            timer_label.ForeColor = Color.Orange;
            timer_label.Location = new Point(722, 67);
            timer_label.Name = "timer_label";
            timer_label.Size = new Size(47, 38);
            timer_label.TabIndex = 2;
            timer_label.Text = "15";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timeNumericUpDown
            // 
            timeNumericUpDown.Location = new Point(10, 45);
            timeNumericUpDown.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            timeNumericUpDown.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            timeNumericUpDown.Name = "timeNumericUpDown";
            timeNumericUpDown.Size = new Size(97, 27);
            timeNumericUpDown.TabIndex = 6;
            timeNumericUpDown.Value = new decimal(new int[] { 15, 0, 0, 0 });
            timeNumericUpDown.ValueChanged += timeNumericUpDown_ValueChanged;
            // 
            // languageComboBox
            // 
            languageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            languageComboBox.FormattingEnabled = true;
            languageComboBox.Items.AddRange(new object[] { "ENG", "UA" });
            languageComboBox.Location = new Point(135, 44);
            languageComboBox.Name = "languageComboBox";
            languageComboBox.Size = new Size(151, 28);
            languageComboBox.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(timer_label);
            panel1.Controls.Add(regenerateButton);
            panel1.Location = new Point(12, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 340);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(text_label);
            panel2.Location = new Point(16, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(694, 84);
            panel2.TabIndex = 2;
            // 
            // regenerateButton
            // 
            regenerateButton.BackColor = Color.Transparent;
            regenerateButton.BackgroundImage = keyboard_trainer.Properties.Resources.reloading;
            regenerateButton.BackgroundImageLayout = ImageLayout.Stretch;
            regenerateButton.Location = new Point(722, 23);
            regenerateButton.Name = "regenerateButton";
            regenerateButton.Size = new Size(41, 41);
            regenerateButton.TabIndex = 10;
            regenerateButton.UseVisualStyleBackColor = false;
            regenerateButton.Click += regenerateButton_Click;
            // 
            // historyButton
            // 
            historyButton.Location = new Point(661, 23);
            historyButton.Name = "historyButton";
            historyButton.Size = new Size(120, 40);
            historyButton.TabIndex = 11;
            historyButton.Text = "History";
            historyButton.UseVisualStyleBackColor = true;
            historyButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 12;
            label1.Text = "Time: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 12);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 13;
            label2.Text = "Language: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 12);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 14;
            label3.Text = "Count of words: ";
            // 
            // wordsNumericUpDown
            // 
            wordsNumericUpDown.Location = new Point(314, 45);
            wordsNumericUpDown.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            wordsNumericUpDown.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            wordsNumericUpDown.Name = "wordsNumericUpDown";
            wordsNumericUpDown.Size = new Size(97, 27);
            wordsNumericUpDown.TabIndex = 15;
            wordsNumericUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // KeyboardTrainer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(wordsNumericUpDown);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(historyButton);
            Controls.Add(panel1);
            Controls.Add(languageComboBox);
            Controls.Add(timeNumericUpDown);
            Name = "KeyboardTrainer";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)timeNumericUpDown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)wordsNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label text_label;
        private RichTextBox richTextBox1;
        private Label timer_label;
        private System.Windows.Forms.Timer timer1;
        private NumericUpDown timeNumericUpDown;
        private ComboBox languageComboBox;
        private Panel panel1;
        private Panel panel2;
        private Button regenerateButton;
        private Button historyButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown wordsNumericUpDown;
    }
}