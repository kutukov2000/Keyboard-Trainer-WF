namespace kerboard_trainer
{
    partial class HistoryForm
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
            historyListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            wpmLabel = new Label();
            accuracyLabel = new Label();
            SuspendLayout();
            // 
            // historyListBox
            // 
            historyListBox.FormattingEnabled = true;
            historyListBox.ItemHeight = 20;
            historyListBox.Location = new Point(31, 79);
            historyListBox.Name = "historyListBox";
            historyListBox.Size = new Size(323, 264);
            historyListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(128, 18);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 1;
            label1.Text = "HISTORY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun-ExtB", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(469, 18);
            label2.Name = "label2";
            label2.Size = new Size(147, 28);
            label2.TabIndex = 2;
            label2.Text = "STATISTIC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(394, 98);
            label3.Name = "label3";
            label3.Size = new Size(184, 31);
            label3.TabIndex = 3;
            label3.Text = "Averadge WPM: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(394, 146);
            label4.Name = "label4";
            label4.Size = new Size(218, 31);
            label4.TabIndex = 4;
            label4.Text = "Averadge accuracy: ";
            // 
            // wpmLabel
            // 
            wpmLabel.AutoSize = true;
            wpmLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            wpmLabel.Location = new Point(630, 98);
            wpmLabel.Name = "wpmLabel";
            wpmLabel.Size = new Size(27, 31);
            wpmLabel.TabIndex = 5;
            wpmLabel.Text = "0";
            // 
            // accuracyLabel
            // 
            accuracyLabel.AutoSize = true;
            accuracyLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            accuracyLabel.Location = new Point(630, 146);
            accuracyLabel.Name = "accuracyLabel";
            accuracyLabel.Size = new Size(27, 31);
            accuracyLabel.TabIndex = 6;
            accuracyLabel.Text = "0";
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 367);
            Controls.Add(accuracyLabel);
            Controls.Add(wpmLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(historyListBox);
            Name = "HistoryForm";
            Text = "HistoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox historyListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label wpmLabel;
        private Label accuracyLabel;
    }
}