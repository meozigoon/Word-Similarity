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
        private string filePath = "cc.ko.300.bin"; // 모델 경로

        public WordSimilarity()
        {
            InitializeComponent();
            fastText = new FastTextWrapper();
            fastText.LoadModel(filePath);
            GivenWord.Text = "사과"; // 초기 단어 설정
        }

        private void WordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var vector = fastText.GetWordVector(WordInput.Text);
                var givenVector = fastText.GetWordVector(GivenWord.Text);
                var score = Math.Abs(vector[0] - givenVector[0]);
                Score.Text = $"Score: {score:F2}";
            }
        }
    }
}
