﻿namespace StupidBlackjackSln
{
    partial class frmTitle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTitle));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNewOnlineGame = new System.Windows.Forms.Button();
            this.btnRulebook = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowPnlAchievements = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(234, 58);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(519, 73);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Stupid Blackjack";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewOnlineGame
            // 
            this.btnNewOnlineGame.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNewOnlineGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewOnlineGame.BackgroundImage")));
            this.btnNewOnlineGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOnlineGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNewOnlineGame.Location = new System.Drawing.Point(20, 426);
            this.btnNewOnlineGame.Name = "btnNewOnlineGame";
            this.btnNewOnlineGame.Size = new System.Drawing.Size(458, 61);
            this.btnNewOnlineGame.TabIndex = 1;
            this.btnNewOnlineGame.Text = "Play Online Game";
            this.btnNewOnlineGame.UseVisualStyleBackColor = false;
            this.btnNewOnlineGame.Click += new System.EventHandler(this.btnNewOnlineGame_Click);
            // 
            // btnRulebook
            // 
            this.btnRulebook.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRulebook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRulebook.BackgroundImage")));
            this.btnRulebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRulebook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRulebook.Location = new System.Drawing.Point(246, 340);
            this.btnRulebook.Name = "btnRulebook";
            this.btnRulebook.Size = new System.Drawing.Size(227, 60);
            this.btnRulebook.TabIndex = 2;
            this.btnRulebook.Text = "Rulebook";
            this.btnRulebook.UseVisualStyleBackColor = false;
            this.btnRulebook.Click += new System.EventHandler(this.btnRulebook_Click);
            // 
            // btnExitGame
            // 
            this.btnExitGame.BackColor = System.Drawing.Color.Transparent;
            this.btnExitGame.BackgroundImage = global::StupidBlackjackSln.Properties.Resources.greenfelt;
            this.btnExitGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExitGame.Location = new System.Drawing.Point(744, 340);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(197, 60);
            this.btnExitGame.TabIndex = 3;
            this.btnExitGame.Text = "Exit Game";
            this.btnExitGame.UseVisualStyleBackColor = false;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.AutoSize = true;
            this.btnOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOptions.BackgroundImage")));
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOptions.Location = new System.Drawing.Point(510, 340);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(197, 60);
            this.btnOptions.TabIndex = 4;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.Color.Maroon;
            this.btnServer.BackgroundImage = global::StupidBlackjackSln.Properties.Resources.greenfelt;
            this.btnServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnServer.Location = new System.Drawing.Point(510, 426);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(431, 61);
            this.btnServer.TabIndex = 6;
            this.btnServer.Text = "Start New Matchmaking Server";
            this.btnServer.UseVisualStyleBackColor = false;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.flowPnlAchievements);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(246, 149);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(223, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Achievements";
            // 
            // flowPnlAchievements
            // 
            this.flowPnlAchievements.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowPnlAchievements.Location = new System.Drawing.Point(0, 19);
            this.flowPnlAchievements.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowPnlAchievements.Name = "flowPnlAchievements";
            this.flowPnlAchievements.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.flowPnlAchievements.Size = new System.Drawing.Size(223, 82);
            this.flowPnlAchievements.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(510, 149);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(197, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistics";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackgroundImage = global::StupidBlackjackSln.Properties.Resources.greenfelt;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNewGame.Location = new System.Drawing.Point(20, 340);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(192, 60);
            this.btnNewGame.TabIndex = 12;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // frmTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::StupidBlackjackSln.Properties.Resources.table_texture;
            this.ClientSize = new System.Drawing.Size(961, 489);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.btnRulebook);
            this.Controls.Add(this.btnNewOnlineGame);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmTitle";
            this.Text = "Stupid Gray Blackjack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNewOnlineGame;
        private System.Windows.Forms.Button btnRulebook;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.FlowLayoutPanel flowPnlAchievements;
    }
}

