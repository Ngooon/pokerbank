using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokerbank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string playerName = this.playerName.Text;
            int startMoney = Convert.ToInt32(this.startMoney.Text);
            Player program.MyPlayer = new Player(playerName, startMoney);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void getButton_Click(object sender, EventArgs e)
        {
            this.result.Text = this.;
        }
    }
}
