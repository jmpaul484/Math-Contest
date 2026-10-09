using System;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace Math_Contest
{
    public partial class MathContest : Form
    {
        public MathContest()
        {
            InitializeComponent();
            Defaults();
            EvaluateFields();

        }
        static string userMessage = string.Empty;

        private void MathContest_Load(object? sender, EventArgs e)
        {
            // Form load logic (left empty intentionally)
        }

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
                userMessage += "Age must be a whole number\n";
            }

            if (NameTextBox.Text == "")
            {
                valid = false;
                //NameTextBox.Select();
                NameTextBox.BackColor = Color.LightYellow;
                userMessage += "Name is required\n";
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
                userMessage += "Grade must be a whole number\n";
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
                userMessage += "Student answer must be a whole number\n";
                SubmitButton.Enabled = valid;
            }
            return valid;
        }

        private void ExitButton_Click(object? sender, EventArgs e)
        {
            // Close the form when Exit is clicked
            this.Close();
        }

        private void SubmitButton_Click(object? sender, EventArgs e)
        {
            // Handle submit click
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Reset for to defaults when clicked
            Defaults();
        }

        private void SummeryButton_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_CheckedChanged(object sender, EventArgs e)
        {
            // Handle Add button checked
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

    }
}
