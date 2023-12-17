namespace game2022
{
    partial class Form1
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
            startButton = new Button();
            startText = new Label();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(319, 384);
            startButton.Name = "startButton";
            startButton.Size = new Size(151, 54);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += button1_Click;
            // 
            // startText
            // 
            startText.AutoSize = true;
            startText.Font = new Font("Papyrus", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startText.Location = new Point(36, 9);
            startText.Name = "startText";
            startText.Size = new Size(719, 162);
            startText.TabIndex = 1;
            startText.Text = "Hello, welcome to this game.\r\nTo start, press start.\r\nThis will open the windows needed for the game.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(startText);
            Controls.Add(startButton);
            Name = "Form1";
            Text = "Game";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Label startText;
    }
}
