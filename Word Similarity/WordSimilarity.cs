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
        private string filePath = "D:\\Machine Learning\\cc.ko.300.bin"; // �� ���

        public WordSimilarity()
        {
            InitializeComponent();
            fastText = new FastTextWrapper();
            fastText.LoadModel(filePath);
            string path = "D:\\Machine Learning\\Word Similarity\\wordList-utf8.txt";
            string randomWord = RandomWordSelector.GetRandomWord(path);
            GivenWord.Text = randomWord; // �ʱ� �ܾ� ����
        }

        private void WordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var vector = fastText.GetWordVector(WordInput.Text);
                var givenVector = fastText.GetWordVector(GivenWord.Text);
                // (���� - �Ϻ� + �ѱ�)�� ���� ���� �� -> 56.8% (���� ����) - ����Ȯ
                // (�Ϻ� - ����) �� (�ѱ� - ����) ���� �� -> 77.3% (���� ����)
                // var vector1 = fastText.GetWordVector("����");
                // var vector2 = fastText.GetWordVector("����");
                // var vector3 = fastText.GetWordVector("��");
                // var givenVector = fastText.GetWordVector("����");
                // var vector = fastText.GetWordVector("����");
                // for (int i = 0; i < vector.Length; i++)
                // {
                //     givenVector[i] = vector2[i] - vector1[i]; // ���� ����
                //     vector[i] = vector3[i] - vector[i]; // ���� ����
                // }

                double norm = 0, givenNorm = 0;
                double dot = 0;
                for (int i = 0; i < vector.Length; i++)
                {
                    dot += vector[i] * givenVector[i];
                    norm += vector[i] * vector[i];
                    givenNorm += givenVector[i] * givenVector[i];
                }
                Score.Text = ((dot / Math.Sqrt(norm * givenNorm) + 1) / 2 * 100).ToString("F1") + "%"; // ���� ���

                // ���� ���� Ȯ�� (��� ���)
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

        private void Reset_Click(object sender, EventArgs e) // ��ư Ŭ���� �������� �ܾ� �ʱ�ȭ
        {
            string path = "D:\\Machine Learning\\Word Similarity\\wordList-utf8.txt";
            string randomWord = RandomWordSelector.GetRandomWord(path);
            GivenWord.Text = randomWord;
        }
    }
}
