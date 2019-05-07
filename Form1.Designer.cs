namespace WindowsFormsApp_test_client
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.label_chat = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.label_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chat:";
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(16, 381);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(181, 57);
            this.textBox_message.TabIndex = 1;
            this.textBox_message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_message_KeyDown);
            // 
            // label_chat
            // 
            this.label_chat.AutoSize = true;
            this.label_chat.Location = new System.Drawing.Point(13, 34);
            this.label_chat.Name = "label_chat";
            this.label_chat.Size = new System.Drawing.Size(0, 17);
            this.label_chat.TabIndex = 2;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(637, 7);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(151, 23);
            this.button_connect.TabIndex = 3;
            this.button_connect.Text = "Connect to server";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.Button_connect_Click);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(386, 13);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(0, 17);
            this.label_info.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.label_chat);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Label label_chat;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label_info;
    }
}

