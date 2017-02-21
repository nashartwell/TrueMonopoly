using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class build : Form
    {
        int turnNum, player1Mon, player2Mon, player3Mon, player4Mon;
        int brown1, brown2, lightblue1, lightblue2, lightblue3, pink1, pink2, pink3, orange1, orange2, orange3, red1, red2, red3, yellow1, yellow2,
            yellow3, green1, green2, green3, darkblue1, darkblue2;
         int player1Pos, player2Pos, player3Pos, player4Pos;
        List<int> player1Props = new List<int>();
        List<int> player2Props = new List<int>();
        List<int> player3Props = new List<int>();
        List<int> player4Props = new List<int>();

        public build(List<int> player1Props, List<int> player2Props, List<int> player3Props, List<int> player4Props, int turnNum, int player1Mon, int player2Mon, int player3Mon, int player4Mon, int player1Pos, int player2Pos, int player3Pos, int player4Pos)
        {
            this.player1Props = player1Props;
            this.player2Props = player2Props;
            this.player3Props = player3Props;
            this.player4Props = player4Props;
            this.turnNum = turnNum;
            this.player1Mon = player1Mon;
            this.player2Mon = player2Mon;
            this.player3Mon = player3Mon;
            this.player4Mon = player4Mon;
            this.player1Pos = player1Pos;
            this.player2Pos = player2Pos;
            this.player3Pos = player3Pos;
            this.player4Pos = player4Pos;
            InitializeComponent();
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }
        /*  InitializeComponent();
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString(); */
        private void prop2_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.brown1;
        }

        private void prop2_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop4_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.brown2;
        }

        private void prop4_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop7_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.lightblue1;
        }

        private void prop7_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop9_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.lightblue2;
        }

        private void prop9_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop10_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.lightblue3;
        }

        private void prop10_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop12_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.pink1;
        }

        private void prop12_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop14_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.pink2;
        }

        private void prop14_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop15_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.pink3;
        }

        private void prop15_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop17_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.orange1;
        }

        private void prop17_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop19_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.orange2;
        }

        private void prop19_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop20_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.orange3;
        }

        private void prop20_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop22_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.red1;
        }

        private void prop22_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop24_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.red2;
        }

        private void prop24_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop25_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.red3;
        }

        private void prop25_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop27_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.yellow1;
        }

        private void prop27_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop28_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.yellow2;
        }

        private void prop28_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop30_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.yellow3;
        }

        private void prop30_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop32_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.green1;
        }

        private void prop32_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop33_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.green2;
        }

        private void prop33_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop38_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.darkblue1;
        }

        private void prop38_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop35_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.green3;
        }

        private void prop35_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop40_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.darkblue2;
        }

        private void prop40_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop6_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.rr1;
        }

        private void prop36_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop16_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.rr2;
        }

        private void prop26_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.rr3;
        }

        private void prop16_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop26_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop36_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.rr4;
        }

        private void prop13_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.utility1;
        }

        private void prop13_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void prop29_MouseEnter(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.utility2;
        }

        private void prop29_MouseLeave(object sender, EventArgs e)
        {
            propBigBox.Image = Monopoly.Properties.Resources.none;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(player1Props, player2Props, player3Props, player4Props, turnNum, player1Mon, player2Mon, player3Mon, player4Mon, brown1, brown2, lightblue1, lightblue2, lightblue3, pink1, pink2, pink3, orange1, orange2, orange3, red1, red2, red3, yellow1, yellow2, yellow3, green1, green2, green3, darkblue1, darkblue2, player1Pos, player2Pos, player3Pos, player4Pos);
            f.Show();
            Form1 fs = new Form1(player1Props, player2Props, player3Props, player4Props, turnNum, player1Mon, player2Mon, player3Mon, player4Mon, brown1, brown2, lightblue1, lightblue2, lightblue3, pink1, pink2, pink3, orange1, orange2, orange3, red1, red2, red3, yellow1, yellow2, yellow3, green1, green2, green3, darkblue1, darkblue2, player1Pos, player2Pos, player3Pos, player4Pos);
            fs.Hide();
            this.Close();
        }

        private void prop2_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(2) && player1Props.Contains(4))
                    {
                        player1Mon -= 50; 
                        brown1++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(2) && player2Props.Contains(4))
                    {
                        player2Mon -= 50;
                        brown1++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(2) && player3Props.Contains(4))
                    {
                        player3Mon -= 50;
                        brown1++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(2) && player4Props.Contains(4))
                    {
                        player4Mon -= 50;
                        brown1++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }

        private void prop4_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(2) && player1Props.Contains(4))
                    {
                        player1Mon -= 50;
                        brown2++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(2) && player2Props.Contains(4))
                    {
                        player2Mon -= 50;
                        brown2++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(2) && player3Props.Contains(4))
                    {
                        player3Mon -= 50;
                        brown2++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(2) && player4Props.Contains(4))
                    {
                        player4Mon -= 50;
                        brown2++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }

        private void prop7_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(7) && player1Props.Contains(9) && player1Props.Contains(10))
                    {
                        player1Mon -= 50;
                        lightblue1++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(7) && player2Props.Contains(9) && player2Props.Contains(10))
                    {
                        player2Mon -= 50;
                        lightblue1++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(7) && player3Props.Contains(9) && player3Props.Contains(10))
                    {
                        player3Mon -= 50;
                        lightblue1++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(7) && player4Props.Contains(9) && player4Props.Contains(10))
                    {
                        player4Mon -= 50;
                        lightblue1++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }

        private void prop9_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(7) && player1Props.Contains(9) && player1Props.Contains(10))
                    {
                        player1Mon -= 50;
                        lightblue2++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(7) && player2Props.Contains(9) && player2Props.Contains(10))
                    {
                        player2Mon -= 50;
                        lightblue2++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(7) && player3Props.Contains(9) && player3Props.Contains(10))
                    {
                        player3Mon -= 50;
                        lightblue2++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(7) && player4Props.Contains(9) && player4Props.Contains(10))
                    {
                        player4Mon -= 50;
                        lightblue2++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }

        private void prop10_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(7) && player1Props.Contains(9) && player1Props.Contains(10))
                    {
                        player1Mon -= 50;
                        lightblue3++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(7) && player2Props.Contains(9) && player2Props.Contains(10))
                    {
                        player2Mon -= 50;
                        lightblue3++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(7) && player3Props.Contains(9) && player3Props.Contains(10))
                    {
                        player3Mon -= 50;
                        lightblue3++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(7) && player4Props.Contains(9) && player4Props.Contains(10))
                    {
                        player4Mon -= 50;
                        lightblue3++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }

        private void prop12_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(12) && player1Props.Contains(14) && player1Props.Contains(15))
                    {
                        player1Mon -= 100;
                        pink1++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(12) && player2Props.Contains(14) && player2Props.Contains(15))
                    {
                        player2Mon -= 100;
                        pink1++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(12) && player3Props.Contains(14) && player3Props.Contains(15))
                    {
                        player3Mon -= 100;
                        pink1++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(12) && player4Props.Contains(14) && player4Props.Contains(15))
                    {
                        player4Mon -= 100;
                        pink1++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }
        private void prop14_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(12) && player1Props.Contains(14) && player1Props.Contains(15))
                    {
                        player1Mon -= 100;
                        pink2++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(12) && player2Props.Contains(14) && player2Props.Contains(15))
                    {
                        player2Mon -= 100;
                        pink2++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(12) && player3Props.Contains(14) && player3Props.Contains(15))
                    {
                        player3Mon -= 100;
                        pink2++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(12) && player4Props.Contains(14) && player4Props.Contains(15))
                    {
                        player4Mon -= 100;
                        pink2++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }
        private void prop15_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(12) && player1Props.Contains(14) && player1Props.Contains(15))
                    {
                        player1Mon -= 100;
                        pink3++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(12) && player2Props.Contains(14) && player2Props.Contains(15))
                    {
                        player2Mon -= 100;
                        pink3++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(12) && player3Props.Contains(14) && player3Props.Contains(15))
                    {
                        player3Mon -= 100;
                        pink3++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(12) && player4Props.Contains(14) && player4Props.Contains(15))
                    {
                        player4Mon -= 100;
                        pink3++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }
        private void prop17_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(17) && player1Props.Contains(19) && player1Props.Contains(20))
                    {
                        player1Mon -= 100;
                        orange1++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(17) && player2Props.Contains(19) && player2Props.Contains(20))
                    {
                        player2Mon -= 100;
                        orange1++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(17) && player3Props.Contains(19) && player3Props.Contains(20))
                    {
                        player3Mon -= 100;
                        orange1++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(17) && player4Props.Contains(19) && player4Props.Contains(20))
                    {
                        player4Mon -= 100;
                        orange1++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }
        private void prop19_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(17) && player1Props.Contains(19) && player1Props.Contains(20))
                    {
                        player1Mon -= 100;
                        orange2++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(17) && player2Props.Contains(19) && player2Props.Contains(20))
                    {
                        player2Mon -= 100;
                        orange2++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(17) && player3Props.Contains(19) && player3Props.Contains(20))
                    {
                        player3Mon -= 100;
                        orange2++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(17) && player4Props.Contains(19) && player4Props.Contains(20))
                    {
                        player4Mon -= 100;
                        orange2++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }
        private void prop20_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(17) && player1Props.Contains(19) && player1Props.Contains(20))
                    {
                        player1Mon -= 100;
                        orange3++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(17) && player2Props.Contains(19) && player2Props.Contains(20))
                    {
                        player2Mon -= 100;
                        orange3++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(17) && player3Props.Contains(19) && player3Props.Contains(20))
                    {
                        player3Mon -= 100;
                        orange3++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(17) && player4Props.Contains(19) && player4Props.Contains(20))
                    {
                        player4Mon -= 100;
                        orange3++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }
        private void prop22_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(22) && player1Props.Contains(24) && player1Props.Contains(25))
                    {
                        player1Mon -= 150;
                        red1++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(22) && player2Props.Contains(24) && player2Props.Contains(25))
                    {
                        player2Mon -= 150;
                        red1++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(22) && player3Props.Contains(24) && player3Props.Contains(25))
                    {
                        player3Mon -= 150;
                        red1++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(22) && player4Props.Contains(24) && player4Props.Contains(25))
                    {
                        player4Mon -= 150;
                        red1++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }
        private void prop24_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(22) && player1Props.Contains(24) && player1Props.Contains(25))
                    {
                        player1Mon -= 150;
                        red2++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(22) && player2Props.Contains(24) && player2Props.Contains(25))
                    {
                        player2Mon -= 150;
                        red2++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(22) && player3Props.Contains(24) && player3Props.Contains(25))
                    {
                        player3Mon -= 150;
                        red2++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(22) && player4Props.Contains(24) && player4Props.Contains(25))
                    {
                        player4Mon -= 150;
                        red2++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }
        private void prop25_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(22) && player1Props.Contains(24) && player1Props.Contains(25))
                    {
                        player1Mon -= 150;
                        red3++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(22) && player2Props.Contains(24) && player2Props.Contains(25))
                    {
                        player2Mon -= 150;
                        red3++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(22) && player3Props.Contains(24) && player3Props.Contains(25))
                    {
                        player3Mon -= 150;
                        red3++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(22) && player4Props.Contains(24) && player4Props.Contains(25))
                    {
                        player4Mon -= 150;
                        red3++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }
        private void prop27_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(27) && player1Props.Contains(28) && player1Props.Contains(30))
                    {
                        player1Mon -= 150;
                        yellow1++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(27) && player2Props.Contains(28) && player2Props.Contains(30))
                    {
                        player2Mon -= 150;
                        yellow1++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(27) && player3Props.Contains(28) && player3Props.Contains(30))
                    {
                        player3Mon -= 150;
                        yellow1++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(27) && player4Props.Contains(28) && player4Props.Contains(30))
                    {
                        player4Mon -= 150;
                        yellow1++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }
        private void prop28_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(27) && player1Props.Contains(28) && player1Props.Contains(30))
                    {
                        player1Mon -= 150;
                        yellow2++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(27) && player2Props.Contains(28) && player2Props.Contains(30))
                    {
                        player2Mon -= 150;
                        yellow2++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(27) && player3Props.Contains(28) && player3Props.Contains(30))
                    {
                        player3Mon -= 150;
                        yellow2++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(27) && player4Props.Contains(28) && player4Props.Contains(30))
                    {
                        player4Mon -= 150;
                        yellow2++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }
        private void prop30_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(27) && player1Props.Contains(28) && player1Props.Contains(30))
                    {
                        player1Mon -= 150;
                        yellow3++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(27) && player2Props.Contains(28) && player2Props.Contains(30))
                    {
                        player2Mon -= 150;
                        yellow3++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(27) && player3Props.Contains(28) && player3Props.Contains(30))
                    {
                        player3Mon -= 150;
                        yellow3++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(27) && player4Props.Contains(28) && player4Props.Contains(30))
                    {
                        player4Mon -= 150;
                        yellow3++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }
        private void prop32_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(32) && player1Props.Contains(33) && player1Props.Contains(35))
                    {
                        player1Mon -= 200;
                        green1++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(32) && player2Props.Contains(33) && player2Props.Contains(35))
                    {
                        player2Mon -= 200;
                        green1++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(32) && player3Props.Contains(33) && player3Props.Contains(35))
                    {
                        player3Mon -= 200;
                        green1++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(32) && player4Props.Contains(33) && player4Props.Contains(35))
                    {
                        player4Mon -= 200;
                        green1++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }
        private void prop33_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(32) && player1Props.Contains(33) && player1Props.Contains(35))
                    {
                        player1Mon -= 200;
                        green2++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(32) && player2Props.Contains(33) && player2Props.Contains(35))
                    {
                        player2Mon -= 200;
                        green2++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(32) && player3Props.Contains(33) && player3Props.Contains(35))
                    {
                        player3Mon -= 200;
                        green2++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(32) && player4Props.Contains(33) && player4Props.Contains(35))
                    {
                        player4Mon -= 200;
                        green2++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }
        private void prop35_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(32) && player1Props.Contains(33) && player1Props.Contains(35))
                    {
                        player1Mon -= 200;
                        green3++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(32) && player2Props.Contains(33) && player2Props.Contains(35))
                    {
                        player2Mon -= 200;
                        green3++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(32) && player3Props.Contains(33) && player3Props.Contains(35))
                    {
                        player3Mon -= 200;
                        green3++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(32) && player4Props.Contains(33) && player4Props.Contains(35))
                    {
                        player4Mon -= 200;
                        green3++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }
        private void prop38_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(38) && player1Props.Contains(40))
                    {
                        player1Mon -= 200;
                        darkblue1++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(38) && player2Props.Contains(40))
                    {
                        player2Mon -= 200;
                        darkblue1++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(38) && player3Props.Contains(40))
                    {
                        player3Mon -= 200;
                        darkblue1++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(38) && player4Props.Contains(40))
                    {
                        player4Mon -= 200;
                        darkblue1++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }
        private void prop40_Click(object sender, EventArgs e)
        {
            switch (turnNum)
            {
                case 1:
                    if (player1Props.Contains(38) && player1Props.Contains(40))
                    {
                        player1Mon -= 200;
                        darkblue2++;
                    }
                    break;
                case 2:
                    if (player2Props.Contains(38) && player2Props.Contains(40))
                    {
                        player2Mon -= 200;
                        darkblue2++;
                    }
                    break;
                case 3:
                    if (player3Props.Contains(38) && player3Props.Contains(40))
                    {
                        player3Mon -= 200;
                        darkblue2++;
                    }
                    break;
                case 4:
                    if (player4Props.Contains(38) && player4Props.Contains(40))
                    {
                        player4Mon -= 200;
                        darkblue2++;
                    }
                    break;
            }
            player1Money.Text = "$ " + player1Mon.ToString();
            player2Money.Text = "$ " + player2Mon.ToString();
            player3Money.Text = "$ " + player3Mon.ToString();
            player4Money.Text = "$ " + player4Mon.ToString();
        }

        //public bool prop40Owned { get; set; }
    }
}

