namespace cs327project
{
    partial class server
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
            this.feedback = new System.Windows.Forms.TextBox();
            this.serverText = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.clientText = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // feedback
            // 
            this.feedback.Enabled = false;
            this.feedback.Location = new System.Drawing.Point(210, 8);
            this.feedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.feedback.Multiline = true;
            this.feedback.Name = "feedback";
            this.feedback.ReadOnly = true;
            this.feedback.Size = new System.Drawing.Size(148, 35);
            this.feedback.TabIndex = 1;
            // 
            // serverText
            // 
            this.serverText.Location = new System.Drawing.Point(13, 53);
            this.serverText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serverText.Multiline = true;
            this.serverText.Name = "serverText";
            this.serverText.Size = new System.Drawing.Size(189, 88);
            this.serverText.TabIndex = 2;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(28, 8);
            this.start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(112, 35);
            this.start.TabIndex = 3;
            this.start.Text = "Start Server";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(444, 5);
            this.send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(58, 136);
            this.send.TabIndex = 4;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            // 
            // clientText
            // 
            this.clientText.Location = new System.Drawing.Point(210, 53);
            this.clientText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clientText.Multiline = true;
            this.clientText.Name = "clientText";
            this.clientText.ReadOnly = true;
            this.clientText.Size = new System.Drawing.Size(216, 88);
            this.clientText.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(509, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(32, 136);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 167);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clientText);
            this.Controls.Add(this.send);
            this.Controls.Add(this.start);
            this.Controls.Add(this.serverText);
            this.Controls.Add(this.feedback);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox feedback;
        private System.Windows.Forms.TextBox serverText;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox clientText;
        private System.Windows.Forms.Button exitButton;

    }
}

