namespace Multi2048
{
    /// <summary>
    /// Main menu form
    /// </summary>
    public partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newGameButton = new System.Windows.Forms.Button();
            this.ruleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(13, 70);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(250, 25);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "Новая игра";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // ruleButton
            // 
            this.ruleButton.Location = new System.Drawing.Point(13, 140);
            this.ruleButton.Name = "ruleButton";
            this.ruleButton.Size = new System.Drawing.Size(250, 25);
            this.ruleButton.TabIndex = 2;
            this.ruleButton.Text = "Правила";
            this.ruleButton.UseVisualStyleBackColor = true;
            this.ruleButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ruleButton);
            this.Controls.Add(this.newGameButton);
            this.Name = "MainMenuForm";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// Button that allows to start new game
        /// </summary>
        private System.Windows.Forms.Button newGameButton;

        /// <summary>
        /// Button that allows to read game rules
        /// </summary>
        private System.Windows.Forms.Button ruleButton;
    }
}