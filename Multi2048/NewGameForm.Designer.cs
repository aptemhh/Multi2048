namespace Multi2048
{
    /// <summary>
    /// New game form
    /// </summary>
    public partial class NewGame_Form
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
            this.singleStartButton = new System.Windows.Forms.Button();
            this.multiplayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // singleStartButton
            // 
            this.singleStartButton.Location = new System.Drawing.Point(13, 66);
            this.singleStartButton.Name = "singleStartButton";
            this.singleStartButton.Size = new System.Drawing.Size(250, 25);
            this.singleStartButton.TabIndex = 0;
            this.singleStartButton.Text = "Одиночная игра";
            this.singleStartButton.UseVisualStyleBackColor = true;
            this.singleStartButton.Click += new System.EventHandler(this.SingleStartButton_Click);
            // 
            // multiplayerButton
            // 
            this.multiplayerButton.Location = new System.Drawing.Point(14, 107);
            this.multiplayerButton.Name = "multiplayerButton";
            this.multiplayerButton.Size = new System.Drawing.Size(250, 25);
            this.multiplayerButton.TabIndex = 1;
            this.multiplayerButton.Text = "Мультиплеер";
            this.multiplayerButton.UseVisualStyleBackColor = true;
            this.multiplayerButton.Click += new System.EventHandler(this.MultiplayerButton_Click);
            // 
            // NewGame_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.multiplayerButton);
            this.Controls.Add(this.singleStartButton);
            this.Name = "NewGame_Form";
            this.Text = "Новая игра";
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// Button that allows to start single play move
        /// </summary>
        private System.Windows.Forms.Button singleStartButton;

        /// <summary>
        /// Button that allows to start multiplayer mode
        /// </summary>
        private System.Windows.Forms.Button multiplayerButton;
    }
}