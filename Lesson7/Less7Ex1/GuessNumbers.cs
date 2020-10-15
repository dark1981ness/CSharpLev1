using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Less7Ex1
{
    public partial class GuessNumbers : Form
    {
        private int _testTryCount;

        public int TryCount { get; private set; }

        public int EndPoint { get; private set; }

        public int StartPoint { get; private set; }

        public int MyRandomValue { get; private set; }

        public int UserNumber { get; private set; }

        Random random = new Random();

        Regex regex = new Regex(@"\D", RegexOptions.IgnoreCase);

        public GuessNumbers()
        {
            InitializeComponent();
            TryCount = 5;
            StartPoint = 0;
            EndPoint = 100;
        }

        public GuessNumbers(int tryCount, int startPoint, int endPoint)
        {
            InitializeComponent();
            TryCount = tryCount;
            StartPoint = startPoint;
            EndPoint = endPoint;
            _testTryCount = TryCount;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            MyRandomValue = random.Next(StartPoint, EndPoint);
            lblHiddenNumber.Text = "?";
            lblTryCount.Text = TryCount.ToString();
            userNumberTextBox.Enabled = true;
            btnUserTurn.Enabled = true;
            btnStartGame.Enabled = false;
            
        }

        private void btnUserTurn_Click(object sender, EventArgs e)
        {
            UserNumber = int.Parse(userNumberTextBox.Text);
            lblUserNumber.Text = UserNumber.ToString();
            _testTryCount--;
            CompareAnswer(_testTryCount, MyRandomValue, UserNumber);
            userNumberTextBox.Clear();
            
        }

        private void CompareAnswer(int tryCount, int randomValue, int userNumber)
        {
            lblTryCount.Text = tryCount.ToString();
            if (userNumber == randomValue)
            {
                userNumberTextBox.ForeColor = Color.Green;
                lblHiddenNumber.ForeColor = Color.Green;
                lblCompareResult.ForeColor = Color.Green;
                lblUserNumber.ForeColor = Color.Green;
                lblCompareResult.Text = "=";
                lblHiddenNumber.Text = randomValue.ToString();
                btnRestart.Enabled = true;
            }
            else if (userNumber < randomValue)
            {
                lblCompareResult.Text = "<";
                lblCompareResult.ForeColor = Color.Red;
                lblUserNumber.ForeColor = Color.Red;
            }
            else if (userNumber > randomValue)
            {
                lblCompareResult.Text = ">";
                lblCompareResult.ForeColor = Color.Red;
                lblUserNumber.ForeColor = Color.Red;
            }
            if(tryCount == 0)
            {
                userNumberTextBox.Enabled = false;
                btnUserTurn.Enabled = false;
                lblHiddenNumber.Text = randomValue.ToString();
                btnRestart.Enabled = true;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            _testTryCount = TryCount;
        }

        private void userNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            userNumberTextBox.Text = regex.Replace(userNumberTextBox.Text, "");
        }
    }
}
