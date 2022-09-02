namespace Chat
{
    partial class Form1
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.IpTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.LBText = new System.Windows.Forms.ListBox();
            this.MSGTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(284, 7);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(183, 55);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // IpTB
            // 
            this.IpTB.Location = new System.Drawing.Point(12, 12);
            this.IpTB.Name = "IpTB";
            this.IpTB.Size = new System.Drawing.Size(266, 22);
            this.IpTB.TabIndex = 2;
            this.IpTB.Text = "127.0.0.1";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(12, 40);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(266, 22);
            this.NameTB.TabIndex = 5;
            this.NameTB.Text = "Your nickname";
            // 
            // LBText
            // 
            this.LBText.FormattingEnabled = true;
            this.LBText.ItemHeight = 16;
            this.LBText.Location = new System.Drawing.Point(12, 78);
            this.LBText.Name = "LBText";
            this.LBText.Size = new System.Drawing.Size(454, 292);
            this.LBText.TabIndex = 6;
            // 
            // MSGTextBox
            // 
            this.MSGTextBox.Enabled = false;
            this.MSGTextBox.Location = new System.Drawing.Point(12, 376);
            this.MSGTextBox.Name = "MSGTextBox";
            this.MSGTextBox.Size = new System.Drawing.Size(455, 22);
            this.MSGTextBox.TabIndex = 7;
            this.MSGTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MSGTextBox_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 411);
            this.Controls.Add(this.MSGTextBox);
            this.Controls.Add(this.LBText);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.IpTB);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Lobby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox IpTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.ListBox LBText;
        private System.Windows.Forms.TextBox MSGTextBox;
    }
}

