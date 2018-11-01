﻿using System;
using System.Windows.Forms;


namespace StupidBlackjackSln
{
    public partial class frmTitle : Form
    {

        public frmTitle()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnRulebook_Click(object sender, EventArgs e)
        {
            FrmRulebook rulebook = new FrmRulebook();
            rulebook.Show();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnNewOnlineGame_Click(object sender, EventArgs e)
        {
            try
            {
                Program.StartNewConnector();
            }
            catch (Exception)
            {
                FrmNewGame firstGame = new FrmNewGame();
                firstGame.FormClosed += new FormClosedEventHandler(firstGame_FormClosed);
                firstGame.Show();
                this.Hide();
                return;
            }
            new Matchmaking().ShowDialog();
        }

        private void firstGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();    //unhides the title screen when the newGame Form closes
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            new Options().ShowDialog();
        }

        private void achievments_button_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            FrmNewGame firstGame = new FrmNewGame();
            firstGame.FormClosed += new FormClosedEventHandler(firstGame_FormClosed);
            firstGame.Show();
            this.Hide();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            new FrmServer().Show();
            this.Hide();
            Program.StartNewServer();
        }
    }
}
