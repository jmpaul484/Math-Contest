namespace Math_Contest
{
    partial class MathContest
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SubmitButton = new Button();
            ClearButton = new Button();
            SummeryButton = new Button();
            NametextBox = new TextBox();
            Number2textBox = new TextBox();
            Number1textBox = new TextBox();
            StudentAnswertextBox = new TextBox();
            AgetextBox = new TextBox();
            GradetextBox = new TextBox();
            AddButton = new RadioButton();
            SubtractButton = new RadioButton();
            MultiplyButton = new RadioButton();
            DivideButton = new RadioButton();
            StudentInfoGroupBox = new GroupBox();
            GradeLabel = new Label();
            AgeLabel = new Label();
            NameLabel = new Label();
            ButtonGroupBox = new GroupBox();
            ExitButton = new Button();
            MathProblemTypeGroup = new GroupBox();
            CurrentMathProblemGroup = new GroupBox();
            StudentAnswerLabel = new Label();
            Number2Label = new Label();
            Number1Label = new Label();
            StudentInfoGroupBox.SuspendLayout();
            ButtonGroupBox.SuspendLayout();
            MathProblemTypeGroup.SuspendLayout();
            CurrentMathProblemGroup.SuspendLayout();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(6, 30);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(214, 63);
            SubmitButton.TabIndex = 1;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += this.SubmitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(6, 99);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(214, 63);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // SummeryButton
            // 
            SummeryButton.Location = new Point(6, 168);
            SummeryButton.Name = "SummeryButton";
            SummeryButton.Size = new Size(214, 63);
            SummeryButton.TabIndex = 3;
            SummeryButton.Text = "Summery";
            SummeryButton.UseVisualStyleBackColor = true;
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(6, 85);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(268, 31);
            NametextBox.TabIndex = 4;
            // 
            // Number2textBox
            // 
            Number2textBox.Location = new Point(6, 137);
            Number2textBox.Name = "Number2textBox";
            Number2textBox.Size = new Size(293, 31);
            Number2textBox.TabIndex = 5;
            // 
            // Number1textBox
            // 
            Number1textBox.Location = new Point(6, 69);
            Number1textBox.Name = "Number1textBox";
            Number1textBox.Size = new Size(287, 31);
            Number1textBox.TabIndex = 7;
            // 
            // StudentAnswertextBox
            // 
            StudentAnswertextBox.Location = new Point(0, 199);
            StudentAnswertextBox.Name = "StudentAnswertextBox";
            StudentAnswertextBox.Size = new Size(293, 31);
            StudentAnswertextBox.TabIndex = 8;
            // 
            // AgetextBox
            // 
            AgetextBox.Location = new Point(302, 85);
            AgetextBox.Name = "AgetextBox";
            AgetextBox.Size = new Size(39, 31);
            AgetextBox.TabIndex = 9;
            // 
            // GradetextBox
            // 
            GradetextBox.Location = new Point(403, 85);
            GradetextBox.Name = "GradetextBox";
            GradetextBox.Size = new Size(39, 31);
            GradetextBox.TabIndex = 10;
            // 
            // AddButton
            // 
            AddButton.AutoSize = true;
            AddButton.Location = new Point(6, 30);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(71, 29);
            AddButton.TabIndex = 11;
            AddButton.TabStop = true;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // SubtractButton
            // 
            SubtractButton.AutoSize = true;
            SubtractButton.Location = new Point(6, 65);
            SubtractButton.Name = "SubtractButton";
            SubtractButton.Size = new Size(101, 29);
            SubtractButton.TabIndex = 12;
            SubtractButton.TabStop = true;
            SubtractButton.Text = "subtract";
            SubtractButton.UseVisualStyleBackColor = true;
            // 
            // MultiplyButton
            // 
            MultiplyButton.AutoSize = true;
            MultiplyButton.Location = new Point(6, 100);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(101, 29);
            MultiplyButton.TabIndex = 13;
            MultiplyButton.TabStop = true;
            MultiplyButton.Text = "Multiply";
            MultiplyButton.UseVisualStyleBackColor = true;
            // 
            // DivideButton
            // 
            DivideButton.AutoSize = true;
            DivideButton.Location = new Point(6, 135);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(87, 29);
            DivideButton.TabIndex = 14;
            DivideButton.TabStop = true;
            DivideButton.Text = "Divide";
            DivideButton.UseVisualStyleBackColor = true;
            // 
            // StudentInfoGroupBox
            // 
            StudentInfoGroupBox.Controls.Add(GradeLabel);
            StudentInfoGroupBox.Controls.Add(AgeLabel);
            StudentInfoGroupBox.Controls.Add(NameLabel);
            StudentInfoGroupBox.Controls.Add(GradetextBox);
            StudentInfoGroupBox.Controls.Add(AgetextBox);
            StudentInfoGroupBox.Controls.Add(NametextBox);
            StudentInfoGroupBox.Location = new Point(12, 12);
            StudentInfoGroupBox.Name = "StudentInfoGroupBox";
            StudentInfoGroupBox.Size = new Size(551, 132);
            StudentInfoGroupBox.TabIndex = 15;
            StudentInfoGroupBox.TabStop = false;
            StudentInfoGroupBox.Text = "Student Information";
            // 
            // GradeLabel
            // 
            GradeLabel.AutoSize = true;
            GradeLabel.Location = new Point(403, 57);
            GradeLabel.Name = "GradeLabel";
            GradeLabel.Size = new Size(59, 25);
            GradeLabel.TabIndex = 13;
            GradeLabel.Text = "Grade";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(302, 57);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(44, 25);
            AgeLabel.TabIndex = 12;
            AgeLabel.Text = "Age";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 57);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(59, 25);
            NameLabel.TabIndex = 11;
            NameLabel.Text = "Name";
            // 
            // ButtonGroupBox
            // 
            ButtonGroupBox.Controls.Add(ExitButton);
            ButtonGroupBox.Controls.Add(SummeryButton);
            ButtonGroupBox.Controls.Add(ClearButton);
            ButtonGroupBox.Controls.Add(SubmitButton);
            ButtonGroupBox.Location = new Point(569, 12);
            ButtonGroupBox.Name = "ButtonGroupBox";
            ButtonGroupBox.Size = new Size(229, 426);
            ButtonGroupBox.TabIndex = 16;
            ButtonGroupBox.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(6, 236);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(214, 63);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += this.ExitButton_Click;
            // 
            // MathProblemTypeGroup
            // 
            MathProblemTypeGroup.Controls.Add(MultiplyButton);
            MathProblemTypeGroup.Controls.Add(AddButton);
            MathProblemTypeGroup.Controls.Add(SubtractButton);
            MathProblemTypeGroup.Controls.Add(DivideButton);
            MathProblemTypeGroup.Location = new Point(317, 158);
            MathProblemTypeGroup.Name = "MathProblemTypeGroup";
            MathProblemTypeGroup.Size = new Size(246, 280);
            MathProblemTypeGroup.TabIndex = 17;
            MathProblemTypeGroup.TabStop = false;
            MathProblemTypeGroup.Text = "Math Problem Type";
            // 
            // CurrentMathProblemGroup
            // 
            CurrentMathProblemGroup.Controls.Add(StudentAnswerLabel);
            CurrentMathProblemGroup.Controls.Add(Number2Label);
            CurrentMathProblemGroup.Controls.Add(Number1Label);
            CurrentMathProblemGroup.Controls.Add(Number1textBox);
            CurrentMathProblemGroup.Controls.Add(Number2textBox);
            CurrentMathProblemGroup.Controls.Add(StudentAnswertextBox);
            CurrentMathProblemGroup.Location = new Point(12, 158);
            CurrentMathProblemGroup.Name = "CurrentMathProblemGroup";
            CurrentMathProblemGroup.Size = new Size(299, 291);
            CurrentMathProblemGroup.TabIndex = 18;
            CurrentMathProblemGroup.TabStop = false;
            CurrentMathProblemGroup.Text = "Current Math Problem";
            // 
            // StudentAnswerLabel
            // 
            StudentAnswerLabel.AutoSize = true;
            StudentAnswerLabel.Location = new Point(6, 171);
            StudentAnswerLabel.Name = "StudentAnswerLabel";
            StudentAnswerLabel.Size = new Size(128, 25);
            StudentAnswerLabel.TabIndex = 11;
            StudentAnswerLabel.Text = "Student Anwer";
            // 
            // Number2Label
            // 
            Number2Label.AutoSize = true;
            Number2Label.Location = new Point(6, 109);
            Number2Label.Name = "Number2Label";
            Number2Label.Size = new Size(113, 25);
            Number2Label.TabIndex = 10;
            Number2Label.Text = "2nd Number";
            // 
            // Number1Label
            // 
            Number1Label.AutoSize = true;
            Number1Label.Location = new Point(6, 41);
            Number1Label.Name = "Number1Label";
            Number1Label.Size = new Size(106, 25);
            Number1Label.TabIndex = 9;
            Number1Label.Text = "1st Number";
            // 
            // MathContest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CurrentMathProblemGroup);
            Controls.Add(MathProblemTypeGroup);
            Controls.Add(ButtonGroupBox);
            Controls.Add(StudentInfoGroupBox);
            Name = "MathContest";
            Text = "Math Contest";
            Load += this.MathContest_Load;
            StudentInfoGroupBox.ResumeLayout(false);
            StudentInfoGroupBox.PerformLayout();
            ButtonGroupBox.ResumeLayout(false);
            MathProblemTypeGroup.ResumeLayout(false);
            MathProblemTypeGroup.PerformLayout();
            CurrentMathProblemGroup.ResumeLayout(false);
            CurrentMathProblemGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button SubmitButton;
        private Button ClearButton;
        private Button SummeryButton;
        private TextBox NametextBox;
        private TextBox Number2textBox;
        private TextBox Number1textBox;
        private TextBox StudentAnswertextBox;
        private TextBox AgetextBox;
        private TextBox GradetextBox;
        private RadioButton AddButton;
        private RadioButton SubtractButton;
        private RadioButton MultiplyButton;
        private RadioButton DivideButton;
        private GroupBox StudentInfoGroupBox;
        private Label NameLabel;
        private GroupBox ButtonGroupBox;
        private Button ExitButton;
        private GroupBox MathProblemTypeGroup;
        private GroupBox CurrentMathProblemGroup;
        private Label Number1Label;
        private Label GradeLabel;
        private Label AgeLabel;
        private Label StudentAnswerLabel;
        private Label Number2Label;
    }
}
