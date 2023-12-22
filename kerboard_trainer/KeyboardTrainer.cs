using System.Xml.Serialization;

namespace kerboard_trainer
{
    public partial class KeyboardTrainer : Form
    {
        private List<ResultClass> resultsList = new List<ResultClass>();

        private DateTime _start;
        private bool isTimed = false;
        private int _duration = 15;
        private int errorCount;

        public KeyboardTrainer()
        {
            InitializeComponent();
            LoadHistory();

            _duration = (int)timeNumericUpDown.Value;
            languageComboBox.Text = "ENG";

            text_label.Text = ReadWords((int)wordsNumericUpDown.Value);
        }

        public string ReadWords(int countOfWords)
        {
            string filePath = "";

            if (languageComboBox.SelectedItem == "ENG")
                filePath = Path.Combine(Environment.CurrentDirectory, @"Words\english.txt");
            else
                filePath = Path.Combine(Environment.SystemDirectory, @"Words\ukrainian.txt");

            string[] words = File.ReadAllLines(filePath);
            Random rand = new Random();
            string result = "";

            for (int i = 0; i < countOfWords; i++)
            {
                if (i == countOfWords / 2)
                {
                    int index = rand.Next(words.Length);
                    result += words[index] + "\n ";
                }
                else
                {
                    int index = rand.Next(words.Length);
                    result += words[index] + " ";
                }
            }

            return result;
        }

        private void HighlightErrors(string expected, RichTextBox inputTextBox)
        {
            errorCount = 0;

            int cursorPosition = inputTextBox.SelectionStart;

            inputTextBox.SelectionStart = 0;
            inputTextBox.SelectionLength = inputTextBox.Text.Length;
            inputTextBox.SelectionColor = Color.Black;

            expected = expected.Replace("\n", "");
            for (int i = 0; i < inputTextBox.Text.Length; i++)
            {
                if (inputTextBox.Text[i] == expected[i])
                {
                    continue;
                }

                inputTextBox.SelectionStart = i;
                inputTextBox.SelectionLength = 1;
                inputTextBox.SelectionColor = Color.Red;

                errorCount++;
            }
            inputTextBox.ForeColor = Color.Black;
            inputTextBox.SelectionStart = cursorPosition;
        }

        private void Regenerate()
        {
            richTextBox1.Enabled = true;
            richTextBox1.Clear();

            text_label.Text = ReadWords((int)wordsNumericUpDown.Value);

            timer1.Stop();
            isTimed = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (isTimed == false)
            {
                _start = DateTime.Now;
                timer1.Start();
                isTimed = true;
            }

            HighlightErrors(text_label.Text, richTextBox1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = DateTime.Now - _start;
            timer_label.Text = duration.ToString("ss");

            if (duration.TotalSeconds <= _duration && richTextBox1.Text.Length != text_label.Text.Length - 2)
            {
                return;
            }

            timer1.Stop();
            richTextBox1.Enabled = false;
            isTimed = false;

            int countOfWords = richTextBox1.Text.Split(' ').Count();

            int wpm = countOfWords * (60 / (int)duration.TotalSeconds);
            int accuracy = (int)(((double)(richTextBox1.Text.Length - errorCount) / richTextBox1.Text.Length) * 100);

            ResultClass result = new(wpm, accuracy, languageComboBox.Text);

            ResultForm form = new ResultForm(result);
            form.Show();

            resultsList.Add(result);
        }

        public void LoadHistory()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<ResultClass>));

            string path = Path.Combine(Environment.CurrentDirectory, "history.xml");

            StreamReader reader = new StreamReader(path);
            resultsList = (List<ResultClass>)serializer.Deserialize(reader);
            reader.Close();
        }

        private void timeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _duration = (int)timeNumericUpDown.Value;
        }

        private void regenerateButton_Click(object sender, EventArgs e)
        {
            Regenerate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<ResultClass>));

            string path = Path.Combine(Environment.CurrentDirectory, "history.xml");

            StreamWriter writer = new StreamWriter(path);
            serializer.Serialize(writer, resultsList);
            writer.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HistoryForm form = new HistoryForm(resultsList);
            form.Show();
        }
    }
}