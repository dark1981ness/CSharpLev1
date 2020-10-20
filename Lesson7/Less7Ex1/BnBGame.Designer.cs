namespace Less7Ex1
{
    partial class BnBGame
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnTrue = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.lblCompareResult = new System.Windows.Forms.Label();
            this.lblTrueAnswerCount = new System.Windows.Forms.Label();
            this.lblFalseAnswerCount = new System.Windows.Forms.Label();
            this.lblTrueCount = new System.Windows.Forms.Label();
            this.lblFalseCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeader.Location = new System.Drawing.Point(163, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(151, 20);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "«Верю — не верю»";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblFalseCount);
            this.panel1.Controls.Add(this.lblTrueCount);
            this.panel1.Controls.Add(this.lblFalseAnswerCount);
            this.panel1.Controls.Add(this.lblTrueAnswerCount);
            this.panel1.Controls.Add(this.lblCompareResult);
            this.panel1.Controls.Add(this.btnFalse);
            this.panel1.Controls.Add(this.btnTrue);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 495);
            this.panel1.TabIndex = 1;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQuestion.Location = new System.Drawing.Point(11, 81);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(0, 20);
            this.lblQuestion.TabIndex = 1;
            // 
            // btnTrue
            // 
            this.btnTrue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTrue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnTrue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrue.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTrue.Location = new System.Drawing.Point(72, 243);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(90, 35);
            this.btnTrue.TabIndex = 2;
            this.btnTrue.Text = "Верю!";
            this.btnTrue.UseVisualStyleBackColor = false;
            // 
            // btnFalse
            // 
            this.btnFalse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnFalse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFalse.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFalse.Location = new System.Drawing.Point(301, 243);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(90, 35);
            this.btnFalse.TabIndex = 3;
            this.btnFalse.Text = "Не верю!";
            this.btnFalse.UseVisualStyleBackColor = false;
            // 
            // lblCompareResult
            // 
            this.lblCompareResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCompareResult.AutoSize = true;
            this.lblCompareResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompareResult.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCompareResult.Location = new System.Drawing.Point(206, 215);
            this.lblCompareResult.Name = "lblCompareResult";
            this.lblCompareResult.Size = new System.Drawing.Size(57, 63);
            this.lblCompareResult.TabIndex = 12;
            this.lblCompareResult.Text = "?";
            this.lblCompareResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrueAnswerCount
            // 
            this.lblTrueAnswerCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTrueAnswerCount.AutoSize = true;
            this.lblTrueAnswerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTrueAnswerCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTrueAnswerCount.Location = new System.Drawing.Point(11, 316);
            this.lblTrueAnswerCount.Name = "lblTrueAnswerCount";
            this.lblTrueAnswerCount.Size = new System.Drawing.Size(229, 20);
            this.lblTrueAnswerCount.TabIndex = 13;
            this.lblTrueAnswerCount.Text = "Количество верных ответов:";
            // 
            // lblFalseAnswerCount
            // 
            this.lblFalseAnswerCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFalseAnswerCount.AutoSize = true;
            this.lblFalseAnswerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFalseAnswerCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFalseAnswerCount.Location = new System.Drawing.Point(11, 353);
            this.lblFalseAnswerCount.Name = "lblFalseAnswerCount";
            this.lblFalseAnswerCount.Size = new System.Drawing.Size(247, 20);
            this.lblFalseAnswerCount.TabIndex = 14;
            this.lblFalseAnswerCount.Text = "Количество неверных ответов:";
            // 
            // lblTrueCount
            // 
            this.lblTrueCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTrueCount.AutoSize = true;
            this.lblTrueCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTrueCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTrueCount.Location = new System.Drawing.Point(286, 316);
            this.lblTrueCount.Name = "lblTrueCount";
            this.lblTrueCount.Size = new System.Drawing.Size(0, 20);
            this.lblTrueCount.TabIndex = 15;
            // 
            // lblFalseCount
            // 
            this.lblFalseCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFalseCount.AutoSize = true;
            this.lblFalseCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFalseCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFalseCount.Location = new System.Drawing.Point(286, 353);
            this.lblFalseCount.Name = "lblFalseCount";
            this.lblFalseCount.Size = new System.Drawing.Size(0, 20);
            this.lblFalseCount.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(163, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Вопрос";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(233, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "1 из 20";
            // 
            // BnBGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(481, 496);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BnBGame";
            this.Text = "BnBGame";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Label lblCompareResult;
        private System.Windows.Forms.Label lblFalseCount;
        private System.Windows.Forms.Label lblTrueCount;
        private System.Windows.Forms.Label lblFalseAnswerCount;
        private System.Windows.Forms.Label lblTrueAnswerCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}