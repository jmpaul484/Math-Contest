using System;
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

            NameTextBox.Select();

        }
        // Evaluate the fields and return true if valid, false otherwise
        bool EvaluateFields()
        {
            bool valid = true;
            

            try
            {
                int.Parse(AgeTextBox.Text);
                AgeTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                valid = false;
                //AgeTextBox.Select();
                AgeTextBox.BackColor = Color.LightYellow;
            }

            if (NameTextBox.Text == "")
            {
                valid = false;
                //NameTextBox.Select();
                NameTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                NameTextBox.BackColor = Color.White;
            }

            try
            {
                int.Parse(GradeTextBox.Text);
                GradeTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                valid = false;
                //GradeTextBox.Select();
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
                //StudentAnswerTextBox.Select();
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
            }
            else
            {
                UserMessage = $"Sorry, your answer is incorrect. The correct answer is {NumberTotal}.";
            }
            MessageBox.Show(UserMessage);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Reset for to defaults when clicked
            Defaults();
            RandomNumbers();
        }

        private void SummeryButton_Click(object sender, EventArgs e)
        {

        }

        //Evaluate fields when the AgeTextBox text changes
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateFields();
        }

        //Evaluate fields when the AgeTextBox text changes
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateFields();
        }

        //Evaluate fields when the GradeTextBox text changes
        private void GradeTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateFields();
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
