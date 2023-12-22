namespace kerboard_trainer
{
    [Serializable]
    public class ResultClass
    {
        public int Wpm { get; set; }
        public int Accuracy { get; set; }
        public string Language { get; set; }

        public ResultClass()
        {
            Wpm = 0;
            Accuracy = 0;
            Language = string.Empty;
        }

        public ResultClass(int wpm, int accurancy, string language)
        {
            Wpm = wpm;
            Accuracy = accurancy;
            Language = language;
        }

        public override string ToString()
        {
            return $"WPM {Wpm} | Accuracy {Accuracy}% | {Language}";
        }
    }
}
