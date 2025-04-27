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
        private string filePath = "D:\\cc.ko.300.bin"; // �� ���

        public WordSimilarity()
        {
            InitializeComponent();
            fastText = new FastTextWrapper();
            fastText.LoadModel(filePath);
            GivenWord.Text = "���"; // �ʱ� �ܾ� ����
        }

        private void WordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var vector = fastText.GetWordVector(WordInput.Text);
                var givenVector = fastText.GetWordVector(GivenWord.Text);
                var score = Math.Abs(vector[0] - givenVector[0]);
                Score.Text = ((1 - score) * 100).ToString("F3");
            }
        }
    }
}
