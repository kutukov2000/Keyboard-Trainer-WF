using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kerboard_trainer
{
    public partial class HistoryForm : Form
    {
        public HistoryForm(List<ResultClass> results)
        {
            InitializeComponent();
            if (results.Count > 0)
            {
                int averadgeWPM = 0;
                int averadgeAccuracy = 0;
                foreach (ResultClass result in results)
                {
                    historyListBox.Items.Add(result);
                    averadgeWPM += result.wpm;
                    averadgeAccuracy += result.accuracy;
                }
                wpmLabel.Text = (averadgeWPM / results.Count).ToString();
                accuracyLabel.Text = (averadgeAccuracy / results.Count).ToString();
            }
        }
    }
}
