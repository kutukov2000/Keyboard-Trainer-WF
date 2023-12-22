namespace kerboard_trainer
{
    public partial class HistoryForm : Form
    {
        public HistoryForm(List<ResultClass> results)
        {
            InitializeComponent();

            if (results.Count <= 0)
            {
                return;
            }

            int averadgeWPM = 0;
            int averadgeAccuracy = 0;

            foreach (ResultClass result in results)
            {
                historyListBox.Items.Add(result);
                averadgeWPM += result.Wpm;
                averadgeAccuracy += result.Accuracy;
            }

            wpmLabel.Text = (averadgeWPM / results.Count).ToString();
            accuracyLabel.Text = (averadgeAccuracy / results.Count).ToString();
        }
    }
}
