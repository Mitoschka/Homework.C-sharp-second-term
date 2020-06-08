namespace RunAwayButton
{
    partial class CatchUpButton
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
            this.runawayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runawayButton
            // 
            this.runawayButton.Location = new System.Drawing.Point(237, 140);
            this.runawayButton.Name = "runawayButton";
            this.runawayButton.Size = new System.Drawing.Size(103, 61);
            this.runawayButton.TabIndex = 0;
            this.runawayButton.Text = "Click!";
            this.runawayButton.UseVisualStyleBackColor = true;
            this.runawayButton.Click += new System.EventHandler(this.OnRunawayButtonClick);
            this.runawayButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CursorTouchesRunawayButton);
            // 
            // CatchUpButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.runawayButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "CatchUpButton";
            this.Text = "CatchUpButton";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runawayButton;
    }
}

