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

        public int QuestionIndex { get; set; } = 0;
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
            QuestionIndex++;
            panel1.Visible = true;
            btnStartGame.Visible = false;
            LoadGameBase();
            GameDBCount = gameDB.Count;
            GetQuestion();
        }

        private void LoadGameBase()
        {
            gameDB = new TrueFalse("newBD");
            gameDB.Load();
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            UserAnswer = true;
            CheckAnswer(UserAnswer, BaseAnswer);
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            UserAnswer = false;
            CheckAnswer(UserAnswer,BaseAnswer);
        }

        private void CheckAnswer(bool userValue, bool baseValue)
        {
            if (gameDB.Count > 0)
            {
                QuestionIndex++;
                GetQuestion();
                CompareAnswers(userValue, baseValue);
            }
            else if (gameDB.Count == 0)
            {
                CompareAnswers(userValue, baseValue);
                btnFalse.Enabled = false;
                btnTrue.Enabled = false;
            }
        }

        private void GetQuestion()
        {
            
            Random random = new Random();
            DBIndex = random.Next(0, gameDB.Count);
            label2.Text = $"{QuestionIndex} из {GameDBCount}";
            textBoxQuestion.Text = gameDB[DBIndex].text;
            BaseAnswer = gameDB[DBIndex].trueFalse;
            gameDB.Remove(DBIndex);
        }

        private void CompareAnswers(bool userValue, bool baseValue)
        {
            if (userValue == baseValue)
            {
                RightAnswersCount++;
                lblTrueCount.Text = RightAnswersCount.ToString();
                lblCompareResult.ForeColor = Color.Green;
                lblCompareResult.Text = "V";
            }
            else
            {
                WrongAnswersCount++;
                lblFalseCount.Text = WrongAnswersCount.ToString();
                lblCompareResult.ForeColor = Color.Red;
                lblCompareResult.Text = "X";
            }
        }
        
    }
}
