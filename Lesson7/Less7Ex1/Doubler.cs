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
    public partial class Doubler : Form
    {
        private int counter = 0;
        Stack<int> userRes = new Stack<int>();
        public Doubler()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblUserResult.Text = (int.Parse(lblUserResult.Text) + 1).ToString();
            counter++;
            lblUserStepCount.Text = counter.ToString();
            userRes.Push(int.Parse(lblUserResult.Text));
            CheckResult();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            lblUserResult.Text = (int.Parse(lblUserResult.Text) * 2).ToString();
            counter++;
            lblUserStepCount.Text = counter.ToString();
            userRes.Push(int.Parse(lblUserResult.Text));
            CheckResult();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblUserResult.Text = "0";
            counter = 0;
            lblUserStepCount.Text = counter.ToString();
            btnAdd.Enabled = true;
            btnMulti.Enabled = true;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            
            int startPoint = 0;
            int endPoint = 100;
            Random random = new Random();
            int randomNumber = random.Next(startPoint, endPoint);
            lblForRandomNum.Text = randomNumber.ToString();
            btnStartGame.Enabled = false;
            btnNewGame.Enabled = true;
            btnAdd.Enabled = true;
            btnMulti.Enabled = true;
            btnClear.Enabled = true;
            btnUndo.Enabled = true;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lblUserResult.Text = "0";
            lblUserStepCount.Text = "0";
            lblForRandomNum.Text = "0";
            btnStartGame.Enabled = true;
            btnAdd.Enabled = false;
            btnMulti.Enabled = false;
            btnClear.Enabled = false;
            btnUndo.Enabled = false;
            btnNewGame.Enabled = false;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            userRes.Pop();
            lblUserResult.Text = userRes.Peek().ToString();
            if (int.Parse(lblUserResult.Text) < int.Parse(lblForRandomNum.Text))
            {
                btnAdd.Enabled = true;
                btnMulti.Enabled = true;
            }

        }

        private void CheckResult()
        {
            if (int.Parse(lblUserResult.Text) > int.Parse(lblForRandomNum.Text))
            {
                btnAdd.Enabled = false;
                btnMulti.Enabled = false;
            }
            else if (int.Parse(lblUserResult.Text) == int.Parse(lblForRandomNum.Text))
            {
                btnAdd.Enabled = false;
                btnMulti.Enabled = false;
                btnUndo.Enabled = false;
            }
        }
    }
}
