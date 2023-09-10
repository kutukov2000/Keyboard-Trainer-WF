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
    public partial class ResultForm : Form
    {
        public ResultForm(ResultClass result)
        {
            InitializeComponent();
            wpmLabel.Text = result.wpm.ToString();
            accuracyLabel.Text = result.accuracy.ToString()+"%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
