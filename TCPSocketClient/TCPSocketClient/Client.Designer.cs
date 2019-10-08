/*
 * Created by SharpDevelop.
 * User: Crogogo
 * Date: 10/6/2019
 * Time: 10:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TCPSocketClient
{
	partial class Client
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnConnectToServer;
		private System.Windows.Forms.Button btnSendMessage;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnConnectToServer = new System.Windows.Forms.Button();
			this.btnSendMessage = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btnConnectToServer
			// 
			this.btnConnectToServer.Location = new System.Drawing.Point(12, 384);
			this.btnConnectToServer.Name = "btnConnectToServer";
			this.btnConnectToServer.Size = new System.Drawing.Size(75, 23);
			this.btnConnectToServer.TabIndex = 0;
			this.btnConnectToServer.Text = "btnConnectToServer";
			this.btnConnectToServer.UseVisualStyleBackColor = true;
			this.btnConnectToServer.Click += new System.EventHandler(this.BtnConnectToServerClick);
			// 
			// btnSendMessage
			// 
			this.btnSendMessage.Location = new System.Drawing.Point(308, 384);
			this.btnSendMessage.Name = "btnSendMessage";
			this.btnSendMessage.Size = new System.Drawing.Size(89, 23);
			this.btnSendMessage.TabIndex = 1;
			this.btnSendMessage.Text = "SendMessage";
			this.btnSendMessage.UseVisualStyleBackColor = true;
			this.btnSendMessage.Click += new System.EventHandler(this.BtnSendMessageClick);
			
			
			this.Controls.Add(this.btnConnectToServer);
            this.Controls.Add(this.btnSendMessage);
			
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 358);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(385, 20);
			this.textBox1.TabIndex = 2;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(385, 340);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// Client
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 419);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnSendMessage);
			this.Controls.Add(this.btnConnectToServer);
			this.Name = "Client";
			this.Text = "Client";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
