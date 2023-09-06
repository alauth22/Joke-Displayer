
namespace Week_1_A
{
    partial class frmComputerJoke
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
            this.lblJoke = new System.Windows.Forms.Label();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnPunchline = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJoke
            // 
            this.lblJoke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJoke.Location = new System.Drawing.Point(128, 49);
            this.lblJoke.Name = "lblJoke";
            this.lblJoke.Size = new System.Drawing.Size(244, 41);
            this.lblJoke.TabIndex = 0;
            this.lblJoke.Text = "Ready for a Joke?";
            this.lblJoke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(156, 104);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(79, 37);
            this.btnSetup.TabIndex = 1;
            this.btnSetup.Text = "Setup";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnPunchline
            // 
            this.btnPunchline.Location = new System.Drawing.Point(156, 162);
            this.btnPunchline.Name = "btnPunchline";
            this.btnPunchline.Size = new System.Drawing.Size(79, 37);
            this.btnPunchline.TabIndex = 2;
            this.btnPunchline.Text = "Punchline";
            this.btnPunchline.UseVisualStyleBackColor = true;
            this.btnPunchline.Click += new System.EventHandler(this.btnPunchline_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(268, 104);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(79, 37);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(268, 162);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmComputerJoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 262);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPunchline);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.lblJoke);
            this.Name = "frmComputerJoke";
            this.Text = "Computer Joke";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJoke;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnPunchline;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
    }
}

