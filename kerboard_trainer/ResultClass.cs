using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kerboard_trainer
{
    [Serializable]
    public class ResultClass
    {
        public int wpm { get; set; }
        public int accuracy { get; set; }
        public string language { get; set; }
        public override string ToString()
        {
            return $"WPM {wpm} : {accuracy} : {language}";
        }
    }
}
