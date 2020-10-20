using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Less7Ex1
{
    public partial class BnBGame : Form
    {
        TrueFalse gameDB;

        public int QuestionIndex { get; set; } = 1;
        public int DBIndex { get; set; }
        public int GameDBCount { get; set; }
        public bool UserAnswer { get; set; }
        public bool BaseAnswer { get; set; }
        public int RightAnswersCount { get; set; } = 0;
        public int WrongAnswersCount { get; set; } = 0;

        public BnBGame()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            
            panel1.Visible = true;
            btnStartGame.Visible = false;
            LoadGameBase();
            GameDBCount = gameDB.Count;
            GetQuestion();
        }

        private void LoadGameBase()
        {
            gameDB = new TrueFalse("myDB");
            gameDB.Load();
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            GetQuestion();
            UserAnswer = true;
            CompareAnswers(UserAnswer, BaseAnswer);
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            GetQuestion();
            UserAnswer = false;
            CompareAnswers(UserAnswer, BaseAnswer);
            
        }

        private void GetQuestion()
        {
            Random random = new Random();
            DBIndex = random.Next(0, gameDB.Count);
            label2.Text = $"{QuestionIndex} из {GameDBCount}";
            lblQuestion.Text = gameDB[DBIndex].text;
            BaseAnswer = gameDB[DBIndex].trueFalse;
            QuestionIndex++;
            gameDB.Remove(DBIndex);
        }

        private void CompareAnswers(bool userValue, bool baseValue)
        {
            if (userValue == baseValue)
            {
                RightAnswersCount++;
                lblTrueAnswerCount.Text = RightAnswersCount.ToString();
            }
            else
            {
                WrongAnswersCount++;
                lblFalseAnswerCount.Text = WrongAnswersCount.ToString();
            }
        }
        
    }
}
