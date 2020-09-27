using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokerbank
{
    public partial class NewGameForm : Form
    {
        public Game Game = new Game();

        public NewGameForm()
        {
            InitializeComponent();
            txbDate.Text = DateTime.Now.ToString();
        }

        private void SaveForm(object sender, EventArgs e)
        {
            this.Game.Name = txbGameName.Text;
            this.Game.StartDate = Convert.ToDateTime(txbDate.Text);

            // Players
            List<Player> players = new List<Player>();
            foreach(DataGridViewRow row in dgvPlayers.Rows)
            {
                string name = Convert.ToString(row.Cells[0].Value);
                int money = Convert.ToInt32(row.Cells[1].Value);
                Player player = new Player(name, money);
                players.Add(player);
            }
            this.Game.Players = players;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
