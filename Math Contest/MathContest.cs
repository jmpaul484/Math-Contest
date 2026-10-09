using System;
using System.Windows.Forms;

namespace Math_Contest
{
    public partial class MathContest : Form
    {
        public MathContest()
        {
            InitializeComponent();
        }

        private void MathContest_Load(object? sender, EventArgs e)
        {
            // Form load logic (left empty intentionally)
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


    }
}
