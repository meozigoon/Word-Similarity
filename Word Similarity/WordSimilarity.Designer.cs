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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowText;
            textBox1.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point, 129);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(119, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 61);
            textBox1.TabIndex = 0;
            textBox1.KeyDown += this.textBox1_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("맑은 고딕", 20F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(170, 44);
            label1.Name = "label1";
            label1.Size = new Size(133, 56);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("맑은 고딕", 20F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(170, 287);
            label2.Name = "label2";
            label2.Size = new Size(133, 56);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WordSimilarity
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(466, 423);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Cursor = Cursors.Default;
            Name = "WordSimilarity";
            Text = "WordSimilarity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}
