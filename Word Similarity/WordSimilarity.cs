using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastText.NetWrapper;

namespace Word_Similarity
{
    public partial class WordSimilarity : Form
    {
        private FastTextWrapper fastText;
        private string filePath = "D:\\cc.ko.300.bin"; // 모델 경로

        public WordSimilarity()
        {
            InitializeComponent();
            fastText = new FastTextWrapper();
            fastText.LoadModel(filePath);
            GivenWord.Text = "이름"; // 초기 단어 설정
        }

        private void WordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var vector = fastText.GetWordVector(WordInput.Text);
                var givenVector = fastText.GetWordVector(GivenWord.Text);
                double norm = 0, givenNorm = 0;
                double dot = 0;
                for (int i = 0; i < vector.Length; i++)
                {
                    dot += vector[i] * givenVector[i];
                    norm += vector[i] * vector[i];
                    givenNorm += givenVector[i] * givenVector[i];
                }
                Score.Text = (dot / Math.Sqrt(norm * givenNorm) * 100).ToString("F1") + "%";


                // label1.Text = vector.Length.ToString() + " " + givenVector.Length.ToString() + "\n";
                // foreach (var i in vector)
                // {
                //     label1.Text += i.ToString() + " ";
                // }
                // label1.Text += "\n";
                // foreach (var i in givenVector)
                // {
                //     label1.Text += i.ToString() + " ";
                // }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            string path = @"D:\\wordList.txt";
            string randomWord = RandomWordSelector.GetRandomWord(path);
            GivenWord.Text = randomWord;
        }
    }
}
