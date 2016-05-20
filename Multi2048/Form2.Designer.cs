namespace Multi2048
{
    /// <summary>
    /// Game select form
    /// </summary>
    public partial class GameTypeForm
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
            this.timeModeStartButton = new System.Windows.Forms.Button();
            this.moveCountModeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeModeStartButton
            // 
            this.timeModeStartButton.Location = new System.Drawing.Point(13, 82);
            this.timeModeStartButton.Name = "timeModeStartButton";
            this.timeModeStartButton.Size = new System.Drawing.Size(259, 23);
            this.timeModeStartButton.TabIndex = 0;
            this.timeModeStartButton.Text = "На время";
            this.timeModeStartButton.UseVisualStyleBackColor = true;
            this.timeModeStartButton.Click += new System.EventHandler(this.TimeModeStart_Button_Click);
            // 
            // moveCountModeButton
            // 
            this.moveCountModeButton.Location = new System.Drawing.Point(13, 127);
            this.moveCountModeButton.Name = "moveCountModeButton";
            this.moveCountModeButton.Size = new System.Drawing.Size(259, 23);
            this.moveCountModeButton.TabIndex = 1;
            this.moveCountModeButton.Text = "С ограниченным количеством ходов";
            this.moveCountModeButton.UseVisualStyleBackColor = true;
            this.moveCountModeButton.Click += new System.EventHandler(this.MoveCountMode_Button_Click);
            // 
            // GameTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.moveCountModeButton);
            this.Controls.Add(this.timeModeStartButton);
            this.Name = "GameTypeForm";
            this.Text = "Выбор режима игры";
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// Button that allows start time limit mode
        /// </summary>
        private System.Windows.Forms.Button timeModeStartButton;

        /// <summary>
        /// Button that allows to start move limit mode
        /// </summary>
        private System.Windows.Forms.Button moveCountModeButton;
    }
}