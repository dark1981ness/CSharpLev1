using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less5Ex5
{
    class Program
    {
        struct Question
        {
            public string question;
            public string answer;
        }

        private static Question[] GetQuestions(int count, string path)
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                Question[] questionInfos = new Question[count];
                for (int i = 0; i < count; i++)
                {
                    string[] tempInfo = streamReader.ReadLine().Split(';');
                    questionInfos[i].question = tempInfo[0];
                    questionInfos[i].answer = tempInfo[1];
                }
                return questionInfos;
            }
        }

        private static int LinesCount(string path)
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                int linesCount = 0;
                while (streamReader.ReadLine() != null)
                {
                    linesCount++;
                }
                return linesCount;
            }
        }

        static void Main(string[] args)
        {

            int linesCount;
            var random = new Random();
            string pathToFile = @"..\\..\\data\\data.txt";
            linesCount = LinesCount(pathToFile);
            Question[] task = GetQuestions(linesCount, pathToFile);
            List<Question> tempTask = task.ToList();

        }
    }
}
