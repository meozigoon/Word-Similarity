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
        private string filePath = "D:\\Machine Learning\\cc.ko.300.bin"; // 모델 경로

        public WordSimilarity()
        {
            InitializeComponent();
            fastText = new FastTextWrapper();
            fastText.LoadModel(filePath);
            string path = @"D:\\Machine Learning\\wordList-utf8.txt";
            string randomWord = RandomWordSelector.GetRandomWord(path);
            GivenWord.Text = randomWord; // 초기 단어 설정
        }

        private void WordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var vector = fastText.GetWordVector(WordInput.Text);
                var givenVector = fastText.GetWordVector(GivenWord.Text);
                // (도쿄 - 일본 + 한국)과 서울 벡터 비교 -> 56.8%
                // var vector1 = fastText.GetWordVector("도쿄");
                // var vector2 = fastText.GetWordVector("일본");
                // var vector3 = fastText.GetWordVector("한국");
                // var givenVector = fastText.GetWordVector("서울");
                // var vector = fastText.GetWordVector("서울");
                // for (int i = 0; i < vector.Length; i++)
                // {
                //     givenVector[i] = vector1[i] - vector2[i] + vector3[i]; // 벡터 연산
                // }

                double norm = 0, givenNorm = 0;
                double dot = 0;
                for (int i = 0; i < vector.Length; i++)
                {
                    dot += vector[i] * givenVector[i];
                    norm += vector[i] * vector[i];
                    givenNorm += givenVector[i] * givenVector[i];
                }
                Score.Text = (dot / Math.Sqrt(norm * givenNorm) * 100).ToString("F1") + "%"; // 점수 계산

                // 벡터 내용 확인 (모두 출력)
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

        private void Reset_Click(object sender, EventArgs e) // 버튼 클릭시 랜덤으로 단어 초기화
        {
            string path = @"D:\\Machine Learning\\wordList-utf8.txt";
            string randomWord = RandomWordSelector.GetRandomWord(path);
            GivenWord.Text = randomWord;
        }
    }
}
