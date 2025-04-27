namespace Word_Similarity
{
    partial class WordSimilarity
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
            WordInput = new TextBox();
            GivenWord = new Label();
            Score = new Label();
            Reset = new Button();
            SuspendLayout();
            // 
            // WordInput
            // 
            WordInput.BackColor = SystemColors.WindowText;
            WordInput.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point, 129);
            WordInput.ForeColor = SystemColors.Window;
            WordInput.Location = new Point(38, 171);
            WordInput.Name = "WordInput";
            WordInput.Size = new Size(231, 61);
            WordInput.TabIndex = 0;
            WordInput.KeyDown += WordInput_KeyDown;
            // 
            // GivenWord
            // 
            GivenWord.AutoSize = true;
            GivenWord.BorderStyle = BorderStyle.Fixed3D;
            GivenWord.Font = new Font("맑은 고딕", 20F);
            GivenWord.ForeColor = SystemColors.Control;
            GivenWord.Location = new Point(38, 51);
            GivenWord.Name = "GivenWord";
            GivenWord.Size = new Size(133, 56);
            GivenWord.TabIndex = 1;
            GivenWord.Text = "label1";
            GivenWord.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.BorderStyle = BorderStyle.Fixed3D;
            Score.Font = new Font("맑은 고딕", 20F);
            Score.ForeColor = SystemColors.Control;
            Score.Location = new Point(38, 295);
            Score.Name = "Score";
            Score.Size = new Size(111, 56);
            Score.TabIndex = 2;
            Score.Text = "0.0%";
            Score.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Reset
            // 
            Reset.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Reset.ForeColor = SystemColors.ControlText;
            Reset.Location = new Point(223, 298);
            Reset.Name = "Reset";
            Reset.Size = new Size(112, 53);
            Reset.TabIndex = 3;
            Reset.Text = "reset";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // WordSimilarity
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(466, 423);
            Controls.Add(Reset);
            Controls.Add(Score);
            Controls.Add(GivenWord);
            Controls.Add(WordInput);
            Name = "WordSimilarity";
            Text = "WordSimilarity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox WordInput;
        private Label GivenWord;
        private Label Score;
        private Button Reset;
    }
}
