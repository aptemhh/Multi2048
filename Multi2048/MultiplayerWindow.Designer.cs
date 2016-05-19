namespace Multi2048
{
    partial class MultiplayerWindow
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
            this.StartLocal = new System.Windows.Forms.Button();
            this.StartOnLine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartLocal
            // 
            this.StartLocal.Location = new System.Drawing.Point(12, 90);
            this.StartLocal.Name = "StartLocal";
            this.StartLocal.Size = new System.Drawing.Size(250, 25);
            this.StartLocal.TabIndex = 0;
            this.StartLocal.Text = "За одним компьютером";
            this.StartLocal.UseVisualStyleBackColor = true;
            this.StartLocal.Click += new System.EventHandler(this.StartLocal_Click);
            // 
            // StartOnLine
            // 
            this.StartOnLine.Location = new System.Drawing.Point(12, 140);
            this.StartOnLine.Name = "StartOnLine";
            this.StartOnLine.Size = new System.Drawing.Size(250, 25);
            this.StartOnLine.TabIndex = 1;
            this.StartOnLine.Text = "По сети (недоступно в бете)";
            this.StartOnLine.UseVisualStyleBackColor = true;
            // 
            // MultiplayerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.StartOnLine);
            this.Controls.Add(this.StartLocal);
            this.Name = "MultiplayerWindow";
            this.Text = "Мультиплеер";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartLocal;
        private System.Windows.Forms.Button StartOnLine;
    }
}