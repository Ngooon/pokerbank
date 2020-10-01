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

        private void playGame(object sender, EventArgs e)
        {
            Game.Play();
            //using (GameDashboard dashboard = new GameDashboard(Game))
            //{
            //    dashboard.Show();
            //} 
                
            
        }

        private void newGame(object sender, EventArgs e)
        {
            if (Game.CreateData() == true)
            {
                UpdateGameData();
            }
        }

        public void UpdateGameData()
        {
            lblGameName.Text = Game.Name.ToString();
            lblDate.Text = Game.StartDate.ToShortDateString() + " " + Game.StartDate.ToShortTimeString();
            lblStartMoney.Text = Game.StartMoney.ToString() + " SEK";

            //Players
            dgvPlayers.ColumnCount = 2;
            dgvPlayers.ColumnHeadersVisible = true;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgvPlayers.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dgvPlayers.Columns[0].Name = "Name";
            dgvPlayers.Columns[1].Name = "Money";

            for (int i = 0; i < Game.Players.Count; i++)
            {
                Player player = Game.Players[i];
                String[] row = new string[] { player.Name, player.Wallet.Money.ToString() };
                dgvPlayers.Rows.Add(row);

            }
        }
    }
}
