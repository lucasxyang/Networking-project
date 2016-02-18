namespace client
{
    partial class client
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
            this.serverAd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.clientBox = new System.Windows.Forms.TextBox();
            this.serverBox = new System.Windows.Forms.TextBox();
            this.clientSd = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // serverAd
            // 
            this.serverAd.AutoSize = true;
            this.serverAd.Location = new System.Drawing.Point(25, 23);
            this.serverAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serverAd.Name = "serverAd";
            this.serverAd.Size = new System.Drawing.Size(118, 20);
            this.serverAd.TabIndex = 0;
            this.serverAd.Text = "Server Address";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 31);
            this.textBox1.TabIndex = 1;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(29, 72);
            this.connect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(112, 35);
            this.connect.TabIndex = 2;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // clientBox
            // 
            this.clientBox.Location = new System.Drawing.Point(13, 139);
            this.clientBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clientBox.Multiline = true;
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(163, 193);
            this.clientBox.TabIndex = 3;
            // 
            // serverBox
            // 
            this.serverBox.Location = new System.Drawing.Point(184, 139);
            this.serverBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serverBox.Multiline = true;
            this.serverBox.Name = "serverBox";
            this.serverBox.ReadOnly = true;
            this.serverBox.Size = new System.Drawing.Size(163, 193);
            this.serverBox.TabIndex = 4;
            // 
            // clientSd
            // 
            this.clientSd.Location = new System.Drawing.Point(31, 346);
            this.clientSd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clientSd.Name = "clientSd";
            this.clientSd.Size = new System.Drawing.Size(112, 35);
            this.clientSd.TabIndex = 5;
            this.clientSd.Text = "Send";
            this.clientSd.UseVisualStyleBackColor = true;
            this.clientSd.Click += new System.EventHandler(this.clientSd_Click);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(172, 72);
            this.status.Multiline = true;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(148, 31);
            this.status.TabIndex = 7;
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 423);
            this.Controls.Add(this.status);
            this.Controls.Add(this.clientSd);
            this.Controls.Add(this.serverBox);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.serverAd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serverAd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox clientBox;
        private System.Windows.Forms.TextBox serverBox;
        private System.Windows.Forms.Button clientSd;
        private System.Windows.Forms.TextBox status;
    }
}

