using System.ComponentModel;

namespace guessing_game
{
    partial class GuessForm
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
            this.guessesList = new System.Windows.Forms.ListBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.guessBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.computerIsGuessing = new System.Windows.Forms.RadioButton();
            this.youAreGuessing = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tooHighButton = new System.Windows.Forms.Button();
            this.correctButton = new System.Windows.Forms.Button();
            this.tooLowButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guessesList
            // 
            this.guessesList.FormattingEnabled = true;
            this.guessesList.Location = new System.Drawing.Point(112, 35);
            this.guessesList.Name = "guessesList";
            this.guessesList.Size = new System.Drawing.Size(183, 368);
            this.guessesList.TabIndex = 0;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(513, 34);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(151, 21);
            this.guessButton.TabIndex = 1;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.OnGuessButtonClick);
            // 
            // guessBox
            // 
            this.guessBox.Location = new System.Drawing.Point(301, 35);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(206, 20);
            this.guessBox.TabIndex = 2;
            this.guessBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnGuessTextValidation);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(513, 60);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(151, 20);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Start Over";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.OnResetButtonClick);
            // 
            // resultsLabel
            // 
            this.resultsLabel.Location = new System.Drawing.Point(301, 104);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(363, 23);
            this.resultsLabel.TabIndex = 4;
            // 
            // computerIsGuessing
            // 
            this.computerIsGuessing.Location = new System.Drawing.Point(9, 53);
            this.computerIsGuessing.Name = "computerIsGuessing";
            this.computerIsGuessing.Size = new System.Drawing.Size(151, 28);
            this.computerIsGuessing.TabIndex = 7;
            this.computerIsGuessing.Text = "The computer";
            this.computerIsGuessing.UseVisualStyleBackColor = true;
            // 
            // youAreGuessing
            // 
            this.youAreGuessing.Checked = true;
            this.youAreGuessing.Location = new System.Drawing.Point(9, 19);
            this.youAreGuessing.Name = "youAreGuessing";
            this.youAreGuessing.Size = new System.Drawing.Size(151, 28);
            this.youAreGuessing.TabIndex = 6;
            this.youAreGuessing.TabStop = true;
            this.youAreGuessing.Text = "You";
            this.youAreGuessing.UseVisualStyleBackColor = true;
            this.youAreGuessing.CheckedChanged += new System.EventHandler(this.OnPlayerGuessesCheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.youAreGuessing);
            this.groupBox1.Controls.Add(this.computerIsGuessing);
            this.groupBox1.Location = new System.Drawing.Point(301, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 91);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Who should guess?";
            // 
            // tooHighButton
            // 
            this.tooHighButton.Location = new System.Drawing.Point(301, 130);
            this.tooHighButton.Name = "tooHighButton";
            this.tooHighButton.Size = new System.Drawing.Size(363, 34);
            this.tooHighButton.TabIndex = 9;
            this.tooHighButton.Text = "Too high";
            this.tooHighButton.UseVisualStyleBackColor = true;
            this.tooHighButton.Click += new System.EventHandler(this.OnTooHighButtonClick);
            // 
            // correctButton
            // 
            this.correctButton.Location = new System.Drawing.Point(301, 170);
            this.correctButton.Name = "correctButton";
            this.correctButton.Size = new System.Drawing.Size(363, 34);
            this.correctButton.TabIndex = 10;
            this.correctButton.Text = "Correct";
            this.correctButton.UseVisualStyleBackColor = true;
            this.correctButton.Click += new System.EventHandler(this.OnCorrectButtonClick);
            // 
            // tooLowButton
            // 
            this.tooLowButton.Location = new System.Drawing.Point(301, 210);
            this.tooLowButton.Name = "tooLowButton";
            this.tooLowButton.Size = new System.Drawing.Size(363, 34);
            this.tooLowButton.TabIndex = 11;
            this.tooLowButton.Text = "Too low";
            this.tooLowButton.UseVisualStyleBackColor = true;
            this.tooLowButton.Click += new System.EventHandler(this.OnTooLowButtonClick);
            // 
            // GuessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tooLowButton);
            this.Controls.Add(this.correctButton);
            this.Controls.Add(this.tooHighButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.guessesList);
            this.Name = "GuessForm";
            this.Text = "Number guessing game";
            this.Load += new System.EventHandler(this.OnLoad);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button tooHighButton;
        private System.Windows.Forms.Button correctButton;
        private System.Windows.Forms.Button tooLowButton;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.RadioButton computerIsGuessing;
        private System.Windows.Forms.RadioButton youAreGuessing;

        private System.Windows.Forms.Label resultsLabel;

        private System.Windows.Forms.ListBox guessesList;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.Button resetButton;

        #endregion
    }
}