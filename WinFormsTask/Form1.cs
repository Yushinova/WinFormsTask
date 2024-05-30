using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WinFormsTask
{
    public partial class Form1 : Form
    {
        public Analyzer analyzer;
        public List<string> AllInfo;//помещаем все результаты в лист
        public Form1()
        {
            InitializeComponent();
        }
        private async Task GoProgress()//прогресс бар
        {
            for (int i = 0; i < 10; i++)
            {
                ProgressAnalyse.PerformStep();
                await Task.Delay(500);
            }
            ProgressAnalyse.Visible = false;
            MessageBox.Show("Анализ текста завершен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private async void Analyse_Click(object sender, EventArgs e)
        {
            AllInfo = new List<string>();
            if (MyText.Text != "")
            {
                analyzer = new Analyzer { Text = MyText.Text };

                ProgressAnalyse.Visible = true;
             
                AllInfo.Add("Count sentences: " + await Task.Run(analyzer.GetCountSentences));
                AllInfo.Add("Count words: " + await Task.Run(analyzer.GetCountWords));
                AllInfo.Add("Count symbols: " + await Task.Run(analyzer.GetCountSymbols));
                AllInfo.Add("Count questions sentences: " + await Task.Run(analyzer.GetCountQuestions));
                AllInfo.Add("Count exclamations sentences: " + await Task.Run(analyzer.GetCountExclamations));
                await GoProgress();
              
                VisibleButtons();
            }
        }
        private void VisibleButtons()
        {
            OutputButton.Visible = true;
            SaveButton.Visible = true;
            TryButton.Visible = true;
        }

        private void OutputButton_Click(object sender, EventArgs e)//выводим результат в новой форме
        {
            Form2 form = new Form2(AllInfo);
            form.Show();
        }

        private void TryButton_Click(object sender, EventArgs e)//сбрасываем все настройки
        {
            AllInfo.Clear();
            OutputButton.Visible = false;
            SaveButton.Visible = false;
            TryButton.Visible = false;
            ProgressAnalyse.Value = 0;
            MyText.Text = string.Empty;

        }

        private void SaveButton_Click(object sender, EventArgs e)//запись в txt
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog1.FileName;
                StreamWriter myStream = new StreamWriter(filename);
                foreach (var item in AllInfo)
                {
                    myStream.WriteLine(item);
                }
                myStream.Close();
                MessageBox.Show("Файл сохранен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
