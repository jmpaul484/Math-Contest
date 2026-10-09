using System;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace Math_Contest
{
    public partial class MathContest : Form
    {
        private void MathContest_Load(object? sender, EventArgs e)
        {
            // Form load logic (left empty intentionally)
        }
        static string UserMessage = string.Empty;

        public MathContest()
        {
            InitializeComponent();
            Defaults();
            EvaluateFields();
            RandomNumbers();

        }
        int NumberTotal = 0;
        int AnswerWrong = 0;
        int AnswerRight = 0;

        void Defaults()
        {
            // Set default values for controls
            NameTextBox.Text = string.Empty;
            Number1TextBox.Text = string.Empty;
            Number2TextBox.Text = string.Empty;
            StudentAnswerTextBox.Text = string.Empty;
            AgeTextBox.Text = string.Empty;
            GradeTextBox.Text = string.Empty;

            AddButton.Checked = true;
            Number1TextBox.Enabled = false;
            Number2TextBox.Enabled = false;
            SummeryButton.Enabled = false;

            NameTextBox.Select();

            AnswerRight = 0;
            AnswerWrong = 0;
        }
        void InfoChanged()
        {
            // Reset the answer counts and disable the summary button when info changes
            AnswerRight = 0;
            AnswerWrong = 0;
            SummeryButton.Enabled = false;
        }   
        // Evaluate the fields and return true if valid, false otherwise
        bool EvaluateFields()
        {
            bool valid = true;

            // Check if AgeTextBox contains a valid age (7-11)
            if (AgeTextBox.Text == "7" || AgeTextBox.Text == "8" || AgeTextBox.Text == "9" || AgeTextBox.Text == "10" || AgeTextBox.Text == "11")
             {
                try
                {

                    int.Parse(AgeTextBox.Text);
                    AgeTextBox.BackColor = Color.White;
                }
                catch (Exception)
                {
                    valid = false;
                    AgeTextBox.BackColor = Color.LightYellow;
                }
            }
             else
            {
                valid = false;
                AgeTextBox.BackColor = Color.LightYellow;
            }

            if (NameTextBox.Text == "")
            {
                valid = false;
                NameTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                NameTextBox.BackColor = Color.White;
            }

            if (GradeTextBox.Text == "1" || GradeTextBox.Text == "2" || GradeTextBox.Text == "3" || GradeTextBox.Text == "4")
            {
                try
                {
                    int.Parse(GradeTextBox.Text);
                    GradeTextBox.BackColor = Color.White;
                }
                catch (Exception)
                {
                    valid = false;
                    GradeTextBox.BackColor = Color.LightYellow;
                }
            }
            else
            {
                valid = false;
                GradeTextBox.BackColor = Color.LightYellow;
            }

            try
            {
                int.Parse(StudentAnswerTextBox.Text);
                StudentAnswerTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                valid = false;
                StudentAnswerTextBox.BackColor = Color.LightYellow;
            }
            
            SubmitButton.Enabled = valid;
            return valid;
        }

        void RandomNumbers()
        {
            Random rand = new Random();
            Number1TextBox.Text = rand.Next(1, 100).ToString();
            Number2TextBox.Text = rand.Next(1, 100).ToString();
        }
        private void ExitButton_Click(object? sender, EventArgs e)
        {
            // Close the form when Exit is clicked
            this.Close();
        }

        private void SubmitButton_Click(object? sender, EventArgs e)
        {
            // Handle submit click
            if (AddButton.Checked)
            {
                NumberTotal = int.Parse(Number1TextBox.Text) + int.Parse(Number2TextBox.Text);
            }
            else if (SubtractButton.Checked)
            {
                NumberTotal = int.Parse(Number1TextBox.Text) - int.Parse(Number2TextBox.Text);
            }
            else if (MultiplyButton.Checked)
            {
                NumberTotal = int.Parse(Number1TextBox.Text) * int.Parse(Number2TextBox.Text);
            }
            else if (DivideButton.Checked)
            {
                NumberTotal = int.Parse(Number1TextBox.Text) / int.Parse(Number2TextBox.Text);
            }
            if (NumberTotal == int.Parse(StudentAnswerTextBox.Text))
            {
                UserMessage = "Congratulations! Your answer is correct.";
                AnswerRight++;
            }
            else
            {
                UserMessage = $"Sorry, your answer is incorrect. The correct answer is {NumberTotal}.";
                AnswerWrong++;
            }
            MessageBox.Show(UserMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            SummeryButton.Enabled = true;
            RandomNumbers();
        }
        
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Reset for to defaults when clicked
            Defaults();
            RandomNumbers();
        }

        private void SummeryButton_Click(object sender, EventArgs e)
        {
            UserMessage = $"Contestant Name: {NameTextBox.Text}\nTotal Questions: " +
                $"{AnswerRight + AnswerWrong}\nCorrect Answers: {AnswerRight}\nIncorrect Answers: {AnswerWrong}" +
                $"\nGrade: {(double)AnswerRight / (AnswerRight + AnswerWrong) * 100:F2}%";
            MessageBox.Show(UserMessage, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Evaluate fields when the AgeTextBox text changes
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateFields();
            InfoChanged();
        }

        //Evaluate fields when the AgeTextBox text changes
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateFields();
            InfoChanged();
        }

        //Evaluate fields when the GradeTextBox text changes
        private void GradeTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateFields();
            InfoChanged();
        }

        private void StudentAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateFields();
        }
        private void AddButton_CheckedChanged(object sender, EventArgs e)
        {
            RandomNumbers();
            // Handle Add button checked
        }

        private void SubtractButton_CheckedChanged(object sender, EventArgs e)
        {
            RandomNumbers();
            // Handle Subtract button checked
        }

        private void MultiplyButton_CheckedChanged(object sender, EventArgs e)
        {
            RandomNumbers();
            // Handle Multiply button checked
        }

        private void DivideButton_CheckedChanged(object sender, EventArgs e)
        {
            RandomNumbers();
            // Handle Divide button checked
        }
    }
}
