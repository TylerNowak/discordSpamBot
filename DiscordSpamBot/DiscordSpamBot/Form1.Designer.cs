namespace DiscordSpamBot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.channel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iteration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(84, 39);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(224, 23);
            this.email.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(84, 87);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(224, 23);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // channel
            // 
            this.channel.Location = new System.Drawing.Point(369, 39);
            this.channel.Name = "channel";
            this.channel.Size = new System.Drawing.Size(239, 23);
            this.channel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Channel Url:";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(369, 87);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(239, 23);
            this.message.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Your Message:";
            // 
            // iteration
            // 
            this.iteration.Location = new System.Drawing.Point(369, 135);
            this.iteration.Name = "iteration";
            this.iteration.Size = new System.Drawing.Size(239, 23);
            this.iteration.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Iterations (put 0 for infinite):";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(369, 182);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(239, 23);
            this.time.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Time to wait (in seconds):";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(153, 134);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 12;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(752, 228);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iteration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.channel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Name = "Form1";
            this.Text = "Password:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox channel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox iteration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button start;
    }
}

