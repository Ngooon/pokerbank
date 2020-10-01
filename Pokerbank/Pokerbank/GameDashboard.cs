﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Pokerbank
{
    public class GameDashboard : Form
    {
        public GameDashboard(Game game)
        {
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Name = "GameDashboard";
            this.Text = "Game Dashboard";
            this.Font = new Font("Arial", 15);
            int i = 0;
            foreach (Player player in game.Players)
            {
                this.Controls.Add(newPlayerGroupBox(player, i));
                i++;
            }
        }

        private GroupBox newPlayerGroupBox(Player player, int boxNumber)
        {
            Point point = new Point(40, 50);

            GroupBox box = new GroupBox();
            box.Text = "Player " + (boxNumber + 1);
            box.Location = new Point(boxNumber * 250 + 25, 25);
            box.AutoSize = true;
            box.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            box.MinimumSize = new Size(200, 200);

            Label lblPlayer = new Label();
            lblPlayer.Location = new Point(point.X + 0, point.Y + 0);
            lblPlayer.Text = player.Name;

            Label lblMoney = new Label();
            lblMoney.Location = new Point(point.X + 0, point.Y + 50);
            lblMoney.Text = player.Wallet.Money.ToString();

            Button btnBet = new Button();
            btnBet.Location = new Point(point.X + 0, point.Y + 100); 
            btnBet.Size = new Size(100, 50);
            btnBet.Text = "Bet";
            

            box.Controls.Add(lblPlayer);
            box.Controls.Add(lblMoney);
            box.Controls.Add(btnBet);

            return box;
        }
    }
}