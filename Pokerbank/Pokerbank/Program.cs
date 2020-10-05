using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokerbank
{
    public class Funds
    {
        private int Amount { get; set; }
        private string Currency { get; set; }
        
        public void TransferToPlayer(Player reciver, int value)
        {
            this.Add(value);
            reciver.Funds.Add(value);
        }
        
        public void TransferToFunds(Funds reciver, int value)
        {
            this.Add(value);
            reciver.Add(value);
        }

        public Funds()
        {
            this.Amount = 0;
            this.Currency = "";
        }

        public Funds(string currency)
        {
            this.Amount = 0;
            this.Currency = currency;
        }

        public Funds(int money)
        {
            if (money >= 0)
            {
                this.Amount = money;
            }
            else
            {
                this.Amount = 0;
            }
        }

        public Funds(int money, string currency)
        {
            if (money >= 0)
            {
                this.Amount = money;
            }
            else
            {
                this.Amount = 0;
            }
            this.Currency = currency;
        }

        public string CurrencyEndingString()
        {
            if (this.Currency == "")
            {
                return "";
            }
            else
            {
                return " " + this.Currency;
            }
            
        }

        public override string ToString()
        {
            return this.GetAmount().ToString() + this.CurrencyEndingString();
        }

        public void Add(int value)
        {
            this.Amount += value;
        }

        public void SetTo(int value)
        {
            this.Amount = value;
        }

        public int GetAmount()
        {
            return this.Amount;
        }
    }

    public class Player
    {
        public string Name { get; set; }

        public Funds Funds = new Funds();

        public Funds Table = new Funds();
        
        public Player(string name, int startMoney)
        {
            
            this.Name = name;
            this.Funds.Add(startMoney);
        }

        public override string ToString()
        {
            return "Name = " + Name + ", money = " + Funds.ToString();
        }

        //public static List<Player> NewPlayerForm()
        //{

        //    Application.Run(new NewPlayersForm());
        //    return true;
        //}

        public class EmptyNameException : Exception
        {
            string message = "Name can't be empty!";
            public override string ToString()
            {
                return message;
            }
        }
    }

    public class Game
    {
        public string Name { get; set; }

        public Funds StartMoney = new Funds();
        public List<Player> Players { get; set; }
        public DateTime StartDate { get; set; }

        public Game()
        {
            //this.StartDate = DateTime.Now;
            //this.Players = Program.CreatePlayersList();
        }

        public Game(string name)
        {
            this.StartDate = DateTime.Now;
            this.Name = name;
            //this.Players = Program.CreatePlayersList();
        }

        public bool CreateData()
        {
            using (NewGameForm form = new NewGameForm())
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Game formGame = form.Game;
                    this.Name = formGame.Name;
                    this.Players = formGame.Players;
                    this.StartDate = formGame.StartDate;
                    this.StartMoney.SetTo(formGame.StartMoney.GetAmount());
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Play()
        {
            using (GameDashboard dashboard = new GameDashboard(this))
            {
                dashboard.ShowDialog();
            }
        }

    }

    

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }

        public static List<Player> CreatePlayersList()
        {
            List<Player> players = new List<Player>();
            players.Add(new Player("Oscar", 100));
            players.Add(new Player("Melvin", 50));
            MessageBox.Show("Player created! Money: " + players[0].ToString() + "!");
            return players;
        }

    }
}
