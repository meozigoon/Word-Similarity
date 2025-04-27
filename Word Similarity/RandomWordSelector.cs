﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Similarity
{
    public class RandomWordSelector
    {
        private static readonly Random rnd = new Random();

        public static string GetRandomWord(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("지정한 파일을 찾을 수 없습니다.", filePath);

            string content = File.ReadAllText(filePath);
            char[] separators = new char[] { ' ', '\n', '\r', '\t' };
            string[] words = content.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
                throw new InvalidOperationException("파일에 단어가 없습니다.");

            int index = rnd.Next(words.Length);
            return words[index];
        }
    }
}
