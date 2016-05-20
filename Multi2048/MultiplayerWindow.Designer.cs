namespace Multi2048
{
    /// <summary>
    /// Multiplayer window
    /// </summary>
    public partial class MultiplayerWindow
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
            this.startLocal = new System.Windows.Forms.Button();
            this.startOnLine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startLocal
            // 
            this.startLocal.Location = new System.Drawing.Point(12, 90);
            this.startLocal.Name = "startLocal";
            this.startLocal.Size = new System.Drawing.Size(250, 25);
            this.startLocal.TabIndex = 0;
            this.startLocal.Text = "За одним компьютером";
            this.startLocal.UseVisualStyleBackColor = true;
            this.startLocal.Click += new System.EventHandler(this.StartLocal_Click);
            // 
            // startOnLine
            // 
            this.startOnLine.Location = new System.Drawing.Point(12, 140);
            this.startOnLine.Name = "startOnLine";
            this.startOnLine.Size = new System.Drawing.Size(250, 25);
            this.startOnLine.TabIndex = 1;
            this.startOnLine.Text = "По сети";
            this.startOnLine.UseVisualStyleBackColor = true;
            this.startOnLine.Click += new System.EventHandler(this.StartOnLine_Click);
            // 
            // MultiplayerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.startOnLine);
            this.Controls.Add(this.startLocal);
            this.Name = "MultiplayerWindow";
            this.Text = "Мультиплеер";
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// Button that allows to start single PC mode
        /// </summary>
        private System.Windows.Forms.Button startLocal;

        /// <summary>
        /// Button that allows to start multiplayer mode
        /// </summary>
        private System.Windows.Forms.Button startOnLine;
    }
}