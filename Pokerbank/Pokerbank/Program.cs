using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokerbank
{

    class Wallet
    {
        public int Money { get; set; }
        
        public void TransferTo(Player reciver, int value)
        {
            Money -= value;
            reciver.Wallet.Money += value;
            //return "Transfer succed!";
        }

        public Wallet(int Money)
        {
            if (Money < 1)
            {

            }
            else
            {
                this.Money = Money
            }
        }
    }

    class Player
    {
        public string Name { get; set; }

        public Wallet Wallet;
        
        public Player(string Name, int startMoney)
        {
            this.Name = Name;
            Wallet = new Wallet(startMoney);
        }

        public override string ToString()
        {
            return "Name = " + Name + ", money = " + Wallet.Money;
        }

    }

    

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
