﻿namespace StupidBlackjackSln
{
	partial class FrmServer
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.CloseServer = new System.Windows.Forms.Button();
            this.txtBoxStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // CloseServer
            // 
            this.CloseServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseServer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseServer.Location = new System.Drawing.Point(0, 777);
            this.CloseServer.Margin = new System.Windows.Forms.Padding(6);
            this.CloseServer.Name = "CloseServer";
            this.CloseServer.Size = new System.Drawing.Size(1600, 88);
            this.CloseServer.TabIndex = 0;
            this.CloseServer.Text = "Close Server";
            this.CloseServer.UseVisualStyleBackColor = true;
            this.CloseServer.Click += new System.EventHandler(this.CloseServer_Click);
            // 
            // txtBoxStatus
            // 
            this.txtBoxStatus.BackColor = System.Drawing.Color.Black;
            this.txtBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxStatus.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBoxStatus.Location = new System.Drawing.Point(0, 0);
            this.txtBoxStatus.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxStatus.Multiline = true;
            this.txtBoxStatus.Name = "txtBoxStatus";
            this.txtBoxStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxStatus.Size = new System.Drawing.Size(1600, 777);
            this.txtBoxStatus.TabIndex = 1;
            this.txtBoxStatus.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.txtBoxStatus);
            this.Controls.Add(this.CloseServer);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmServer";
            this.Text = "Stupid Gray Blackjack Matchmaking Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.Button CloseServer;
        private System.Windows.Forms.TextBox txtBoxStatus;
    }
}