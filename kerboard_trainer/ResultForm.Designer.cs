namespace kerboard_trainer
{
    partial class ResultForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            wpmLabel = new Label();
            accuracyLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(129, 24);
            label1.Name = "label1";
            label1.Size = new Size(102, 41);
            label1.TabIndex = 0;
            label1.Text = "Result";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 105);
            label2.Name = "label2";
            label2.Size = new Size(101, 38);
            label2.TabIndex = 1;
            label2.Text = "WPM: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 174);
            label3.Name = "label3";
            label3.Size = new Size(145, 38);
            label3.TabIndex = 2;
            label3.Text = "Accuracy: ";
            // 
            // wpmLabel
            // 
            wpmLabel.AutoSize = true;
            wpmLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            wpmLabel.Location = new Point(212, 105);
            wpmLabel.Name = "wpmLabel";
            wpmLabel.Size = new Size(96, 38);
            wpmLabel.TabIndex = 3;
            wpmLabel.Text = "label4";
            // 
            // accuracyLabel
            // 
            accuracyLabel.AutoSize = true;
            accuracyLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            accuracyLabel.Location = new Point(212, 174);
            accuracyLabel.Name = "accuracyLabel";
            accuracyLabel.Size = new Size(96, 38);
            accuracyLabel.TabIndex = 4;
            accuracyLabel.Text = "label5";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(115, 245);
            button1.Name = "button1";
            button1.Size = new Size(116, 46);
            button1.TabIndex = 5;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 315);
            Controls.Add(button1);
            Controls.Add(accuracyLabel);
            Controls.Add(wpmLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Result";
            Text = "Result";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label wpmLabel;
        private Label accuracyLabel;
        private Button button1;
    }
}