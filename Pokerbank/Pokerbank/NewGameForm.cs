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
            this.Game.StartMoney.SetTo(Convert.ToInt32(txbStartMoney.Text));

            // Players
            List<Player> players = new List<Player>();
            foreach (DataGridViewRow row in dgvPlayers.Rows)
            {
                if (row.Cells[0].Value != null) //Name is filled
                {
                    string name = Convert.ToString(row.Cells[0].Value);
                    int money = Convert.ToInt32(row.Cells[1].Value);
                    Player player = new Player(name, money);
                    players.Add(player);
                }  
            }
            this.Game.Players = players;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void newRowUpdate(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int rowIndex = e.RowIndex - 1;
            dgvPlayers.Rows[rowIndex].Cells[1].Value = txbStartMoney.Text;
            dgvPlayers.Rows[rowIndex].Cells[1].ReadOnly = true;
            dgvPlayers.Rows[rowIndex].Cells[2].Value = true;
            //foreach (DataGridViewRow row in dgvPlayers.Rows)
            //{
            //    int myCol = 1;
            //    if (row.Cells[myCol].Value == null)
            //    {
            //        row.Cells[myCol].Value = txbStartMoney.Text;
            //    }

            //}
        }

        private void updateReadOnly(object sender, DataGridViewCellEventArgs e)
        {
            int colIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            if (colIndex == 2)
            {
                if (Convert.ToBoolean(dgvPlayers.Rows[rowIndex].Cells[colIndex].Value) == false)
                {
                    dgvPlayers.Rows[rowIndex].Cells[1].ReadOnly = false;
                }
                else
                {
                    dgvPlayers.Rows[rowIndex].Cells[1].ReadOnly = true;
                }
            }
        }
    }
}
