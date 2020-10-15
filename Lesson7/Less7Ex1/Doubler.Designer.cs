namespace Less7Ex1
{
    partial class Doubler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.lblUserResult = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserStepCount = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.lblForRandomNum = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumber.Location = new System.Drawing.Point(10, 20);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(150, 20);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Должны получить:";
            this.lblNumber.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(35, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+1";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnMulti
            // 
            this.btnMulti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMulti.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMulti.Location = new System.Drawing.Point(116, 146);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 37);
            this.btnMulti.TabIndex = 2;
            this.btnMulti.Text = "х2";
            this.btnMulti.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(351, 146);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 37);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Сброс";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUndo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUndo.Location = new System.Drawing.Point(197, 146);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(148, 37);
            this.btnUndo.TabIndex = 4;
            this.btnUndo.Text = "Отменить ход";
            this.btnUndo.UseVisualStyleBackColor = false;
            // 
            // lblUserResult
            // 
            this.lblUserResult.AutoSize = true;
            this.lblUserResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserResult.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserResult.Location = new System.Drawing.Point(113, 74);
            this.lblUserResult.Name = "lblUserResult";
            this.lblUserResult.Size = new System.Drawing.Size(162, 69);
            this.lblUserResult.TabIndex = 5;
            this.lblUserResult.Text = "9999";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartGame.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStartGame.Location = new System.Drawing.Point(15, 85);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(117, 39);
            this.btnStartGame.TabIndex = 6;
            this.btnStartGame.Text = "Играть";
            this.btnStartGame.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblUserStepCount);
            this.panel1.Controls.Add(this.lblStep);
            this.panel1.Controls.Add(this.lblForRandomNum);
            this.panel1.Controls.Add(this.lblNumber);
            this.panel1.Controls.Add(this.lblUserResult);
            this.panel1.Location = new System.Drawing.Point(36, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 177);
            this.panel1.TabIndex = 7;
            // 
            // lblUserStepCount
            // 
            this.lblUserStepCount.AutoSize = true;
            this.lblUserStepCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserStepCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserStepCount.Location = new System.Drawing.Point(281, 20);
            this.lblUserStepCount.Name = "lblUserStepCount";
            this.lblUserStepCount.Size = new System.Drawing.Size(18, 20);
            this.lblUserStepCount.TabIndex = 8;
            this.lblUserStepCount.Text = "0";
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStep.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStep.Location = new System.Drawing.Point(231, 20);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(44, 20);
            this.lblStep.TabIndex = 7;
            this.lblStep.Text = "Ход:";
            // 
            // lblForRandomNum
            // 
            this.lblForRandomNum.AutoSize = true;
            this.lblForRandomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForRandomNum.ForeColor = System.Drawing.SystemColors.Control;
            this.lblForRandomNum.Location = new System.Drawing.Point(162, 20);
            this.lblForRandomNum.Name = "lblForRandomNum";
            this.lblForRandomNum.Size = new System.Drawing.Size(18, 20);
            this.lblForRandomNum.TabIndex = 6;
            this.lblForRandomNum.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnStartGame);
            this.panel2.Controls.Add(this.btnUndo);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnMulti);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 195);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 60);
            this.label1.TabIndex = 7;
            this.label1.Text = "Компьютер выберет произвольное число от 0 до 1000.\r\nПопробуйте получить это число" +
    " при помощи операций\r\n\"+1\" и \"х2\" за минимальное число попыток.\r\n";
            // 
            // Doubler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(451, 415);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doubler";
            this.Text = "Doubler";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label lblUserResult;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblForRandomNum;
        private System.Windows.Forms.Label lblUserStepCount;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}