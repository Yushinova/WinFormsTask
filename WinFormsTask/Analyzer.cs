using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsTask
{
    public class Analyzer
    {
        public string Text { get; set; }
        public int GetCountSentences()//количество предложений
        {
            string text = Text;
            string[] sentences = Regex.Split(text, @"(?<=[\.\!\?])\s+", RegexOptions.IgnoreCase);//крутая тема находит предложения по паттерну
            return sentences.Length;
        }
        public int GetCountSymbols()//считаем количество символов без пробелов
        {
            string text = Text;
            text = text.Replace(" ", "");
            return text.Length;
        }
        public int GetCountWords()//количество слов
        {
            string text = Text;
            //помещает в коллекцию все что соответствует регулярном выраению
            MatchCollection words = Regex.Matches(text, @"\w+", RegexOptions.IgnoreCase);
            return words.Count;

        }
        public int GetCountQuestions()//количество вопросительных предложений
        {
            string text = Text;           
            MatchCollection questions = Regex.Matches(text, @"\?+", RegexOptions.IgnoreCase);
            return questions.Count;
        }

        public int GetCountExclamations()//количество восклицательных предложений
        {
            string text = Text;
            MatchCollection exclamations = Regex.Matches(text, @"\!+", RegexOptions.IgnoreCase);
            return exclamations.Count;
        }
     
    }
}
