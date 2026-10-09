using System;
using System.Windows.Forms;

namespace Math_Contest
{
    public partial class MathContest : Form
    {
        public MathContest()
        {
            InitializeComponent();
            Defaults();

        }

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

            AddButton.Enabled = true;

            NameTextBox.Select();
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
            Defaults();
        }

        private void SummeryButton_Click(object sender, EventArgs e)
        {

        }
    }
}
