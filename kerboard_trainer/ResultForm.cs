namespace kerboard_trainer
{
    public partial class ResultForm : Form
    {
        public ResultForm(ResultClass result)
        {
            InitializeComponent();

            wpmLabel.Text = result.Wpm.ToString();
            accuracyLabel.Text = result.Accuracy.ToString() + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
