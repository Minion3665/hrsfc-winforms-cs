using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessing_game
{
    public partial class GuessForm : Form
    {
        private readonly Random _random = new Random();
        private int _randomNumber;
        private int _aiGuess;
        private int _highestPossible = 100;
        private int _lowestPossible = 1;
        public GuessForm()
        {
            InitializeComponent();
        }

        private void SetComponentVisibility(bool playerMode)
        {
            guessBox.Visible = playerMode;
            guessButton.Visible = playerMode;
            tooHighButton.Visible = !playerMode;
            tooLowButton.Visible = !playerMode;
            correctButton.Visible = !playerMode;
        }

        private void PlayerMode()
        {
            SetComponentVisibility(true);
            guessesList.Items.Clear();
            _highestPossible = 100;
            _lowestPossible = 1;
            _randomNumber = _random.Next(_lowestPossible, _highestPossible + 1);
        }

        // ReSharper disable once InconsistentNaming
        // AI is AI not Ai
        private void DoAIGuess()
        {
            var guess = (_highestPossible + _lowestPossible) / 2;
            var certain = _highestPossible == _lowestPossible;

            _aiGuess = guess;
            if (certain)
            {
                ShowSuccess($"So it must be {guess}!");
                tooHighButton.Enabled = false;
                tooLowButton.Enabled = false;
            }
            else
            {
                ShowResult($"I guess {guess}");
                tooLowButton.Enabled = guess + 1 <= _highestPossible;
                tooHighButton.Enabled = guess - 1 >= _lowestPossible;
            }
        }
        
        // ReSharper disable once InconsistentNaming
        // Once again AI is an acronym
        private void AIMode()
        {
            SetComponentVisibility(false);
            guessesList.Items.Clear();
            _highestPossible = 100;
            _lowestPossible = 1;
            tooHighButton.Enabled = true;
            tooLowButton.Enabled = true;
            correctButton.Enabled = true;
            DoAIGuess();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            PlayerMode();
        }

        private void OnGuessButtonClick(object sender, EventArgs e)
        {
            if (guessBox.Text == "")
            {
                ShowError("Please enter a guess");
                return;
            }

            var guess = int.Parse(guessBox.Text);
            guessBox.Text = "";
            guessBox.Focus();
            if (guess == _randomNumber)
            {
                ShowSuccess($"You won in {guessesList.Items.Count + 1} guess{(guessesList.Items.Count == 0 ? "" : "es")}!");
                PlayerMode();
            }
            else if (guess < _randomNumber)
            {
                ShowResult($"Too low!");
                guessesList.Items.Add($"{guess} (Too low!, {guessesList.Items.Count + 1} guess{(guessesList.Items.Count == 0 ? "" : "es")} so far)");
                guessesList.SelectedIndex = guessesList.Items.Count - 1;
            }
            else
            {
                ShowResult($"Too high! ");
                guessesList.Items.Add($"{guess} (Too high!, {guessesList.Items.Count + 1} guess{(guessesList.Items.Count == 0 ? "" : "es")} so far)");
                guessesList.SelectedIndex = guessesList.Items.Count - 1;
            }
        }

        private void OnResetButtonClick(object sender, EventArgs e)
        {
            if (youAreGuessing.Checked)
            {
                PlayerMode();
                ShowResult("New game started: Guess a number");
                guessBox.Focus();
            } else
            {
                AIMode();
            }
        }

        private void ShowResult(string message)
        {
            resultsLabel.ForeColor = Color.Black;
            _ShowMessage(message);
        }
        
        private void ShowError(string message)
        {
            resultsLabel.ForeColor = Color.Red;
            _ShowMessage(message);
        }

        private void ShowSuccess(string message)
        {
            resultsLabel.ForeColor = Color.Green;
            _ShowMessage(message);
        }
        
        private void _ShowMessage(string message)
        {
            resultsLabel.Text = message;
        }

        private void OnGuessTextValidation(object sender, CancelEventArgs e)
        {
            if (guessBox.Text == "" || int.TryParse(guessBox.Text, out var guess) && guess > 0 && guess <= 100)
            {
                return;
            }
            e.Cancel = true;
            ShowError("You need to enter an integer between 1 and 100");
        }

        private void OnPlayerGuessesCheckedChanged(object sender, EventArgs e)
        {
            if (youAreGuessing.Checked)
            {
                PlayerMode();
            }
            else
            {
                AIMode();
            }
        }

        private void OnTooHighButtonClick(object sender, EventArgs e)
        {
            guessesList.Items.Add($"{_aiGuess} (Too High!, {guessesList.Items.Count + 1} guess{(guessesList.Items.Count == 0 ? "" : "es")} so far)");
            _highestPossible = _aiGuess - 1;
            DoAIGuess();
            guessesList.SelectedIndex = guessesList.Items.Count - 1;
        }

        private void OnCorrectButtonClick(object sender, EventArgs e)
        {
            ShowSuccess("Thank you! Good game!");
            tooHighButton.Enabled = false;
            tooLowButton.Enabled = false;
            correctButton.Enabled = false;
            guessesList.Items.Add($"{_aiGuess} (Correct!, the AI wins in {guessesList.Items.Count + 1} guess{(guessesList.Items.Count == 0 ? "" : "es")})");
            guessesList.SelectedIndex = guessesList.Items.Count - 1;
        }

        private void OnTooLowButtonClick(object sender, EventArgs e)
        {
            guessesList.Items.Add($"{_aiGuess} (Too low!, {guessesList.Items.Count + 1} guess{(guessesList.Items.Count == 0 ? "" : "es")} so far)");
            _lowestPossible = _aiGuess + 1;
            DoAIGuess();
            guessesList.SelectedIndex = guessesList.Items.Count - 1;
        }
    }
}