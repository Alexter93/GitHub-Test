namespace GitHubTestProgram
{
    partial class frmTest
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
            this.lblJist = new System.Windows.Forms.Label();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJist
            // 
            this.lblJist.AllowDrop = true;
            this.lblJist.AutoEllipsis = true;
            this.lblJist.Location = new System.Drawing.Point(12, 9);
            this.lblJist.Name = "lblJist";
            this.lblJist.Size = new System.Drawing.Size(258, 52);
            this.lblJist.TabIndex = 0;
            this.lblJist.Text = "This is just a test prgram to post on GitHub to make sure that I\'m doing the whol" +
    "e GitHub thing right.";
            this.lblJist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(99, 64);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(80, 30);
            this.btnHello.TabIndex = 1;
            this.btnHello.Text = "Message";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(99, 100);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 142);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.lblJist);
            this.Name = "frmTest";
            this.Text = "Hello GitHub";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJist;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnExit;
    }
}

