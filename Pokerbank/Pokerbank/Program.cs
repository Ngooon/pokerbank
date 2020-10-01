using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokerbank
{

    //public class Money
    //{
    //    public int myMoney { get; set; }

        

    //    public string StingCurrency()
    //    {
    //        return myMoney + " kr";
    //    }
    //}

    public class Wallet
    {
        public int Money { get; set; }
        
        public void TransferTo(Player reciver, int value)
        {
            Money -= value;
            reciver.Wallet.Money += value;
            //return "Transfer succed!";
        }

        public Wallet()
        {
            this.Money = 0;
        }

        public Wallet(int money)
        {
            if (money < 1)
            {

            }
            else
            {
                this.Money = money;
            }
        }

        public override string ToString()
        {
            return "Money: " + Money.ToString();
        }
    }

    public class Player
    {
        public string Name { get; set;
            //get
            //{
            //    return Name;
            //}
            //set
            //{
            //    if (value != null)
            //    {
            //        Name = Convert.ToString(value);
            //    }
            //    else throw new EmptyNameException();
            //}
        }

        public Wallet Wallet = new Wallet();
        
        public Player(string name, int startMoney)
        {
            
            this.Name = name;
            this.Wallet.Money = startMoney;
        }

        public override string ToString()
        {
            return "Name = " + Name + ", money = " + Wallet.Money;
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

        public int StartMoney { get; set; }
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
                    this.StartMoney = formGame.StartMoney;
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
