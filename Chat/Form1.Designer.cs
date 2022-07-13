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
            this.components = new System.ComponentModel.Container();
            this.btnHost = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnHost
            // 
            this.btnHost.Location = new System.Drawing.Point(29, 116);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(122, 55);
            this.btnHost.TabIndex = 0;
            this.btnHost.Text = "Host";
            this.btnHost.UseVisualStyleBackColor = true;
            this.btnHost.Click += new System.EventHandler(this.bntHost_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(166, 116);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(122, 55);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ip to connect";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(202, 383);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(122, 55);
            this.Send.TabIndex = 4;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Visible = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(83, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(159, 22);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.Text = "You nickname";
            this.textBoxName.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 450);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnHost);
            this.Name = "Form1";
            this.Text = "Lobby";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHost;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Timer timer1;
    }
}

