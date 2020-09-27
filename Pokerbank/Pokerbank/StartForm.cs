using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pokerbank
{
    public partial class StartForm : Form
    {

        public Game Game = new Game();

        public StartForm()
        {
            InitializeComponent();
        }

        private void NewPlayer(object sender, EventArgs e)
        {

            

            //this.Game = new Game();
            //playerTable.DataSource = this.Game.Players;
            //playerTable.Update();
            //nameLabel.Text = "Min text!";
            //nameLabel.Text = this.Game.StartDate.ToString();
            //nameLabel.Text = this.Game.Players.ToString();
        }

        private void NewGame(object sender, EventArgs e)
        {
            Game.CreateData();
            MessageBox.Show("Game data created!");
            playerTable.DataSource = Game.Players;
            playerTable.Update();
        }
    }
}
