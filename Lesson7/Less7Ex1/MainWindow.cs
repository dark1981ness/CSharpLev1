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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            mainMenu.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        private void Doubler_Click(object sender, EventArgs e)
        {
            Form doubler = new Doubler() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            CloseFormsInsidePanel(mainPanel);
            this.mainPanel.Controls.Add(doubler);
            doubler.Show();
        }

        private void GuessNumber_Click(object sender, EventArgs e)
        {
            Form guessNumbers = new GuessNumbers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            CloseFormsInsidePanel(mainPanel);
            this.mainPanel.Controls.Add(guessNumbers);
            guessNumbers.Show();
        }

        private void About_Click(object sender, EventArgs e)
        {
            int formsCount = Application.OpenForms.Count;
            MessageBox.Show(formsCount.ToString());
        }

        private void CloseFormsInsidePanel(Panel panel)
        {
            var fCount = panel.Controls;
            foreach (var item in fCount)
            {
                if (item is Form)
                {
                    Form newItem = item as Form;
                    newItem.Close();
                }
            }
        }
    }
}
