﻿namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbLanguages = new System.Windows.Forms.ComboBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.cbTime = new System.Windows.Forms.CheckBox();
            this.cbNumbers = new System.Windows.Forms.CheckBox();
            this.cBpunctuation = new System.Windows.Forms.CheckBox();
            this.cbWords = new System.Windows.Forms.CheckBox();
            this.cbQuote = new System.Windows.Forms.CheckBox();
            this.cbZen = new System.Windows.Forms.CheckBox();
            this.btnScores = new System.Windows.Forms.Button();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTimer = new System.Windows.Forms.Label();
            this.lbWpm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbLanguages
            // 
            this.cbLanguages.FormattingEnabled = true;
            this.cbLanguages.Items.AddRange(new object[] {
            "English",
            "Macedonian"});
            this.cbLanguages.Location = new System.Drawing.Point(302, 121);
            this.cbLanguages.Name = "cbLanguages";
            this.cbLanguages.Size = new System.Drawing.Size(121, 21);
            this.cbLanguages.TabIndex = 2;
            this.cbLanguages.Text = "English";
            this.cbLanguages.SelectedIndexChanged += new System.EventHandler(this.cbLanguages_SelectedIndexChanged);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(437, 325);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTime
            // 
            this.cbTime.AutoSize = true;
            this.cbTime.Location = new System.Drawing.Point(339, 68);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(49, 17);
            this.cbTime.TabIndex = 4;
            this.cbTime.Text = "Time";
            this.cbTime.UseVisualStyleBackColor = true;
            this.cbTime.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbNumbers
            // 
            this.cbNumbers.AutoSize = true;
            this.cbNumbers.Location = new System.Drawing.Point(160, 68);
            this.cbNumbers.Name = "cbNumbers";
            this.cbNumbers.Size = new System.Drawing.Size(68, 17);
            this.cbNumbers.TabIndex = 5;
            this.cbNumbers.Text = "Numbers";
            this.cbNumbers.UseVisualStyleBackColor = true;
            this.cbNumbers.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cBpunctuation
            // 
            this.cBpunctuation.AutoSize = true;
            this.cBpunctuation.Location = new System.Drawing.Point(243, 68);
            this.cBpunctuation.Name = "cBpunctuation";
            this.cBpunctuation.Size = new System.Drawing.Size(90, 17);
            this.cBpunctuation.TabIndex = 6;
            this.cBpunctuation.Text = "Punctinations";
            this.cBpunctuation.UseVisualStyleBackColor = true;
            this.cBpunctuation.CheckedChanged += new System.EventHandler(this.cBpunctuation_CheckedChanged);
            // 
            // cbWords
            // 
            this.cbWords.AutoSize = true;
            this.cbWords.Location = new System.Drawing.Point(394, 68);
            this.cbWords.Name = "cbWords";
            this.cbWords.Size = new System.Drawing.Size(57, 17);
            this.cbWords.TabIndex = 7;
            this.cbWords.Text = "Words";
            this.cbWords.UseVisualStyleBackColor = true;
            this.cbWords.CheckedChanged += new System.EventHandler(this.cbWords_CheckedChanged);
            // 
            // cbQuote
            // 
            this.cbQuote.AutoSize = true;
            this.cbQuote.Location = new System.Drawing.Point(457, 68);
            this.cbQuote.Name = "cbQuote";
            this.cbQuote.Size = new System.Drawing.Size(55, 17);
            this.cbQuote.TabIndex = 8;
            this.cbQuote.Text = "Quote";
            this.cbQuote.UseVisualStyleBackColor = true;
            this.cbQuote.CheckedChanged += new System.EventHandler(this.cbQuote_CheckedChanged);
            // 
            // cbZen
            // 
            this.cbZen.AutoSize = true;
            this.cbZen.Location = new System.Drawing.Point(518, 68);
            this.cbZen.Name = "cbZen";
            this.cbZen.Size = new System.Drawing.Size(45, 17);
            this.cbZen.TabIndex = 9;
            this.cbZen.Text = "Zen";
            this.cbZen.UseVisualStyleBackColor = true;
            this.cbZen.CheckedChanged += new System.EventHandler(this.cbZen_CheckedChanged);
            // 
            // btnScores
            // 
            this.btnScores.Location = new System.Drawing.Point(668, 99);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(75, 23);
            this.btnScores.TabIndex = 10;
            this.btnScores.Text = "Scores";
            this.btnScores.UseVisualStyleBackColor = true;
            this.btnScores.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(160, 165);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(403, 154);
            this.rtbText.TabIndex = 11;
            this.rtbText.Text = "\n";
            this.rtbText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbText_KeyPress);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(223, 325);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTimer
            // 
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(604, 184);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(149, 44);
            this.lbTimer.TabIndex = 13;
            this.lbTimer.Text = "Timer";
            // 
            // lbWpm
            // 
            this.lbWpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWpm.Location = new System.Drawing.Point(569, 275);
            this.lbWpm.Name = "lbWpm";
            this.lbWpm.Size = new System.Drawing.Size(229, 44);
            this.lbWpm.TabIndex = 14;
            this.lbWpm.Text = "WPM";
            this.lbWpm.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbWpm);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.cbZen);
            this.Controls.Add(this.cbQuote);
            this.Controls.Add(this.cbWords);
            this.Controls.Add(this.cBpunctuation);
            this.Controls.Add(this.cbNumbers);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.cbLanguages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbLanguages;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.CheckBox cbTime;
        private System.Windows.Forms.CheckBox cbNumbers;
        private System.Windows.Forms.CheckBox cBpunctuation;
        private System.Windows.Forms.CheckBox cbWords;
        private System.Windows.Forms.CheckBox cbQuote;
        private System.Windows.Forms.CheckBox cbZen;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label lbWpm;
    }
}

