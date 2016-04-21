namespace Multi2048
{
    partial class NewGame_Form
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.SingleStartButton = new System.Windows.Forms.Button();
            this.MultiplayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SingleStartButton
            // 
            this.SingleStartButton.Location = new System.Drawing.Point(13, 66);
            this.SingleStartButton.Name = "SingleStartButton";
            this.SingleStartButton.Size = new System.Drawing.Size(250, 25);
            this.SingleStartButton.TabIndex = 0;
            this.SingleStartButton.Text = "Одиночная игра";
            this.SingleStartButton.UseVisualStyleBackColor = true;
            this.SingleStartButton.Click += new System.EventHandler(this.SingleStartButton_Click);
            // 
            // MultiplayerButton
            // 
            this.MultiplayerButton.Location = new System.Drawing.Point(14, 107);
            this.MultiplayerButton.Name = "MultiplayerButton";
            this.MultiplayerButton.Size = new System.Drawing.Size(250, 25);
            this.MultiplayerButton.TabIndex = 1;
            this.MultiplayerButton.Text = "Мультиплеер";
            this.MultiplayerButton.UseVisualStyleBackColor = true;
            this.MultiplayerButton.Click += new System.EventHandler(this.MultiplayerButton_Click);
            // 
            // NewGame_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.MultiplayerButton);
            this.Controls.Add(this.SingleStartButton);
            this.Name = "NewGame_Form";
            this.Text = "Новая игра";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SingleStartButton;
        private System.Windows.Forms.Button MultiplayerButton;
    }
}