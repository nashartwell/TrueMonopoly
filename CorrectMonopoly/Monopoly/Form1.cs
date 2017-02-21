using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Monopoly
{
    public partial class Form1 : Form
    {
        public int jailRoll = 0, turnNum=1, cc, chancecard;
        public int player1Pos = 1, jail1free = 0;
        public int player2Pos = 1, jail2free = 0;
        public int player3Pos = 1, jail3free = 0;
        public int player4Pos = 1, jail4free = 0;
        public int player1Mon = 1500;
        public int player2Mon = 1500;
        public int player3Mon = 1500;
        public int player4Mon = 1500;
        public int totalTurns = 1;
        public int cost = 0;
        public int selectedProp = 0;
        public int rent = 0;
        public int derp = 0;
        public List<int> player1Props = new List<int>();
        public List<int> player2Props = new List<int>();
        public List<int> player3Props = new List<int>();
        public List<int> player4Props = new List<int>();

        public bool doubles = false;

        public bool prop1Owned = false;
        public bool prop2Owned = false;
        public bool prop3Owned = false;
        public bool prop4Owned = false;
        public bool prop5Owned = false;
        public bool prop6Owned = false;
        public bool prop7Owned = false;
        public bool prop8Owned = false;
        public bool prop9Owned = false;
        public bool prop10Owned = false;
        public bool prop11Owned = false;
        public bool prop12Owned = false;
        public bool prop13Owned = false;
        public bool prop14Owned = false;
        public bool prop15Owned = false;
        public bool prop16Owned = false;
        public bool prop17Owned = false;
        public bool prop18Owned = false;
        public bool prop19Owned = false;
        public bool prop20Owned = false;
        public bool prop21Owned = false;
        public bool prop22Owned = false;
        public bool prop23Owned = false;
        public bool prop24Owned = false;
        public bool prop25Owned = false;
        public bool prop26Owned = false;
        public bool prop27Owned = false;
        public bool prop28Owned = false;
        public bool prop29Owned = false;
        public bool prop30Owned = false;
        public bool prop31Owned = false;
        public bool prop32Owned = false;
        public bool prop33Owned = false;
        public bool prop34Owned = false;
        public bool prop35Owned = false;
        public bool prop36Owned = false;
        public bool prop37Owned = false;
        public bool prop38Owned = false;
        public bool prop39Owned = false;
        public bool prop40Owned = false;

        public int brown1;
        public int brown2;
        public int lightblue1;
        public int lightblue2;
        public int lightblue3;
        public int pink1;
        public int pink2;
        public int pink3;
        public int orange1;
        public int orange2;
        public int orange3;
        public int red1;
        public int red2;
        public int red3;
        public int yellow1;
        public int yellow2;
        public int yellow3;
        public int green1;
        public int green2;
        public int green3;
        public int darkblue1;
        public int darkblue2;
        /*private List<int> Player1;
        private List<int> Player2;
        private List<int> Player3;
        private List<int> Player4;*/
        public Form1()
        {
            InitializeComponent();
            turn.Text = "Player " + turnNum + "'s";
            player1Props.Add(2);
            player1Props.Add(4);
        }

        public Form1(List<int> player1Props, List<int> player2Props, List<int> player3Props, List<int> player4Props, int turnNum, int player1Mon, int player2Mon, int player3Mon, int player4Mon, int brown1, int brown2, int lightblue1, int lightblue2, int lightblue3, int pink1, int pink2, int pink3, int orange1, int orange2, int orange3, int red1, int red2, int red3, int yellow1, int yellow2, int yellow3, int green1, int green2, int green3, int darkblue1, int darkblue2, int player1Pos, int player2Pos, int player3Pos, int player4Pos)
        {
            InitializeComponent();
            this.player1Props = player1Props;
            this.player2Props = player2Props;
            this.player3Props = player3Props;
            this.player4Props = player4Props;
            this.turnNum = turnNum;
            this.player1Mon = player1Mon;
            this.player2Mon = player2Mon;
            this.player3Mon = player3Mon;
            this.player4Mon = player4Mon;
            this.brown1 = brown1;
            this.brown2 = brown2;
            this.lightblue1 = lightblue1;
            this.lightblue2 = lightblue2;
            this.lightblue3 = lightblue3;
            this.pink1 = pink1;
            this.pink2 = pink2;
            this.pink3 = pink3;
            this.orange1 = orange1;
            this.orange2 = orange2;
            this.orange3 = orange3;
            this.red1 = red1;
            this.red2 = red2;
            this.red3 = red3;
            this.yellow1 = yellow1;
            this.yellow2 = yellow2;
            this.yellow3 = yellow3;
            this.green1 = green1;
            this.green2 = green2;
            this.green3 = green3;
            this.darkblue1 = darkblue1;
            this.darkblue2 = darkblue2;
            this.player1Pos = player1Pos;
            this.player2Pos = player2Pos;
            this.player3Pos = player3Pos;
            this.player4Pos = player4Pos;
            turn.Text = "Player " + turnNum + "'s";
            player1Money.Text = player1Mon.ToString();
            player2Money.Text = player2Mon.ToString();
            player3Money.Text = player3Mon.ToString();
            player4Money.Text = player4Mon.ToString();
            houses();
            redraw();
            position();
        }

        public Form1(List<int> Player1, List<int> Player2, List<int> Player3, List<int> Player4,int money1,int money2,int money3,int money4)
        {
            player1Mon = money1;
            player2Mon = money2;
            player3Mon = money3;
            player4Mon = money4;
            InitializeComponent();
            player1Props = Player1;
            player2Props = Player2;
            player3Props = Player3;
            player4Props = Player4;
            redraw();
        }

        public void redraw()
        {
            int r;
            for (int i = 0; i < 41; i++)
            {
                if (player1Props.Contains(i))
                {
                    r = 1;
                    redrawProps(i, r);
                }
            }
            r = 2;
            for (int i = 0; i < 41; i++)
            {
                if (player2Props.Contains(i))
                {
                    r = 1;
                    redrawProps(i, r);
                }
            }
            r = 3;
            for (int i = 0; i < 41; i++)
            {
                if (player3Props.Contains(i))
                {
                    r = 1;
                    redrawProps(i, r);
                }
            }
            r = 4;
            for (int i = 0; i < 41; i++)
            {
                if (player4Props.Contains(i))
                {
                    r = 1;
                    redrawProps(i, r);
                }
            }

            /*player1Money.Text = player1Mon.ToString();
            player2Money.Text = player2Mon.ToString();
            player3Money.Text = player3Mon.ToString();
            player4Money.Text = player4Mon.ToString();*/
        }
        public void redrawProps(int n,int r)
        {
            switch (n)
            {
                case 2:
                    switch (r)
                    {
                        case 1:
                            prop2.Image = Monopoly.Properties.Resources.redowned;
                            break;
                        case 2:
                            prop2.Image = Monopoly.Properties.Resources.pinkowned;
                            break;
                        case 3:
                            prop2.Image = Monopoly.Properties.Resources.blueowned;
                            break;
                        case 4:
                            prop2.Image = Monopoly.Properties.Resources.greenowned;
                            break;
                    }
                    break;
                case 4:
                    switch (r)
                    {
                        case 1:
                            prop4.Image = Monopoly.Properties.Resources.redowned;
                            break;
                        case 2:
                            prop4.Image = Monopoly.Properties.Resources.pinkowned;
                            break;
                        case 3:
                            prop4.Image = Monopoly.Properties.Resources.blueowned;
                            break;
                        case 4:
                            prop4.Image = Monopoly.Properties.Resources.greenowned;
                            break;
                    }
                    break;
                case 6:
                    switch (r)
                    {
                        case 1:
                            prop6.Image = Monopoly.Properties.Resources.redowned;
                            break;
                        case 2:
                            prop6.Image = Monopoly.Properties.Resources.pinkowned;
                            break;
                        case 3:
                            prop6.Image = Monopoly.Properties.Resources.blueowned;
                            break;
                        case 4:
                            prop6.Image = Monopoly.Properties.Resources.greenowned;
                            break;
                    }
                    break;
                case 7:
                    switch (r)
                    {
                        case 1:
                            prop7.Image = Monopoly.Properties.Resources.redowned;
                            break;
                        case 2:
                            prop7.Image = Monopoly.Properties.Resources.pinkowned;
                            break;
                        case 3:
                            prop7.Image = Monopoly.Properties.Resources.blueowned;
                            break;
                        case 4:
                            prop7.Image = Monopoly.Properties.Resources.greenowned;
                            break;
                    }
                    break;
                case 9:
                    switch (r)
                    {
                        case 1:
                            prop9.Image = Monopoly.Properties.Resources.redowned;
                            break;
                        case 2:
                            prop9.Image = Monopoly.Properties.Resources.pinkowned;
                            break;
                        case 3:
                            prop9.Image = Monopoly.Properties.Resources.blueowned;
                            break;
                        case 4:
                            prop9.Image = Monopoly.Properties.Resources.greenowned;
                            break;
                    }
                    break;
                case 10:
                    switch (r)
                    {
                        case 1:
                            prop10.Image = Monopoly.Properties.Resources.redowned;
                            break;
                        case 2:
                            prop10.Image = Monopoly.Properties.Resources.pinkowned;
                            break;
                        case 3:
                            prop10.Image = Monopoly.Properties.Resources.blueowned;
                            break;
                        case 4:
                            prop10.Image = Monopoly.Properties.Resources.greenowned;
                            break;
                    }
                    break;
            }
        }

        public void houses()
        {
            if (brown1 == 1)
            {
                b1h1.Image = Monopoly.Properties.Resources.house;
                b1h1.Visible = true;
            }
            if (brown1 == 2)
            {
                b1h1.Image = Monopoly.Properties.Resources.house;
                b1h2.Image = Monopoly.Properties.Resources.house;
                b1h1.Visible = true;
                b1h2.Visible = true;
            }
            if (brown1 == 3)
            {
                b1h1.Image = Monopoly.Properties.Resources.house;
                b1h2.Image = Monopoly.Properties.Resources.house;
                b1h3.Image = Monopoly.Properties.Resources.house;
                b1h1.Visible = true;
                b1h2.Visible = true;
                b1h3.Visible = true;
            }
            if (brown1 == 4)
            {
                b1h1.Image = Monopoly.Properties.Resources.house;
                b1h2.Image = Monopoly.Properties.Resources.house;
                b1h3.Image = Monopoly.Properties.Resources.house;
                b1h4.Image = Monopoly.Properties.Resources.house;
                b1h1.Visible=true;
                b1h2.Visible = true;
                b1h3.Visible = true;
                b1h4.Visible = true;
            }
            if (brown2 == 1)
            {
                b2h1.Image = Monopoly.Properties.Resources.house;
                b2h1.Visible = true;
            }
            if (brown2 == 2)
            {
                b2h1.Image = Monopoly.Properties.Resources.house;
                b2h2.Image = Monopoly.Properties.Resources.house;
                b2h1.Visible = true;
                b2h2.Visible = true;
            }
            if (brown2 == 3)
            {
                b2h1.Image = Monopoly.Properties.Resources.house;
                b2h2.Image = Monopoly.Properties.Resources.house;
                b2h3.Image = Monopoly.Properties.Resources.house;
                b2h1.Visible = true;
                b2h2.Visible = true;
                b2h3.Visible = true;
            }
            if (brown2 == 4)
            {
                b2h1.Image = Monopoly.Properties.Resources.house;
                b2h2.Image = Monopoly.Properties.Resources.house;
                b2h3.Image = Monopoly.Properties.Resources.house;
                b2h4.Image = Monopoly.Properties.Resources.house;
                b2h1.Visible = true;
                b2h2.Visible = true;
                b2h3.Visible = true;
                b2h4.Visible = true;
            }
            //lightblue
            if (lightblue1 == 1)
            {
                lb1h1.Image = Monopoly.Properties.Resources.house;
                lb1h1.Visible = true;
            }
            if (lightblue1 == 2)
            {
                lb1h1.Image = Monopoly.Properties.Resources.house;
                lb1h2.Image = Monopoly.Properties.Resources.house;
                lb1h1.Visible = true;
                lb1h2.Visible = true;
            }
            if (lightblue1 == 3)
            {
                lb1h1.Image = Monopoly.Properties.Resources.house;
                lb1h2.Image = Monopoly.Properties.Resources.house;
                lb1h3.Image = Monopoly.Properties.Resources.house;
                lb1h1.Visible = true;
                lb1h2.Visible = true;
                lb1h3.Visible = true;
            }
            if (lightblue1 == 4)
            {
                lb1h1.Image = Monopoly.Properties.Resources.house;
                lb1h2.Image = Monopoly.Properties.Resources.house;
                lb1h3.Image = Monopoly.Properties.Resources.house;
                lb1h4.Image = Monopoly.Properties.Resources.house;
                lb1h1.Visible = true;
                lb1h2.Visible = true;
                lb1h3.Visible = true;
                lb1h4.Visible = true;
            }
            if (lightblue2 == 1)
            {
                lb2h1.Image = Monopoly.Properties.Resources.house;
                lb2h1.Visible = true;
            }
            if (lightblue2 == 2)
            {
                lb2h1.Image = Monopoly.Properties.Resources.house;
                lb2h2.Image = Monopoly.Properties.Resources.house;
                lb2h1.Visible = true;
                lb2h2.Visible = true;
            }
            if (lightblue2 == 3)
            {
                lb2h1.Image = Monopoly.Properties.Resources.house;
                lb2h2.Image = Monopoly.Properties.Resources.house;
                lb2h3.Image = Monopoly.Properties.Resources.house;
                lb2h1.Visible = true;
                lb2h2.Visible = true;
                lb2h3.Visible = true;
            }
            if (lightblue2 == 4)
            {
                lb2h1.Image = Monopoly.Properties.Resources.house;
                lb2h2.Image = Monopoly.Properties.Resources.house;
                lb2h3.Image = Monopoly.Properties.Resources.house;
                lb2h4.Image = Monopoly.Properties.Resources.house;
                lb2h1.Visible = true;
                lb2h2.Visible = true;
                lb2h3.Visible = true;
                lb2h4.Visible = true;
            }
            if (lightblue3 == 1)
            {
                lb3h1.Image = Monopoly.Properties.Resources.house;
                lb3h1.Visible = true;
            }
            if (lightblue3 == 2)
            {
                lb3h1.Image = Monopoly.Properties.Resources.house;
                lb3h2.Image = Monopoly.Properties.Resources.house;
                lb3h1.Visible = true;
                lb3h2.Visible = true;
            }
            if (lightblue3 == 3)
            {
                lb3h1.Image = Monopoly.Properties.Resources.house;
                lb3h2.Image = Monopoly.Properties.Resources.house;
                lb3h3.Image = Monopoly.Properties.Resources.house;
                lb3h1.Visible = true;
                lb3h2.Visible = true;
                lb3h3.Visible = true;
            }
            if (lightblue3 == 4)
            {
                lb3h1.Image = Monopoly.Properties.Resources.house;
                lb3h2.Image = Monopoly.Properties.Resources.house;
                lb3h3.Image = Monopoly.Properties.Resources.house;
                lb3h4.Image = Monopoly.Properties.Resources.house;
                lb3h1.Visible = true;
                lb3h2.Visible = true;
                lb3h3.Visible = true;
                lb3h4.Visible = true;
            }
            //pink
            if (pink1 == 1)
            {
                p1h1.Image = Monopoly.Properties.Resources.house;
                p1h1.Visible = true;
            }
            if (pink1 == 2)
            {
                p1h1.Image = Monopoly.Properties.Resources.house;
                p1h2.Image = Monopoly.Properties.Resources.house;
                p1h1.Visible = true;
                p1h2.Visible = true;
            }
            if (pink1 == 3)
            {
                p1h1.Image = Monopoly.Properties.Resources.house;
                p1h2.Image = Monopoly.Properties.Resources.house;
                p1h3.Image = Monopoly.Properties.Resources.house;
                p1h1.Visible = true;
                p1h2.Visible = true;
                p1h3.Visible = true;
            }
            if (pink1 == 4)
            {
                p1h1.Image = Monopoly.Properties.Resources.house;
                p1h2.Image = Monopoly.Properties.Resources.house;
                p1h3.Image = Monopoly.Properties.Resources.house;
                p1h4.Image = Monopoly.Properties.Resources.house;
                p1h1.Visible = true;
                p1h2.Visible = true;
                p1h3.Visible = true;
                p1h4.Visible = true;
            }
            if (pink2 == 1)
            {
                p2h1.Image = Monopoly.Properties.Resources.house;
                p2h1.Visible = true;
            }
            if (pink2 == 2)
            {
                p2h1.Image = Monopoly.Properties.Resources.house;
                p2h2.Image = Monopoly.Properties.Resources.house;
                p2h1.Visible = true;
                p2h2.Visible = true;
            }
            if (pink2 == 3)
            {
                p2h1.Image = Monopoly.Properties.Resources.house;
                p2h2.Image = Monopoly.Properties.Resources.house;
                p2h3.Image = Monopoly.Properties.Resources.house;
                p2h1.Visible = true;
                p2h2.Visible = true;
                p2h3.Visible = true;
            }
            if (pink2 == 4)
            {
                p2h1.Image = Monopoly.Properties.Resources.house;
                p2h2.Image = Monopoly.Properties.Resources.house;
                p2h3.Image = Monopoly.Properties.Resources.house;
                p2h4.Image = Monopoly.Properties.Resources.house;
                p2h1.Visible = true;
                p2h2.Visible = true;
                p2h3.Visible = true;
                p2h4.Visible = true;
            }
            if (pink3 == 1)
            {
                p3h1.Image = Monopoly.Properties.Resources.house;
                p3h1.Visible = true;
            }
            if (pink3 == 2)
            {
                p3h1.Image = Monopoly.Properties.Resources.house;
                p3h2.Image = Monopoly.Properties.Resources.house;
                p3h1.Visible = true;
                p3h2.Visible = true;
            }
            if (pink3 == 3)
            {
                p3h1.Image = Monopoly.Properties.Resources.house;
                p3h2.Image = Monopoly.Properties.Resources.house;
                p3h3.Image = Monopoly.Properties.Resources.house;
                p3h1.Visible = true;
                p3h2.Visible = true;
                p3h3.Visible = true;
            }
            if (pink3 == 4)
            {
                p3h1.Image = Monopoly.Properties.Resources.house;
                p3h2.Image = Monopoly.Properties.Resources.house;
                p3h3.Image = Monopoly.Properties.Resources.house;
                p3h4.Image = Monopoly.Properties.Resources.house;
                p3h1.Visible = true;
                p3h2.Visible = true;
                p3h3.Visible = true;
                p3h4.Visible = true;
            }
            //orange
            if (orange1 == 1)
            {
                o1h1.Image = Monopoly.Properties.Resources.house;
                o1h1.Visible = true;
            }
            if (orange1 == 2)
            {
                o1h1.Image = Monopoly.Properties.Resources.house;
                o1h2.Image = Monopoly.Properties.Resources.house;
                o1h1.Visible = true;
                o1h2.Visible = true;
            }
            if (orange1 == 3)
            {
                o1h1.Image = Monopoly.Properties.Resources.house;
                o1h2.Image = Monopoly.Properties.Resources.house;
                o1h3.Image = Monopoly.Properties.Resources.house;
                o1h1.Visible = true;
                o1h2.Visible = true;
                o1h3.Visible = true;
            }
            if (orange1 == 4)
            {
                o1h1.Image = Monopoly.Properties.Resources.house;
                o1h2.Image = Monopoly.Properties.Resources.house;
                o1h3.Image = Monopoly.Properties.Resources.house;
                o1h4.Image = Monopoly.Properties.Resources.house;
                o1h1.Visible = true;
                o1h2.Visible = true;
                o1h3.Visible = true;
                o1h4.Visible = true;
            }
            if (orange2 == 1)
            {
                o2h1.Image = Monopoly.Properties.Resources.house;
                o2h1.Visible = true;
            }
            if (orange2 == 2)
            {
                o2h1.Image = Monopoly.Properties.Resources.house;
                o2h2.Image = Monopoly.Properties.Resources.house;
                o2h1.Visible = true;
                o2h2.Visible = true;
            }
            if (orange2 == 3)
            {
                o2h1.Image = Monopoly.Properties.Resources.house;
                o2h2.Image = Monopoly.Properties.Resources.house;
                o2h3.Image = Monopoly.Properties.Resources.house;
                o2h1.Visible = true;
                o2h2.Visible = true;
                o2h3.Visible = true;
            }
            if (orange2 == 4)
            {
                o2h1.Image = Monopoly.Properties.Resources.house;
                o2h2.Image = Monopoly.Properties.Resources.house;
                o2h3.Image = Monopoly.Properties.Resources.house;
                o2h4.Image = Monopoly.Properties.Resources.house;
                o2h1.Visible = true;
                o2h2.Visible = true;
                o2h3.Visible = true;
                o2h4.Visible = true;
            }
            if (orange3 == 1)
            {
                o3h1.Image = Monopoly.Properties.Resources.house;
                o3h1.Visible = true;
            }
            if (orange3 == 2)
            {
                o3h1.Image = Monopoly.Properties.Resources.house;
                o3h2.Image = Monopoly.Properties.Resources.house;
                o3h1.Visible = true;
                o3h2.Visible = true;
            }
            if (orange3 == 3)
            {
                o3h1.Image = Monopoly.Properties.Resources.house;
                o3h2.Image = Monopoly.Properties.Resources.house;
                o3h3.Image = Monopoly.Properties.Resources.house;
                o3h1.Visible = true;
                o3h2.Visible = true;
                o3h3.Visible = true;
            }
            if (orange3 == 4)
            {
                o3h1.Image = Monopoly.Properties.Resources.house;
                o3h2.Image = Monopoly.Properties.Resources.house;
                o3h3.Image = Monopoly.Properties.Resources.house;
                o3h4.Image = Monopoly.Properties.Resources.house;
                o3h1.Visible = true;
                o3h2.Visible = true;
                o3h3.Visible = true;
                o3h4.Visible = true;
            }
            //red
            if (red1 == 1)
            {
                r1h1.Image = Monopoly.Properties.Resources.house;
                r1h1.Visible = true;
            }
            if (red1 == 2)
            {
                r1h1.Image = Monopoly.Properties.Resources.house;
                r1h2.Image = Monopoly.Properties.Resources.house;
                r1h1.Visible = true;
                r1h2.Visible = true;
            }
            if (red1 == 3)
            {
                r1h1.Image = Monopoly.Properties.Resources.house;
                r1h2.Image = Monopoly.Properties.Resources.house;
                r1h3.Image = Monopoly.Properties.Resources.house;
                r1h1.Visible = true;
                r1h2.Visible = true;
                r1h3.Visible = true;
            }
            if (red1 == 4)
            {
                r1h1.Image = Monopoly.Properties.Resources.house;
                r1h2.Image = Monopoly.Properties.Resources.house;
                r1h3.Image = Monopoly.Properties.Resources.house;
                r1h4.Image = Monopoly.Properties.Resources.house;
                r1h1.Visible = true;
                r1h2.Visible = true;
                r1h3.Visible = true;
                r1h4.Visible = true;
            }
            if (red2 == 1)
            {
                r2h1.Image = Monopoly.Properties.Resources.house;
                r2h1.Visible = true;
            }
            if (red2 == 2)
            {
                r2h1.Image = Monopoly.Properties.Resources.house;
                r2h2.Image = Monopoly.Properties.Resources.house;
                r2h1.Visible = true;
                r2h2.Visible = true;
            }
            if (red2 == 3)
            {
                r2h1.Image = Monopoly.Properties.Resources.house;
                r2h2.Image = Monopoly.Properties.Resources.house;
                r2h3.Image = Monopoly.Properties.Resources.house;
                r2h1.Visible = true;
                r2h2.Visible = true;
                r2h3.Visible = true;
            }
            if (red2 == 4)
            {
                r2h1.Image = Monopoly.Properties.Resources.house;
                r2h2.Image = Monopoly.Properties.Resources.house;
                r2h3.Image = Monopoly.Properties.Resources.house;
                r2h4.Image = Monopoly.Properties.Resources.house;
                r2h1.Visible = true;
                r2h2.Visible = true;
                r2h3.Visible = true;
                r2h4.Visible = true;
            }
            if (red3 == 1)
            {
                r3h1.Image = Monopoly.Properties.Resources.house;
                r3h1.Visible = true;
            }
            if (red3 == 2)
            {
                r3h1.Image = Monopoly.Properties.Resources.house;
                r3h2.Image = Monopoly.Properties.Resources.house;
                r3h1.Visible = true;
                r3h2.Visible = true;
            }
            if (red3 == 3)
            {
                r3h1.Image = Monopoly.Properties.Resources.house;
                r3h2.Image = Monopoly.Properties.Resources.house;
                r3h3.Image = Monopoly.Properties.Resources.house;
                r3h1.Visible = true;
                r3h2.Visible = true;
                r3h3.Visible = true;
            }
            if (red3 == 4)
            {
                r3h1.Image = Monopoly.Properties.Resources.house;
                r3h2.Image = Monopoly.Properties.Resources.house;
                r3h3.Image = Monopoly.Properties.Resources.house;
                r3h4.Image = Monopoly.Properties.Resources.house;
                r3h1.Visible = true;
                r3h2.Visible = true;
                r3h3.Visible = true;
                r3h4.Visible = true;
            }
            //yellow
            if (yellow1 == 1)
            {
                y1h1.Image = Monopoly.Properties.Resources.house;
                y1h1.Visible = true;
            }
            if (yellow1 == 2)
            {
                y1h1.Image = Monopoly.Properties.Resources.house;
                y1h2.Image = Monopoly.Properties.Resources.house;
                y1h1.Visible = true;
                y1h2.Visible = true;
            }
            if (yellow1 == 3)
            {
                y1h1.Image = Monopoly.Properties.Resources.house;
                y1h2.Image = Monopoly.Properties.Resources.house;
                y1h3.Image = Monopoly.Properties.Resources.house;
                y1h1.Visible = true;
                y1h2.Visible = true;
                y1h3.Visible = true;
            }
            if (yellow1 == 4)
            {
                y1h1.Image = Monopoly.Properties.Resources.house;
                y1h2.Image = Monopoly.Properties.Resources.house;
                y1h3.Image = Monopoly.Properties.Resources.house;
                y1h4.Image = Monopoly.Properties.Resources.house;
                y1h1.Visible = true;
                y1h2.Visible = true;
                y1h3.Visible = true;
                y1h4.Visible = true;
            }
            if (yellow2 == 1)
            {
                y2h1.Image = Monopoly.Properties.Resources.house;
                y2h1.Visible = true;
            }
            if (yellow2 == 2)
            {
                y2h1.Image = Monopoly.Properties.Resources.house;
                y2h2.Image = Monopoly.Properties.Resources.house;
                y2h1.Visible = true;
                y2h2.Visible = true;
            }
            if (yellow2 == 3)
            {
                y2h1.Image = Monopoly.Properties.Resources.house;
                y2h2.Image = Monopoly.Properties.Resources.house;
                y2h3.Image = Monopoly.Properties.Resources.house;
                y2h1.Visible = true;
                y2h2.Visible = true;
                y2h3.Visible = true;
            }
            if (yellow2 == 4)
            {
                y2h1.Image = Monopoly.Properties.Resources.house;
                y2h2.Image = Monopoly.Properties.Resources.house;
                y2h3.Image = Monopoly.Properties.Resources.house;
                y2h4.Image = Monopoly.Properties.Resources.house;
                y2h1.Visible = true;
                y2h2.Visible = true;
                y2h3.Visible = true;
                y2h4.Visible = true;
            }
            if (yellow3 == 1)
            {
                y3h1.Image = Monopoly.Properties.Resources.house;
                y3h1.Visible = true;
            }
            if (yellow3 == 2)
            {
                y3h1.Image = Monopoly.Properties.Resources.house;
                y3h2.Image = Monopoly.Properties.Resources.house;
                y3h1.Visible = true;
                y3h2.Visible = true;
            }
            if (yellow3 == 3)
            {
                y3h1.Image = Monopoly.Properties.Resources.house;
                y3h2.Image = Monopoly.Properties.Resources.house;
                y2h3.Image = Monopoly.Properties.Resources.house;
                y3h1.Visible = true;
                y3h2.Visible = true;
                y2h3.Visible = true;
            }
            if (yellow3 == 4)
            {
                y3h1.Image = Monopoly.Properties.Resources.house;
                y3h2.Image = Monopoly.Properties.Resources.house;
                y2h3.Image = Monopoly.Properties.Resources.house;
                y3h4.Image = Monopoly.Properties.Resources.house;
                y3h1.Visible = true;
                y3h2.Visible = true;
                y2h3.Visible = true;
                y3h4.Visible = true;
            }
            //green
            if (green1 == 1)
            {
                g1h1.Image = Monopoly.Properties.Resources.house;
                g1h1.Visible = true;
            }
            if (green1 == 2)
            {
                g1h1.Image = Monopoly.Properties.Resources.house;
                g1h2.Image = Monopoly.Properties.Resources.house;
                g1h1.Visible = true;
                g1h2.Visible = true;
            }
            if (green1 == 3)
            {
                g1h1.Image = Monopoly.Properties.Resources.house;
                g1h2.Image = Monopoly.Properties.Resources.house;
                g1h3.Image = Monopoly.Properties.Resources.house;
                g1h1.Visible = true;
                g1h2.Visible = true;
                g1h3.Visible = true;
            }
            if (green1 == 4)
            {
                g1h1.Image = Monopoly.Properties.Resources.house;
                g1h2.Image = Monopoly.Properties.Resources.house;
                g1h3.Image = Monopoly.Properties.Resources.house;
                g1h4.Image = Monopoly.Properties.Resources.house;
                g1h1.Visible = true;
                g1h2.Visible = true;
                g1h3.Visible = true;
                g1h4.Visible = true;
            }
            if (green2 == 1)
            {
                g2h1.Image = Monopoly.Properties.Resources.house;
                g2h1.Visible = true;
            }
            if (green2 == 2)
            {
                g2h1.Image = Monopoly.Properties.Resources.house;
                g2h2.Image = Monopoly.Properties.Resources.house;
                g2h1.Visible = true;
                g2h2.Visible = true;
            }
            if (green2 == 3)
            {
                g2h1.Image = Monopoly.Properties.Resources.house;
                g2h2.Image = Monopoly.Properties.Resources.house;
                g2h3.Image = Monopoly.Properties.Resources.house;
                g2h1.Visible = true;
                g2h2.Visible = true;
                g2h3.Visible = true;
            }
            if (green2 == 4)
            {
                g2h1.Image = Monopoly.Properties.Resources.house;
                g2h2.Image = Monopoly.Properties.Resources.house;
                g2h3.Image = Monopoly.Properties.Resources.house;
                g2h4.Image = Monopoly.Properties.Resources.house;
                g2h1.Visible = true;
                g2h2.Visible = true;
                g2h3.Visible = true;
                g2h4.Visible = true;
            }
            if (green3 == 1)
            {
                g3h1.Image = Monopoly.Properties.Resources.house;
                g3h1.Visible = true;
            }
            if (green3 == 2)
            {
                g3h1.Image = Monopoly.Properties.Resources.house;
                g3h2.Image = Monopoly.Properties.Resources.house;
                g3h1.Visible = true;
                g3h2.Visible = true;
            }
            if (green3 == 3)
            {
                g3h1.Image = Monopoly.Properties.Resources.house;
                g3h2.Image = Monopoly.Properties.Resources.house;
                g3h3.Image = Monopoly.Properties.Resources.house;
                g3h1.Visible = true;
                g3h2.Visible = true;
                g3h3.Visible = true;
            }
            if (green3 == 4)
            {
                g3h1.Image = Monopoly.Properties.Resources.house;
                g3h2.Image = Monopoly.Properties.Resources.house;
                g3h3.Image = Monopoly.Properties.Resources.house;
                g3h4.Image = Monopoly.Properties.Resources.house;
                g3h1.Visible = true;
                g3h2.Visible = true;
                g3h3.Visible = true;
                g3h4.Visible = true;
            }
            //darkblue
            if (darkblue1 == 1)
            {
                db1h1.Image = Monopoly.Properties.Resources.house;
                db1h1.Visible = true;
            }
            if (darkblue1 == 2)
            {
                db1h1.Image = Monopoly.Properties.Resources.house;
                db1h2.Image = Monopoly.Properties.Resources.house;
                db1h1.Visible = true;
                db1h2.Visible = true;
            }
            if (darkblue1 == 3)
            {
                db1h1.Image = Monopoly.Properties.Resources.house;
                db1h2.Image = Monopoly.Properties.Resources.house;
                db1h3.Image = Monopoly.Properties.Resources.house;
                db1h1.Visible = true;
                db1h2.Visible = true;
                db1h3.Visible = true;
            }
            if (darkblue1 == 4)
            {
                db1h1.Image = Monopoly.Properties.Resources.house;
                db1h2.Image = Monopoly.Properties.Resources.house;
                db1h3.Image = Monopoly.Properties.Resources.house;
                db1h4.Image = Monopoly.Properties.Resources.house;
                db1h1.Visible = true;
                db1h2.Visible = true;
                db1h3.Visible = true;
                db1h4.Visible = true;
            }
            if (darkblue2 == 1)
            {
                db2h1.Image = Monopoly.Properties.Resources.house;
                db2h1.Visible = true;
            }
            if (darkblue2 == 2)
            {
                db2h1.Image = Monopoly.Properties.Resources.house;
                db2h2.Image = Monopoly.Properties.Resources.house;
                db2h1.Visible = true;
                db2h2.Visible = true;
            }
            if (darkblue2 == 3)
            {
                db2h1.Image = Monopoly.Properties.Resources.house;
                db2h2.Image = Monopoly.Properties.Resources.house;
                db2h3.Image = Monopoly.Properties.Resources.house;
                db2h1.Visible = true;
                db2h2.Visible = true;
                db2h3.Visible = true;
            }
            if (darkblue2 == 4)
            {
                db2h1.Image = Monopoly.Properties.Resources.house;
                db2h2.Image = Monopoly.Properties.Resources.house;
                db2h3.Image = Monopoly.Properties.Resources.house;
                db2h4.Image = Monopoly.Properties.Resources.house;
                db2h1.Visible = true;
                db2h2.Visible = true;
                db2h3.Visible = true;
                db2h4.Visible = true;
            }
        }

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

        private void rollBtn_Click(object sender, EventArgs e)
        {
            game();
        }
        public void game()
        {
            if (chancepic.Visible == true)
            {
                chancepic.Visible = false;
            }
            do
            {
                Random roller = new Random();
                int roll1, roll2;

                int player = turnNum;
                doubles = false;
                roll1 = roller.Next(1, 7);
                roll2 = roller.Next(1, 7);
                derp = roll1 + roll2;
                switch (roll1)
                {
                    case 1:
                        die1.Image = Monopoly.Properties.Resources.dice1;
                        break;
                    case 2:
                        die1.Image = Monopoly.Properties.Resources.dice2;
                        break;
                    case 3:
                        die1.Image = Monopoly.Properties.Resources.dice3;
                        break;
                    case 4:
                        die1.Image = Monopoly.Properties.Resources.dice4;
                        break;
                    case 5:
                        die1.Image = Monopoly.Properties.Resources.dice5;
                        break;
                    case 6:
                        die1.Image = Monopoly.Properties.Resources.dice6;
                        break;
                }
                switch (roll2)
                {
                    case 1:
                        die2.Image = Monopoly.Properties.Resources.dice1;
                        break;
                    case 2:
                        die2.Image = Monopoly.Properties.Resources.dice2;
                        break;
                    case 3:
                        die2.Image = Monopoly.Properties.Resources.dice3;
                        break;
                    case 4:
                        die2.Image = Monopoly.Properties.Resources.dice4;
                        break;
                    case 5:
                        die2.Image = Monopoly.Properties.Resources.dice5;
                        break;
                    case 6:
                        die2.Image = Monopoly.Properties.Resources.dice6;
                        break;
                }
                if (roll1 == roll2)
                {
                    doubles = true;
                    jailRoll++;

                    if (jailRoll == 3)
                    {
                        total.Text = "Jail";
                        jailRoll = 0;
                    }
                }

                if (turnNum == 5)
                {
                    turnNum = 1;
                }
                switch (turnNum)
                {
                    case 1:
                        player1Pos += derp;
                        if (player1Pos > 40)
                        {
                            int temp;
                            temp = player1Pos - 40;
                            player1Pos = temp;
                            player1Mon += 200;
                        }
                        landed(player1Pos);
                        switch (player1Pos)
                        {
                            case 1:
                                Point tile1 = new Point(578, 585);
                                player1.Location = tile1;
                                break;
                            case 2:
                                Point tile2 = new Point(505, 585);
                                player1.Location = tile2;
                                break;
                            case 3:
                                Point tile3 = new Point(452, 585);
                                player1.Location = tile3;
                                break;
                            case 4:
                                Point tile4 = new Point(403, 585);
                                player1.Location = tile4;
                                break;
                            case 5:
                                Point tile5 = new Point(350, 585);
                                player1.Location = tile5;
                                break;
                            case 6:
                                Point tile6 = new Point(297, 585);
                                player1.Location = tile6;
                                break;
                            case 7:
                                Point tile7 = new Point(244, 585);
                                player1.Location = tile7;
                                break;
                            case 8:
                                Point tile8 = new Point(191, 585);
                                player1.Location = tile8;
                                break;
                            case 9:
                                Point tile9 = new Point(138, 585);
                                player1.Location = tile9;
                                break;
                            case 10:
                                Point tile10 = new Point(85, 585);
                                player1.Location = tile10;
                                break;
                            case 11:
                                Point tile11 = new Point(31, 585);
                                player1.Location = tile11;
                                break;
                            case 12:
                                Point tile12 = new Point(31, 520);
                                player1.Location = tile12;
                                break;
                            case 13:
                                Point tile13 = new Point(31, 464);
                                player1.Location = tile13;
                                break;
                            case 14:
                                Point tile14 = new Point(31, 408);
                                player1.Location = tile14;
                                break;
                            case 15:
                                Point tile15 = new Point(31, 352);
                                player1.Location = tile15;
                                break;
                            case 16:
                                Point tile16 = new Point(12, 304);
                                player1.Location = tile16;
                                break;
                            case 17:
                                Point tile17 = new Point(12, 256);
                                player1.Location = tile17;
                                break;
                            case 18:
                                Point tile18 = new Point(12, 204);
                                player1.Location = tile18;
                                break;
                            case 19:
                                Point tile19 = new Point(12, 151);
                                player1.Location = tile19;
                                break;
                            case 20:
                                Point tile20 = new Point(12, 95);
                                player1.Location = tile20;
                                break;
                            case 21:
                                Point tile21 = new Point(31, 21);
                                player1.Location = tile21;
                                break;
                            case 22:
                                Point tile22 = new Point(85, 12);
                                player1.Location = tile22;
                                break;
                            case 23:
                                Point tile23 = new Point(138, 12);
                                player1.Location = tile23;
                                break;
                            case 24:
                                Point tile24 = new Point(189, 12);
                                player1.Location = tile24;
                                break;
                            case 25:
                                Point tile25 = new Point(243, 12);
                                player1.Location = tile25;
                                break;
                            case 26:
                                Point tile26 = new Point(296, 12);
                                player1.Location = tile26;
                                break;
                            case 27:
                                Point tile27 = new Point(349, 12);
                                player1.Location = tile27;
                                break;
                            case 28:
                                Point tile28 = new Point(403, 12);
                                player1.Location = tile28;
                                break;
                            case 29:
                                Point tile29 = new Point(456, 12);
                                player1.Location = tile29;
                                break;
                            case 30:
                                Point tile30 = new Point(507, 12);
                                player1.Location = tile30;
                                break;
                            case 31:
                                Point tile31 = new Point(578, 12);
                                player1.Location = tile31;
                                break;
                            case 32:
                                Point tile32 = new Point(578, 89);
                                player1.Location = tile32;
                                break;
                            case 33:
                                Point tile33 = new Point(578, 142);
                                player1.Location = tile33;
                                break;
                            case 34:
                                Point tile34 = new Point(578, 195);
                                player1.Location = tile34;
                                break;
                            case 35:
                                Point tile35 = new Point(578, 248);
                                player1.Location = tile35;
                                break;
                            case 36:
                                Point tile36 = new Point(578, 304);
                                player1.Location = tile36;
                                break;
                            case 37:
                                Point tile37 = new Point(578, 351);
                                player1.Location = tile37;
                                break;
                            case 38:
                                Point tile38 = new Point(578, 408);
                                player1.Location = tile38;
                                break;
                            case 39:
                                Point tile39 = new Point(578, 459);
                                player1.Location = tile39;
                                break;
                            case 40:
                                Point tile40 = new Point(578, 511);
                                player1.Location = tile40;
                                break;

                        }
                        break;
                    case 2:
                        player2Pos += derp;
                        if (player2Pos > 40)
                        {
                            int temp;
                            temp = player2Pos - 40;
                            player2Pos = temp;
                            player2Mon += 200;
                        }
                        landed(player2Pos);
                        switch (player2Pos)
                        {
                            case 1:
                                Point tile1 = new Point(578, 585);
                                player2.Location = tile1;
                                break;
                            case 2:
                                Point tile2 = new Point(505, 585);
                                player2.Location = tile2;
                                break;
                            case 3:
                                Point tile3 = new Point(452, 585);
                                player2.Location = tile3;
                                break;
                            case 4:
                                Point tile4 = new Point(403, 585);
                                player2.Location = tile4;
                                break;
                            case 5:
                                Point tile5 = new Point(350, 585);
                                player2.Location = tile5;
                                break;
                            case 6:
                                Point tile6 = new Point(297, 585);
                                player2.Location = tile6;
                                break;
                            case 7:
                                Point tile7 = new Point(244, 585);
                                player2.Location = tile7;
                                break;
                            case 8:
                                Point tile8 = new Point(191, 585);
                                player2.Location = tile8;
                                break;
                            case 9:
                                Point tile9 = new Point(138, 585);
                                player2.Location = tile9;
                                break;
                            case 10:
                                Point tile10 = new Point(85, 585);
                                player2.Location = tile10;
                                break;
                            case 11:
                                Point tile11 = new Point(31, 585);
                                player2.Location = tile11;
                                break;
                            case 12:
                                Point tile12 = new Point(31, 520);
                                player2.Location = tile12;
                                break;
                            case 13:
                                Point tile13 = new Point(31, 464);
                                player2.Location = tile13;
                                break;
                            case 14:
                                Point tile14 = new Point(31, 408);
                                player2.Location = tile14;
                                break;
                            case 15:
                                Point tile15 = new Point(31, 352);
                                player2.Location = tile15;
                                break;
                            case 16:
                                Point tile16 = new Point(31, 296);
                                player2.Location = tile16;
                                break;
                            case 17:
                                Point tile17 = new Point(12, 257);
                                player2.Location = tile17;
                                break;
                            case 18:
                                Point tile18 = new Point(12, 204);
                                player2.Location = tile18;
                                break;
                            case 19:
                                Point tile19 = new Point(12, 145);
                                player2.Location = tile19;
                                break;
                            case 20:
                                Point tile20 = new Point(12, 95);
                                player2.Location = tile20;
                                break;
                            case 21:
                                Point tile21 = new Point(31, 21);
                                player2.Location = tile21;
                                break;
                            case 22:
                                Point tile22 = new Point(85, 12);
                                player2.Location = tile22;
                                break;
                            case 23:
                                Point tile23 = new Point(138, 12);
                                player2.Location = tile23;
                                break;
                            case 24:
                                Point tile24 = new Point(189, 12);
                                player2.Location = tile24;
                                break;
                            case 25:
                                Point tile25 = new Point(243, 12);
                                player2.Location = tile25;
                                break;
                            case 26:
                                Point tile26 = new Point(296, 12);
                                player2.Location = tile26;
                                break;
                            case 27:
                                Point tile27 = new Point(349, 12);
                                player2.Location = tile27;
                                break;
                            case 28:
                                Point tile28 = new Point(403, 12);
                                player2.Location = tile28;
                                break;
                            case 29:
                                Point tile29 = new Point(456, 12);
                                player2.Location = tile29;
                                break;
                            case 30:
                                Point tile30 = new Point(507, 12);
                                player2.Location = tile30;
                                break;
                            case 31:
                                Point tile31 = new Point(578, 12);
                                player2.Location = tile31;
                                break;
                            case 32:
                                Point tile32 = new Point(578, 89);
                                player2.Location = tile32;
                                break;
                            case 33:
                                Point tile33 = new Point(578, 142);
                                player2.Location = tile33;
                                break;
                            case 34:
                                Point tile34 = new Point(578, 195);
                                player2.Location = tile34;
                                break;
                            case 35:
                                Point tile35 = new Point(578, 248);
                                player2.Location = tile35;
                                break;
                            case 36:
                                Point tile36 = new Point(578, 304);
                                player2.Location = tile36;
                                break;
                            case 37:
                                Point tile37 = new Point(578, 351);
                                player2.Location = tile37;
                                break;
                            case 38:
                                Point tile38 = new Point(578, 408);
                                player2.Location = tile38;
                                break;
                            case 39:
                                Point tile39 = new Point(578, 459);
                                player2.Location = tile39;
                                break;
                            case 40:
                                Point tile40 = new Point(578, 511);
                                player2.Location = tile40;
                                break;

                        }
                        break;
                    case 3:
                        player3Pos += derp;
                        if (player3Pos > 40)
                        {
                            int temp;
                            temp = player3Pos - 40;
                            player3Pos = temp;
                            player3Mon += 200;
                        }
                        landed(player3Pos);
                        switch (player3Pos)
                        {
                            case 1:
                                Point tile1 = new Point(578, 585);
                                player3.Location = tile1;
                                break;
                            case 2:
                                Point tile2 = new Point(505, 585);
                                player3.Location = tile2;
                                break;
                            case 3:
                                Point tile3 = new Point(452, 585);
                                player3.Location = tile3;
                                break;
                            case 4:
                                Point tile4 = new Point(403, 585);
                                player3.Location = tile4;
                                break;
                            case 5:
                                Point tile5 = new Point(350, 585);
                                player3.Location = tile5;
                                break;
                            case 6:
                                Point tile6 = new Point(297, 585);
                                player3.Location = tile6;
                                break;
                            case 7:
                                Point tile7 = new Point(244, 585);
                                player3.Location = tile7;
                                break;
                            case 8:
                                Point tile8 = new Point(191, 585);
                                player3.Location = tile8;
                                break;
                            case 9:
                                Point tile9 = new Point(138, 585);
                                player3.Location = tile9;
                                break;
                            case 10:
                                Point tile10 = new Point(85, 585);
                                player3.Location = tile10;
                                break;
                            case 11:
                                Point tile11 = new Point(31, 585);
                                player3.Location = tile11;
                                break;
                            case 12:
                                Point tile12 = new Point(31, 520);
                                player3.Location = tile12;
                                break;
                            case 13:
                                Point tile13 = new Point(31, 464);
                                player3.Location = tile13;
                                break;
                            case 14:
                                Point tile14 = new Point(31, 408);
                                player3.Location = tile14;
                                break;
                            case 15:
                                Point tile15 = new Point(31, 352);
                                player3.Location = tile15;
                                break;
                            case 16:
                                Point tile16 = new Point(31, 296);
                                player3.Location = tile16;
                                break;
                            case 17:
                                Point tile17 = new Point(12, 257);
                                player3.Location = tile17;
                                break;
                            case 18:
                                Point tile18 = new Point(12, 204);
                                player3.Location = tile18;
                                break;
                            case 19:
                                Point tile19 = new Point(12, 145);
                                player3.Location = tile19;
                                break;
                            case 20:
                                Point tile20 = new Point(12, 95);
                                player3.Location = tile20;
                                break;
                            case 21:
                                Point tile21 = new Point(31, 21);
                                player3.Location = tile21;
                                break;
                            case 22:
                                Point tile22 = new Point(85, 12);
                                player3.Location = tile22;
                                break;
                            case 23:
                                Point tile23 = new Point(138, 12);
                                player3.Location = tile23;
                                break;
                            case 24:
                                Point tile24 = new Point(189, 12);
                                player3.Location = tile24;
                                break;
                            case 25:
                                Point tile25 = new Point(243, 12);
                                player3.Location = tile25;
                                break;
                            case 26:
                                Point tile26 = new Point(296, 12);
                                player3.Location = tile26;
                                break;
                            case 27:
                                Point tile27 = new Point(349, 12);
                                player3.Location = tile27;
                                break;
                            case 28:
                                Point tile28 = new Point(403, 12);
                                player3.Location = tile28;
                                break;
                            case 29:
                                Point tile29 = new Point(456, 12);
                                player3.Location = tile29;
                                break;
                            case 30:
                                Point tile30 = new Point(507, 12);
                                player3.Location = tile30;
                                break;
                            case 31:
                                Point tile31 = new Point(578, 12);
                                player3.Location = tile31;
                                break;
                            case 32:
                                Point tile32 = new Point(578, 89);
                                player3.Location = tile32;
                                break;
                            case 33:
                                Point tile33 = new Point(578, 142);
                                player3.Location = tile33;
                                break;
                            case 34:
                                Point tile34 = new Point(578, 195);
                                player3.Location = tile34;
                                break;
                            case 35:
                                Point tile35 = new Point(578, 248);
                                player3.Location = tile35;
                                break;
                            case 36:
                                Point tile36 = new Point(578, 304);
                                player3.Location = tile36;
                                break;
                            case 37:
                                Point tile37 = new Point(578, 351);
                                player3.Location = tile37;
                                break;
                            case 38:
                                Point tile38 = new Point(578, 408);
                                player3.Location = tile38;
                                break;
                            case 39:
                                Point tile39 = new Point(578, 459);
                                player3.Location = tile39;
                                break;
                            case 40:
                                Point tile40 = new Point(578, 511);
                                player3.Location = tile40;
                                break;

                        }
                        break;
                    case 4:
                        player4Pos += derp;
                        if (player4Pos > 40)
                        {
                            int temp;
                            temp = player4Pos - 40;
                            player4Pos = temp;
                            player4Mon += 200;
                        }
                        landed(player4Pos);
                        switch (player4Pos)
                        {
                            case 1:
                                Point tile1 = new Point(578, 585);
                                player4.Location = tile1;
                                break;
                            case 2:
                                Point tile2 = new Point(505, 585);
                                player4.Location = tile2;
                                break;
                            case 3:
                                Point tile3 = new Point(452, 585);
                                player4.Location = tile3;
                                break;
                            case 4:
                                Point tile4 = new Point(403, 585);
                                player4.Location = tile4;
                                break;
                            case 5:
                                Point tile5 = new Point(350, 585);
                                player4.Location = tile5;
                                break;
                            case 6:
                                Point tile6 = new Point(297, 585);
                                player4.Location = tile6;
                                break;
                            case 7:
                                Point tile7 = new Point(244, 585);
                                player4.Location = tile7;
                                break;
                            case 8:
                                Point tile8 = new Point(191, 585);
                                player4.Location = tile8;
                                break;
                            case 9:
                                Point tile9 = new Point(138, 585);
                                player4.Location = tile9;
                                break;
                            case 10:
                                Point tile10 = new Point(85, 585);
                                player4.Location = tile10;
                                break;
                            case 11:
                                Point tile11 = new Point(31, 585);
                                player4.Location = tile11;
                                break;
                            case 12:
                                Point tile12 = new Point(31, 520);
                                player4.Location = tile12;
                                break;
                            case 13:
                                Point tile13 = new Point(31, 464);
                                player4.Location = tile13;
                                break;
                            case 14:
                                Point tile14 = new Point(31, 408);
                                player4.Location = tile14;
                                break;
                            case 15:
                                Point tile15 = new Point(31, 352);
                                player4.Location = tile15;
                                break;
                            case 16:
                                Point tile16 = new Point(31, 296);
                                player4.Location = tile16;
                                break;
                            case 17:
                                Point tile17 = new Point(12, 257);
                                player4.Location = tile17;
                                break;
                            case 18:
                                Point tile18 = new Point(12, 204);
                                player4.Location = tile18;
                                break;
                            case 19:
                                Point tile19 = new Point(12, 145);
                                player4.Location = tile19;
                                break;
                            case 20:
                                Point tile20 = new Point(12, 95);
                                player4.Location = tile20;
                                break;
                            case 21:
                                Point tile21 = new Point(31, 21);//free parking
                                player4.Location = tile21;
                                break;
                            case 22:
                                Point tile22 = new Point(85, 12);
                                player4.Location = tile22;
                                break;
                            case 23:
                                Point tile23 = new Point(138, 12);
                                player4.Location = tile23;
                                break;
                            case 24:
                                Point tile24 = new Point(189, 12);
                                player4.Location = tile24;
                                break;
                            case 25:
                                Point tile25 = new Point(243, 12);
                                player4.Location = tile25;
                                break;
                            case 26:
                                Point tile26 = new Point(296, 12);
                                player4.Location = tile26;
                                break;
                            case 27:
                                Point tile27 = new Point(349, 12);
                                player4.Location = tile27;
                                break;
                            case 28:
                                Point tile28 = new Point(403, 12);
                                player4.Location = tile28;
                                break;
                            case 29:
                                Point tile29 = new Point(456, 12);
                                player4.Location = tile29;
                                break;
                            case 30:
                                Point tile30 = new Point(507, 12);
                                player4.Location = tile30;
                                break;
                            case 31:
                                Point tile31 = new Point(578, 12);
                                player4.Location = tile31;
                                break;
                            case 32:
                                Point tile32 = new Point(578, 89);
                                player4.Location = tile32;
                                break;
                            case 33:
                                Point tile33 = new Point(578, 142);
                                player4.Location = tile33;
                                break;
                            case 34:
                                Point tile34 = new Point(578, 195);
                                player4.Location = tile34;
                                break;
                            case 35:
                                Point tile35 = new Point(578, 248);
                                player4.Location = tile35;
                                break;
                            case 36:
                                Point tile36 = new Point(578, 304);
                                player4.Location = tile36;
                                break;
                            case 37:
                                Point tile37 = new Point(578, 351);
                                player4.Location = tile37;
                                break;
                            case 38:
                                Point tile38 = new Point(578, 408);
                                player4.Location = tile38;
                                break;
                            case 39:
                                Point tile39 = new Point(578, 459);
                                player4.Location = tile39;
                                break;
                            case 40:
                                Point tile40 = new Point(578, 511);
                                player4.Location = tile40;
                                break;

                        }
                        break;
                }
                switch (roll1)
                {
                    case 1:
                        die1.Image = Monopoly.Properties.Resources.dice1;
                        break;
                    case 2:
                        die1.Image = Monopoly.Properties.Resources.dice2;
                        break;
                    case 3:
                        die1.Image = Monopoly.Properties.Resources.dice3;
                        break;
                    case 4:
                        die1.Image = Monopoly.Properties.Resources.dice4;
                        break;
                    case 5:
                        die1.Image = Monopoly.Properties.Resources.dice5;
                        break;
                    case 6:
                        die1.Image = Monopoly.Properties.Resources.dice6;
                        break;
                }
                switch (roll2)
                {
                    case 1:
                        die2.Image = Monopoly.Properties.Resources.dice1;
                        break;
                    case 2:
                        die2.Image = Monopoly.Properties.Resources.dice2;
                        break;
                    case 3:
                        die2.Image = Monopoly.Properties.Resources.dice3;
                        break;
                    case 4:
                        die2.Image = Monopoly.Properties.Resources.dice4;
                        break;
                    case 5:
                        die2.Image = Monopoly.Properties.Resources.dice5;
                        break;
                    case 6:
                        die2.Image = Monopoly.Properties.Resources.dice6;
                        break;
                }

                turn.Text = "Player " + turnNum + "'s";
                total.Text = derp.ToString();
                if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                {
                    turnNum++;
                    totalTurns++;
                }
            } while ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4));
        }
        public void landed(int player)
        {
            Random chance = new Random();
            string owned = "false";
            switch (player)
            {
                case 1:
                    owned = "unownable";
                    break;
                case 2:
                    if (prop2Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.brown1;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 60;
                        selectedProp = player;
                    }
                    else
                    {
                        rent = 2;
                        owned = "true";
                    }
                    break;
                case 3:
                    chancepic.Visible = true;
                    cc = chance.Next(1, 15);
                    ccswitch();
                    owned = "unownable";
                    break;
                case 4:
                    if (prop4Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.brown2;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 60;
                        selectedProp = player;
                    }
                    else
                    {
                        rent = 4;
                        owned = "true";
                    }
                    break;
                case 5:
                    owned = "unownable";
                    break;
                case 6:
                    if (prop6Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.rr1;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 200;
                        selectedProp = player;
                    }else{
                        rent = 25;
                    owned = "true";}
                    break;
                case 7:
                    if (prop7Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.lightblue1;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 100;
                        selectedProp = player;
                    }else{
                        rent = 6;
                    owned = "true";}
                    break;
                case 8:
                    chancepic.Visible = true;
                    cc = chance.Next(1, 15);
                    ccswitch();
                    owned = "unownable";
                    break;
                case 9:
                    if (prop9Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.lightblue2;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 100;
                        selectedProp = player;
                    }else{
                        rent = 6;
                    owned = "true";}
                    break;
                case 10:
                    if (prop10Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.lightblue3;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 120;
                        selectedProp = player;
                    }else{
                        rent = 8;
                    owned = "true";}
                    break;
                case 11:
                    owned = "unownable";
                    break;
                case 12:
                    if (prop12Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.pink1;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 140;
                        selectedProp = player;
                    }else{
                        rent = 10;
                    owned = "true";}
                    break;
                case 13:
                    if (prop13Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.utility1;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 150;
                        selectedProp = player;
                    }else{
                        rent = derp*4;
                    owned = "true";}
                    break;
                case 14:
                    if (prop14Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.pink2;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 140;
                        selectedProp = player;
                    }else{
                        rent = 10;
                    owned = "true";}
                    break;
                case 15:
                    if (prop15Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.pink3;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 160;
                        selectedProp = player;
                    }else{
                        rent = 12;
                    owned = "true";}
                    break;
                case 16:
                    if (prop16Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.rr2;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 200;
                        selectedProp = player;
                    }else{
                        rent = 25;
                    owned = "true";}
                    break;
                case 17:
                    if (prop17Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.orange1;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 180;
                        selectedProp = player;
                    }else{
                        rent = 14;
                    owned = "true";}
                    break;
                case 18:
                    chancepic.Visible = true;
                    cc = chance.Next(1, 15);
                    ccswitch();
                    owned = "unownable";
                    break;
                case 19:
                    if (prop19Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.orange2;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 180;
                        selectedProp = player;
                    }else{
                        rent = 14;
                    owned = "true";}
                    break;
                case 20:
                    if (prop20Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.orange3;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 200;
                        selectedProp = player;
                    }else{
                        rent = 16;
                    owned = "true";}
                    break;
                case 21:
                    owned = "unownable";
                    break;
                case 22:
                    if (prop22Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.red1;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 220;
                        selectedProp = player;
                    }else{
                        rent = 18;
                    owned = "true";}
                    break;
                case 23:
                    chancepic.Visible = true;
                    cc = chance.Next(1, 15);
                    ccswitch();
                    owned = "unownable";
                    break;
                case 24:
                    if (prop24Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.red2;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 220;
                        selectedProp = player;
                    }else{
                        rent = 18;
                    owned = "true";}
                    break;
                case 25:
                    if (prop25Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.red3;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 240;
                        selectedProp = player;
                    }else{
                        rent = 20;
                    owned = "true";}
                    break;
                case 26:
                    if (prop26Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.rr3;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 200;
                        selectedProp = player;
                    }else{
                        rent = 25;
                    owned = "true";}
                    break;
                case 27:
                    if (prop27Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.yellow1;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 260;
                        selectedProp = player;
                    }else{
                        rent = 22;
                    owned = "true";}
                    break;
                case 28:
                    if (prop28Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.yellow2;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 260;
                        selectedProp = player;
                    }else{
                        rent = 22;
                    owned = "true";}
                    break;
                case 29:
                    if (prop29Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.utility2;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 150;
                        selectedProp = player;
                    }else{
                        rent = 4 * derp;
                    owned = "true";}
                    break;
                case 30:
                    if (prop30Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.yellow3;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 280;
                        selectedProp = player;
                    }else{
                        rent = 24;
                    owned = "true";}
                    break;
                case 31:
                    owned = "unownable";
                    break;
                case 32:
                    if (prop32Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.green1;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 300;
                        selectedProp = player;
                    }else{
                        rent = 26;
                    owned = "true";}
                    break;
                case 33:
                    if (prop33Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.green2;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 300;
                        selectedProp = player;
                    }else{
                        rent = 26;
                    owned = "true";}
                    break;
                case 34:
                    chancepic.Visible = true;
                    cc = chance.Next(1, 15);
                    ccswitch();
                    owned = "unownable";
                    break;
                case 35:
                    if (prop35Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.green3;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 320;
                        selectedProp = player;
                    }else{
                        rent = 28;
                    owned = "true";}
                    break;
                case 36:
                    if (prop36Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.rr4;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 200;
                        selectedProp = player;
                    }else{
                        rent = 25;
                    owned = "true";}
                    break;
                case 37:
                    chancepic.Visible = true;
                    cc = chance.Next(1, 15);
                    ccswitch();
                    owned = "unownable";
                    break;
                case 38:
                    if (prop38Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.darkblue1;
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 350;
                        selectedProp = player;
                    }else{
                        rent = 35;
                    owned = "true";}
                    break;
                case 39:
                    owned = "unownable";
                    break;
                case 40:
                    if (prop40Owned == false)
                    {
                        propBigBox.Image = Monopoly.Properties.Resources.darkblue2;
                        
                        if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                        {
                            Buy();
                        }
                        else
                        {
                            buy.Visible = true;
                        }
                        nope.Visible = true;
                        rollBtn.Visible = false;
                        cost = 400;
                        selectedProp = player;
                    }else{
                        rent = 50;
                    owned = "true";}
                    break;
                default:
                    
                    break;
                
            }
            if (owned == "true")
            {
                if (player1Props.Contains(player) && turnNum != 1)
                {
                    switch (turnNum)
                    {
                        case 1:
                            player1Mon -= rent;
                            if (player1Mon < 0)
                            {
                                player1.BackgroundImage = Monopoly.Properties.Resources.redowned;
                                MessageBox.Show("Player 2 has no money!");
                            }
                            else
                            {
                                player1.BackgroundImage = Monopoly.Properties.Resources.redowned;
                                player1Mon += rent;
                            }
                            break;
                            
                        case 2:
                            player2Mon -= rent;
                            if (player2Mon < 0)
                            {
                                player2.BackgroundImage = Monopoly.Properties.Resources.redowned;
                                MessageBox.Show("Player 2 has no money!");
                            }
                            else
                            {
                                player2.BackgroundImage = Monopoly.Properties.Resources.redowned;
                                player1Mon += rent;
                                payTo.Text = "Player 2 Payed "+rent+" to Player 1";
                            }
                            break;
                        case 3:
                            player3Mon -= rent;
                            if (player3Mon < 0)
                            {
                                player3.BackgroundImage = Monopoly.Properties.Resources.redowned;
                                MessageBox.Show("Player 2 has no money!");
                            }
                            else
                            {
                                player3.BackgroundImage = Monopoly.Properties.Resources.redowned;
                                player1Mon += rent;
                                payTo.Text = "Player 3 Payed " + rent + " to Player 1";
                            }
                            break;
                        case 4:
                            player4Mon -= rent;
                            if (player4Mon < 0)
                            {
                                player4.BackgroundImage = Monopoly.Properties.Resources.redowned;
                                MessageBox.Show("Player 2 has no money!");
                            }
                            else
                            {
                                player4.BackgroundImage = Monopoly.Properties.Resources.redowned;
                                player1Mon += rent;
                                payTo.Text = "Player 4 Payed " + rent + " to Player 1";
                            }
                            break;
                    }
                }
                if (player2Props.Contains(player) && turnNum != 2)
                {
                    switch (turnNum)
                    {
                        case 1:
                            player1Mon -= rent;
                            if (player1Mon < 0)
                            {
                                player1.BackgroundImage = Monopoly.Properties.Resources.pinkowned;
                                MessageBox.Show("Player 2 has no money!");
                            }
                            else
                            {
                                player1.BackgroundImage = Monopoly.Properties.Resources.pinkowned;
                                player2Mon += rent;
                                payTo.Text = "Player 1 Payed " + rent + " to Player 2";
                            }
                            break;

                        case 2:
                            player2Mon -= rent;
                            if (player2Mon < 0)
                            {
                                player2.BackgroundImage = Monopoly.Properties.Resources.pinkowned;
                                MessageBox.Show("Player 2 has no money!");
                            }
                            else
                            {
                                player2.BackgroundImage = Monopoly.Properties.Resources.pinkowned;
                                player2Mon += rent;
                                //payTo.Text = "Player  Payed " + rent + " to Player 2";
                            }
                            break;
                        case 3:
                            player3Mon -= rent;
                            if (player3Mon < 0)
                            {
                                player3.BackgroundImage = Monopoly.Properties.Resources.pinkowned;
                                MessageBox.Show("Player 2 has no money!");
                            }
                            else
                            {
                                player3.BackgroundImage = Monopoly.Properties.Resources.pinkowned;
                                player2Mon += rent;
                                payTo.Text = "Player 3 Payed " + rent + " to Player 2";
                            }
                            break;
                        case 4:
                            player4Mon -= rent;
                            if (player4Mon < 0)
                            {
                                player4.BackgroundImage = Monopoly.Properties.Resources.pinkowned;
                                MessageBox.Show("Player 2 has no money!");
                            }
                            else
                            {
                                player4.BackgroundImage = Monopoly.Properties.Resources.pinkowned;
                                player2Mon += rent;
                                payTo.Text = "Player 4 Payed " + rent + " to Player 2";
                            }
                            break;
                    }
                }
                if (player3Props.Contains(player) && turnNum != 3)
                {
                    switch (turnNum)
                    {
                        case 1:
                            player1Mon -= rent;
                            if (player1Mon < 0)
                            {
                                player1.BackgroundImage = Monopoly.Properties.Resources.blueowned;
                                MessageBox.Show("Player 2 has no money!");
                            }
                            else
                            {
                                player1.BackgroundImage = Monopoly.Properties.Resources.blueowned;
                                player3Mon += rent;
                                payTo.Text = "Player 1 Payed " + rent + " to Player 3";
                            }
                            break;

                        case 2:
                            player2Mon -= rent;
                            if (player2Mon < 0)
                            {
                                player2.BackgroundImage = Monopoly.Properties.Resources.blueowned;
                                MessageBox.Show("Player 2 has no money!");
                            }
                            else
                            {
                                player2.BackgroundImage = Monopoly.Properties.Resources.blueowned;
                                player3Mon += rent;
                                payTo.Text = "Player 2 Payed " + rent + " to Player 3";
                            }
                            break;
                        case 3:
                            player3Mon -= rent;
                            if (player3Mon < 0)
                            {
                                player3.BackgroundImage = Monopoly.Properties.Resources.blueowned;
                                MessageBox.Show("Player 2 has no money!");
                            }
                            else
                            {
                                player3.BackgroundImage = Monopoly.Properties.Resources.blueowned;
                                player3Mon += rent;
                            }
                            break;
                        case 4:
                            player4Mon -= rent;
                            if (player4Mon < 0)
                            {
                                player4.BackgroundImage = Monopoly.Properties.Resources.blueowned;
                                MessageBox.Show("Player 2 has no money!");
                            }
                            else
                            {
                                player4.BackgroundImage = Monopoly.Properties.Resources.blueowned;
                                player3Mon += rent;
                                payTo.Text = "Player 4 Payed " + rent + " to Player 3";
                            }
                            break;
                    }
                }
                if (player4Props.Contains(player) && turnNum != 4)
                {
                    switch (turnNum)
                    {
                        case 1:
                            player1Mon -= rent;
                            if (player1Mon < 0)
                            {
                                player1.BackgroundImage = Monopoly.Properties.Resources.greenowned;
                                MessageBox.Show("Player 2 has no money!");
                            }
                            else
                            {
                                player1.BackgroundImage = Monopoly.Properties.Resources.greenowned;
                                player4Mon += rent;
                                payTo.Text = "Player 1 Payed " + rent + " to Player 4";
                            }
                            break;

                        case 2:
                            player2Mon -= rent;
                            if (player2Mon < 0)
                            {
                                player2.BackgroundImage = Monopoly.Properties.Resources.greenowned;
                                MessageBox.Show("Player 2 has no money!");
                            }
                            else
                            {
                                player2.BackgroundImage = Monopoly.Properties.Resources.greenowned;
                                player4Mon += rent;
                                payTo.Text = "Player 2 Payed " + rent + " to Player 4";
                            }
                            break;
                        case 3:
                            player3Mon -= rent;
                            if (player3Mon < 0)
                            {
                                player3.BackgroundImage = Monopoly.Properties.Resources.greenowned;
                                MessageBox.Show("Player 2 has no money!");
                            }
                            else
                            {
                                player3.BackgroundImage = Monopoly.Properties.Resources.greenowned;
                                player3Mon += rent;
                                payTo.Text = "Player 3 Payed " + rent + " to Player 4";
                            }
                            break;
                        case 4:
                            player4Mon -= rent;
                            if (player4Mon < 0)
                            {
                                player4.BackgroundImage = Monopoly.Properties.Resources.greenowned;
                                MessageBox.Show("Player 2 has no money!");
                            }
                            else
                            {
                                player4.BackgroundImage = Monopoly.Properties.Resources.greenowned;
                                player1Mon += rent;
                            }
                            break;
                        default:
                            break;
                    }
                    
                }
            }
            else if (owned == "false" || owned == "unownable")
            {
                switch (turnNum)
                {
                    case 1:
                        player1.BackgroundImage = Monopoly.Properties.Resources.none;
                        break;
                    case 2:
                        player2.BackgroundImage = Monopoly.Properties.Resources.none;
                        break;
                    case 3:
                        player3.BackgroundImage = Monopoly.Properties.Resources.none;
                        break;
                    case 4:
                        player4.BackgroundImage = Monopoly.Properties.Resources.none;
                        break;
                }
            }
            //update money here
            player1Money.Text = "$" + player1Mon;
            player2Money.Text = "$" + player2Mon;
            player3Money.Text = "$" + player3Mon;
            player4Money.Text = "$" + player4Mon;

            if (doubles == false && (owned == "true" || owned == "unownable"))
            {
                button1.Visible = true;
                if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
                {
                    button1.Visible = true;
                }
                //turnNum++;
            }
            if (turnNum == 5)
                turnNum = 1;
        }

        private void buy_Click(object sender, EventArgs e)
        {
            Buy();
        }

        public void Buy()
        {
            switch (turn.Text)
            {
                case "Player 1's":
                    if (player1Mon < cost)
                    {
                        MessageBox.Show("You dont has the monies!");
                    }
                    else
                    {
                        player1Mon -= cost;
                        player1Props.Add(selectedProp);
                        player1Money.Text = "$" + player1Mon;
                        switch (selectedProp)
                        {

                            case 2:
                                prop2Owned = true;
                                prop2.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 4:
                                prop4Owned = true;
                                prop4.Image = Monopoly.Properties.Resources.redowned;
                                break;

                            case 6:
                                prop6Owned = true;
                                prop6.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 7:
                                prop7Owned = true;
                                prop7.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 9:
                                prop9Owned = true;
                                prop9.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 10:
                                prop10Owned = true;
                                prop10.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 12:
                                prop12Owned = true;
                                prop12.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 13:
                                prop13Owned = true;
                                prop13.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 14:
                                prop14Owned = true;
                                prop14.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 15:
                                prop15Owned = true;
                                prop15.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 16:
                                prop16Owned = true;
                                prop16.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 17:
                                prop17Owned = true;
                                prop17.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 19:
                                prop19Owned = true;
                                prop19.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 20:
                                prop20Owned = true;
                                prop20.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 22:
                                prop22Owned = true;
                                prop22.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 24:
                                prop24Owned = true;
                                prop24.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 25:
                                prop25Owned = true;
                                prop25.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 26:
                                prop26Owned = true;
                                prop26.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 27:
                                prop27Owned = true;
                                prop27.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 28:
                                prop28Owned = true;
                                prop28.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 29:
                                prop29Owned = true;
                                prop29.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 30:
                                prop30Owned = true;
                                prop30.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 32:
                                prop32Owned = true;
                                prop32.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 33:
                                prop33Owned = true;
                                prop33.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 35:
                                prop35Owned = true;
                                prop35.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 36:
                                prop36Owned = true;
                                prop36.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 38:
                                prop38Owned = true;
                                prop38.Image = Monopoly.Properties.Resources.redowned;
                                break;
                            case 40:
                                prop40Owned = true;
                                prop40.Image = Monopoly.Properties.Resources.redowned;
                                break;

                        }
                    }
                    break;
                case "Player 2's":
                    if (player2Mon < cost)
                    {
                        MessageBox.Show("You dont has the monies!");
                    }
                    else
                    {
                        player2Mon -= cost;
                        player2Props.Add(selectedProp);
                        player2Money.Text = "$" + player2Mon;
                        switch (selectedProp)
                        {

                            case 2:
                                prop2Owned = true;
                                prop2.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 4:
                                prop4Owned = true;
                                prop4.Image = Monopoly.Properties.Resources.pinkowned;
                                break;

                            case 6:
                                prop6Owned = true;
                                prop6.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 7:
                                prop7Owned = true;
                                prop7.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 9:
                                prop9Owned = true;
                                prop9.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 10:
                                prop10Owned = true;
                                prop10.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 12:
                                prop12Owned = true;
                                prop12.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 13:
                                prop13Owned = true;
                                prop13.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 14:
                                prop14Owned = true;
                                prop14.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 15:
                                prop15Owned = true;
                                prop15.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 16:
                                prop16Owned = true;
                                prop16.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 17:
                                prop17Owned = true;
                                prop17.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 19:
                                prop19Owned = true;
                                prop19.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 20:
                                prop20Owned = true;
                                prop20.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 22:
                                prop22Owned = true;
                                prop22.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 24:
                                prop24Owned = true;
                                prop24.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 25:
                                prop25Owned = true;
                                prop25.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 26:
                                prop26Owned = true;
                                prop26.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 27:
                                prop27Owned = true;
                                prop27.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 28:
                                prop28Owned = true;
                                prop28.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 29:
                                prop29Owned = true;
                                prop29.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 30:
                                prop30Owned = true;
                                prop30.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 32:
                                prop32Owned = true;
                                prop32.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 33:
                                prop33Owned = true;
                                prop33.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 35:
                                prop35Owned = true;
                                prop35.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 36:
                                prop36Owned = true;
                                prop36.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 38:
                                prop38Owned = true;
                                prop38.Image = Monopoly.Properties.Resources.pinkowned;
                                break;
                            case 40:
                                prop40Owned = true;
                                prop40.Image = Monopoly.Properties.Resources.pinkowned;
                                break;

                        }
                    }
                    break;
                case "Player 3's":
                    if (player3Mon < cost)
                    {
                        MessageBox.Show("You dont has the monies!");
                    }
                    else
                    {
                        player3Mon -= cost;
                        player3Props.Add(selectedProp);
                        player3Money.Text = "$" + player3Mon;
                        switch (selectedProp)
                        {

                            case 2:
                                prop2Owned = true;
                                prop2.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 4:
                                prop4Owned = true;
                                prop4.Image = Monopoly.Properties.Resources.blueowned;
                                break;

                            case 6:
                                prop6Owned = true;
                                prop6.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 7:
                                prop7Owned = true;
                                prop7.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 9:
                                prop9Owned = true;
                                prop9.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 10:
                                prop10Owned = true;
                                prop10.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 12:
                                prop12Owned = true;
                                prop12.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 13:
                                prop13Owned = true;
                                prop13.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 14:
                                prop14Owned = true;
                                prop14.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 15:
                                prop15Owned = true;
                                prop15.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 16:
                                prop16Owned = true;
                                prop16.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 17:
                                prop17Owned = true;
                                prop17.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 19:
                                prop19Owned = true;
                                prop19.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 20:
                                prop20Owned = true;
                                prop20.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 22:
                                prop22Owned = true;
                                prop22.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 24:
                                prop24Owned = true;
                                prop24.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 25:
                                prop25Owned = true;
                                prop25.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 26:
                                prop26Owned = true;
                                prop26.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 27:
                                prop27Owned = true;
                                prop27.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 28:
                                prop28Owned = true;
                                prop28.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 29:
                                prop29Owned = true;
                                prop29.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 30:
                                prop30Owned = true;
                                prop30.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 32:
                                prop32Owned = true;
                                prop32.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 33:
                                prop33Owned = true;
                                prop33.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 35:
                                prop35Owned = true;
                                prop35.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 36:
                                prop36Owned = true;
                                prop36.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 38:
                                prop38Owned = true;
                                prop38.Image = Monopoly.Properties.Resources.blueowned;
                                break;
                            case 40:
                                prop40Owned = true;
                                prop40.Image = Monopoly.Properties.Resources.blueowned;
                                break;

                        }
                    }
                    break;
                case "Player 4's":
                    if (player4Mon < cost)
                    {
                        MessageBox.Show("You dont has the monies!");
                    }
                    else
                    {
                        player4Mon -= cost;
                        player4Props.Add(selectedProp);
                        player4Money.Text = "$" + player4Mon;
                        switch (selectedProp)
                        {

                            case 2:
                                prop2Owned = true;
                                prop2.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 4:
                                prop4Owned = true;
                                prop4.Image = Monopoly.Properties.Resources.greenowned;
                                break;

                            case 6:
                                prop6Owned = true;
                                prop6.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 7:
                                prop7Owned = true;
                                prop7.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 9:
                                prop9Owned = true;
                                prop9.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 10:
                                prop10Owned = true;
                                prop10.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 12:
                                prop12Owned = true;
                                prop12.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 13:
                                prop13Owned = true;
                                prop13.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 14:
                                prop14Owned = true;
                                prop14.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 15:
                                prop15Owned = true;
                                prop15.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 16:
                                prop16Owned = true;
                                prop16.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 17:
                                prop17Owned = true;
                                prop17.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 19:
                                prop19Owned = true;
                                prop19.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 20:
                                prop20Owned = true;
                                prop20.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 22:
                                prop22Owned = true;
                                prop22.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 24:
                                prop24Owned = true;
                                prop24.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 25:
                                prop25Owned = true;
                                prop25.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 26:
                                prop26Owned = true;
                                prop26.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 27:
                                prop27Owned = true;
                                prop27.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 28:
                                prop28Owned = true;
                                prop28.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 29:
                                prop29Owned = true;
                                prop29.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 30:
                                prop30Owned = true;
                                prop30.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 32:
                                prop32Owned = true;
                                prop32.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 33:
                                prop33Owned = true;
                                prop33.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 35:
                                prop35Owned = true;
                                prop35.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 36:
                                prop36Owned = true;
                                prop36.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 38:
                                prop38Owned = true;
                                prop38.Image = Monopoly.Properties.Resources.greenowned;
                                break;
                            case 40:
                                prop40Owned = true;
                                prop40.Image = Monopoly.Properties.Resources.greenowned;
                                break;

                        }
                    }
                    break;
            }
            buy.Visible = false;
            nope.Visible = false;
            rollBtn.Visible = true;
            propBigBox.Image = Monopoly.Properties.Resources.none;
            switch (turnNum)
            {
                case 1:
                    player1.BackgroundImage = Monopoly.Properties.Resources.redowned;
                    break;
                case 2:
                    player2.BackgroundImage = Monopoly.Properties.Resources.pinkowned;
                    break;
                case 3:
                    player3.BackgroundImage = Monopoly.Properties.Resources.blueowned;
                    break;
                case 4:
                    player4.BackgroundImage = Monopoly.Properties.Resources.greenowned;
                    break;
            }
            if (doubles == false)
                button1.Visible = true;
            if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
            {
                button1.Visible = false;
            }
            //turnNum++;

            if (turnNum == 5)
                turnNum = 1;
            turn.Text = "Player " + turnNum + "'s";
        }

        private void nope_Click(object sender, EventArgs e)
        {
            buy.Visible = false;
            nope.Visible = false;
            rollBtn.Visible = true;
            propBigBox.Image = Monopoly.Properties.Resources.none;
            if (doubles == false)
                button1.Visible = true;
            if ((aiPlayer1.Checked && turnNum == 1) || (aiPlayer2.Checked && turnNum == 2) || (aiPlayer3.Checked && turnNum == 3) || (aiPlayer4.Checked && turnNum == 4))
            {
                button1.Visible = false;
            }
                //turnNum++;
            
            if (turnNum == 5)
                turnNum = 1;
            turn.Text = "Player " + turnNum + "'s";
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            turnNum++;
            totalTurns++;
            if (turnNum == 5)
                turnNum = 1;
            turn.Text = "Player " + turnNum + "'s";
            button1.Visible = false;
            chancepic.Visible = false;
        }

        public void ccswitch()
        {
            switch (cc)
            {
                case 1:
                    chancepic.Image = Monopoly.Properties.Resources.cc1;
                    switch (turnNum)
                    {
                        case 1:
                            player1Mon += 150;
                            player2Mon -= 50;
                            player3Mon -= 50;
                            player4Mon -= 50;
                            break;
                        case 2:
                            player2Mon += 150;
                            player1Mon -= 50;
                            player3Mon -= 50;
                            player4Mon -= 50;
                            break;
                        case 3:
                            player3Mon += 150;
                            player1Mon -= 50;
                            player2Mon -= 50;
                            player4Mon -= 50;
                            break;
                        case 4:
                            player4Mon += 150;
                            player1Mon -= 50;
                            player2Mon -= 50;
                            player3Mon -= 50;
                            break;
                    }
                    break;
                case 2:
                    chancepic.Image = Monopoly.Properties.Resources.cc2;
                    switch(turnNum)
                    {
                        case 1:
                            player1Mon += 25;
                            break;
                        case 2:
                            player2Mon += 25;
                            break;
                        case 3:
                            player3Mon += 25;
                            break;
                        case 4:
                            player4Mon += 25;
                            break;
                    }
                    break;
                case 3:
                    chancepic.Image = Monopoly.Properties.Resources.cc3;
                    Point tile1 = new Point(578, 585);
                    switch (turnNum)
                    {
                        case 1:
                            
                            player1.Location=tile1;
                            player1Mon += 200;
                            break;
                        case 2:
                            player2.Location=tile1;
                            player2Mon += 200;
                            break;
                        case 3:
                            player3.Location=tile1;
                            player3Mon += 200;
                            break;
                        case 4:
                            player4.Location=tile1;
                            player4Mon += 200;
                            break;
                    }
                    break;
                case 4:
                    chancepic.Image = Monopoly.Properties.Resources.cc4;
                    switch(turnNum)
                    {
                        case 1:
                            player1Mon -= 100;
                            break;
                        case 2:
                            player2Mon -= 100;
                            break;
                        case 3:
                            player3Mon -= 100;
                            break;
                        case 4:
                            player4Mon -= 100;
                            break;
                    }
                    break;
                case 5:
                    chancepic.Image = Monopoly.Properties.Resources.cc5;
                    switch(turnNum)
                    {
                        case 1:
                            player1Mon -= 50;
                            break;
                        case 2:
                            player2Mon -= 50;
                            break;
                        case 3:
                            player3Mon -= 50;
                            break;
                        case 4:
                            player4Mon -= 50;
                            break;
                    }
                    break;
                case 6:
                    chancepic.Image = Monopoly.Properties.Resources.cc6;
                    switch(turnNum)
                    {
                        case 1:
                            jail1free++;
                            break;
                        case 2:
                            jail2free++;
                            break;
                        case 3:
                            jail3free++;
                            break;
                        case 4:
                            jail4free++;
                            break;
                    }
                    break;
                case 7:
                    chancepic.Image = Monopoly.Properties.Resources.cc7;
                    switch(turnNum)
                    {
                        case 1:
                            player1Mon += 45;
                            break;
                        case 2:
                            player2Mon += 45;
                            break;
                        case 3:
                            player3Mon += 45;
                            break;
                        case 4:
                            player4Mon += 45;
                            break;
                    }
                    break;
                case 8:
                    chancepic.Image = Monopoly.Properties.Resources.cc8;
                    switch(turnNum)
                    {
                        case 1:
                            player1Mon += 100;
                            break;
                        case 2:
                            player2Mon += 100;
                            break;
                        case 3:
                            player3Mon += 100;
                            break;
                        case 4:
                            player4Mon += 100;
                            break;
                    }
                    break;
                case 9:
                    chancepic.Image = Monopoly.Properties.Resources.cc9;
                    Point jail = new Point(34, 571);
                    switch (turnNum)
                    {
                        case 1:
                            
                            player1.Location=jail;
                            break;
                        case 2:
                            player2.Location=jail;
                            break;
                        case 3:
                            player3.Location=jail;
                            break;
                        case 4:
                            player4.Location=jail;
                            break;
                    }
                    break;
                case 10:
                    chancepic.Image = Monopoly.Properties.Resources.cc10;
                    switch(turnNum)
                    {
                        case 1:
                            player1Mon += 100;
                            break;
                        case 2:
                            player2Mon += 100;
                            break;
                        case 3:
                            player3Mon += 100;
                            break;
                        case 4:
                            player4Mon += 100;
                            break;
                    }
                    break;
                case 11:
                    chancepic.Image = Monopoly.Properties.Resources.cc11;
                    switch(turnNum)
                    {
                        case 1:
                            player1Mon += 10;
                            break;
                        case 2:
                            player2Mon += 10;
                            break;
                        case 3:
                            player3Mon += 10;
                            break;
                        case 4:
                            player4Mon += 10;
                            break;
                    }
                    break;
                case 12:
                    chancepic.Image = Monopoly.Properties.Resources.cc12;
                    switch(turnNum)
                    {
                        case 1:
                            player1Mon += 100;
                            break;
                        case 2:
                            player2Mon += 100;
                            break;
                        case 3:
                            player3Mon += 100;
                            break;
                        case 4:
                            player4Mon += 100;
                            break;
                    }
                    break;
                case 13:
                    chancepic.Image = Monopoly.Properties.Resources.cc13;
                    //make later
                    break;
                case 14:
                    chancepic.Image = Monopoly.Properties.Resources.cc14;
                    switch(turnNum)
                    {
                        case 1:
                            player1Mon += 200;
                            break;
                        case 2:
                            player2Mon += 200;
                            break;
                        case 3:
                            player3Mon += 200;
                            break;
                        case 4:
                            player4Mon += 200;
                            break;
                    }
                    break;
                case 15:
                    chancepic.Image = Monopoly.Properties.Resources.cc15;
                    switch(turnNum)
                    {
                        case 1:
                            player1Mon += 20;
                            break;
                        case 2:
                            player2Mon += 20;
                            break;
                        case 3:
                            player3Mon += 20;
                            break;
                        case 4:
                            player4Mon += 20;
                            break;
                    }
                    break;

            }
        }
        public void chanceswitch()
        {
            switch (cc)
            {
                case 1:
                    chancepic.Image = Monopoly.Properties.Resources.chance1;
                    switch (turnNum)
                    {
                        case 1:
                            jail1free++;
                            break;
                        case 2:
                            jail2free++;
                            break;
                        case 3:
                            jail3free++;
                            break;
                        case 4:
                            jail4free++;
                            break;
                    }
                    
                    break;
                case 2:
                    chancepic.Image = Monopoly.Properties.Resources.chance2;
                    switch (turnNum)
                    {
                        case 1:
                            player1Mon -= 15;
                            break;
                        case 2:
                            player2Mon -= 15;
                            break;
                        case 3:
                            player3Mon -= 15;
                            break;
                        case 4:
                            player4Mon -= 15;
                            break;
                    }
                    break;
                case 3:
                    chancepic.Image = Monopoly.Properties.Resources.chance3;
                    switch (turnNum)
                    {
                        case 1:
                            player1Mon += 50;
                            break;
                        case 2:
                            player2Mon += 50;
                            break;
                        case 3:
                            player3Mon += 50;
                            break;
                        case 4:
                            player4Mon += 50;
                            break;
                    }
                    break;
                case 4:
                    chancepic.Image = Monopoly.Properties.Resources.chance4;
                    //make later
                    break;
                case 5:
                    chancepic.Image = Monopoly.Properties.Resources.chance5;
                    //make later
                    break;
                case 6:
                    chancepic.Image = Monopoly.Properties.Resources.chance6;
                    Point jail = new Point(34, 571);
                    switch (turnNum)
                    {
                        case 1:

                            player1.Location = jail;
                            break;
                        case 2:
                            player2.Location = jail;
                            break;
                        case 3:
                            player3.Location = jail;
                            break;
                        case 4:
                            player4.Location = jail;
                            break;
                    }
                    break;
                case 7:
                    chancepic.Image = Monopoly.Properties.Resources.chance7;
                    Point tile1 = new Point(578, 585);
                    switch (turnNum)
                    {
                        case 1:
                            
                            player1.Location=tile1;
                            player1Mon += 200;
                            break;
                        case 2:
                            player2.Location=tile1;
                            player2Mon += 200;
                            break;
                        case 3:
                            player3.Location=tile1;
                            player3Mon += 200;
                            break;
                        case 4:
                            player4.Location=tile1;
                            player4Mon += 200;
                            break;
                    }
                    break;
                case 8:
                    chancepic.Image = Monopoly.Properties.Resources.chance8;
                    //make later
                    break;
                case 9:
                    chancepic.Image = Monopoly.Properties.Resources.chance9;
                    //make later
                    break;
                case 10:
                    chancepic.Image = Monopoly.Properties.Resources.chance10;
                    Point ia = new Point(249, 18);
                    switch (turnNum)
                    {
                        case 1:

                            player1.Location = ia;
                            break;
                        case 2:
                            player2.Location = ia;
                            break;
                        case 3:
                            player3.Location = ia;
                            break;
                        case 4:
                            player4.Location = ia;
                            break;
                    }
                    break;
                case 11:
                    chancepic.Image = Monopoly.Properties.Resources.chance11;
                    Point sc = new Point(12, 519);
                    switch (turnNum)
                    {
                        case 1:

                            player1.Location = sc;
                            break;
                        case 2:
                            player2.Location = sc;
                            break;
                        case 3:
                            player3.Location = sc;
                            break;
                        case 4:
                            player4.Location = sc;
                            break;
                    }
                    break;
                case 12:
                    chancepic.Image = Monopoly.Properties.Resources.chance12;
                    //make later
                    break;
                case 13:
                    chancepic.Image = Monopoly.Properties.Resources.chance13;
                    Point b = new Point(588, 519);
                    switch (turnNum)
                    {
                        case 1:

                            player1.Location = b;
                            break;
                        case 2:
                            player2.Location = b;
                            break;
                        case 3:
                            player3.Location = b;
                            break;
                        case 4:
                            player4.Location = b;
                            break;
                    }
                    break;
                case 14:
                    chancepic.Image = Monopoly.Properties.Resources.chance14;
                    switch (turnNum)
                    {
                        case 1:
                            player1Mon -= 150;
                            player2Mon += 50;
                            player3Mon += 50;
                            player4Mon += 50;
                            break;
                        case 2:
                            player2Mon -= 150;
                            player1Mon += 50;
                            player3Mon += 50;
                            player4Mon += 50;
                            break;
                        case 3:
                            player3Mon -= 150;
                            player1Mon += 50;
                            player2Mon += 50;
                            player4Mon += 50;
                            break;
                        case 4:
                            player4Mon -= 150;
                            player1Mon += 50;
                            player2Mon += 50;
                            player3Mon += 50;
                            break;
                    }
                    break;
                case 15:
                    chancepic.Image = Monopoly.Properties.Resources.chance15;
                    switch (turnNum)
                    {
                        case 1:
                            player1Mon += 150;
                            break;
                        case 2:
                            player2Mon += 150;
                            break;
                        case 3:
                            player3Mon += 150;
                            break;
                        case 4:
                            player4Mon += 150;
                            break;
                    }
                    break;
                case 16:
                    chancepic.Image = Monopoly.Properties.Resources.chance16;
                    //make later
                    break;

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            btnSend.Visible = true;
            emailBox.Visible = true;
        }

        public void errorMail()
        {
            MailMessage oMail = new MailMessage(new MailAddress("dzm201225@gmail.com"), new MailAddress("dzm201225@gmail.com"));
            SmtpClient oSmtp = new SmtpClient();
            oSmtp.Host = "smtp.mail.yahoo.com";
            oSmtp.Credentials = new NetworkCredential("monopolythegame", "cowscows54");
            oSmtp.EnableSsl = false;
            oSmtp.Port = 587;
            oMail.Subject = "Monopoly Bug";
            string error= "Turn Number: "+turnNum+"\nTotal Turns: "+totalTurns+"\n\n"+emailBox.Text;
            oMail.Body = error;
            oSmtp.Send(oMail);
            btnSend.Visible = false;
            emailBox.Visible = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            errorMail();
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailBox_Click(object sender, EventArgs e)
        {
            if (emailBox.Text == "What Happened?")
            {
                emailBox.Text = "";
            }
        }
        public void build()
        {

        }

        private void buildbtn_Click(object sender, EventArgs e)
        {
            build b = new build(player1Props, player2Props, player3Props, player4Props, turnNum, player1Mon, player2Mon, player3Mon, player4Mon, player1Pos, player2Pos, player3Pos, player4Pos);
            if (turnNum == 1 && (player1Props.Contains(2) && player1Props.Contains(4)) ||
                (player1Props.Contains(7) && player1Props.Contains(9) && player1Props.Contains(10)) ||
                (player1Props.Contains(12) && player1Props.Contains(14) && player1Props.Contains(15)) ||
                (player1Props.Contains(17) && player1Props.Contains(19) && player1Props.Contains(20)) ||
                (player1Props.Contains(22) && player1Props.Contains(24) && player1Props.Contains(25)) ||
                (player1Props.Contains(27) && player1Props.Contains(28) && player1Props.Contains(30)) ||
                (player1Props.Contains(32) && player1Props.Contains(34) && player1Props.Contains(35)) ||
                (player1Props.Contains(38) && player1Props.Contains(40)))
            {
                b.Show();
            }
            if (turnNum == 2 && (player2Props.Contains(2) && player2Props.Contains(4)) ||
                (player2Props.Contains(7) && player2Props.Contains(9) && player2Props.Contains(10)) ||
                (player2Props.Contains(12) && player2Props.Contains(14) && player2Props.Contains(15)) ||
                (player2Props.Contains(17) && player2Props.Contains(19) && player2Props.Contains(20)) ||
                (player2Props.Contains(22) && player2Props.Contains(24) && player2Props.Contains(25)) ||
                (player2Props.Contains(27) && player2Props.Contains(28) && player2Props.Contains(30)) ||
                (player2Props.Contains(32) && player2Props.Contains(34) && player2Props.Contains(35)) ||
                (player2Props.Contains(38) && player2Props.Contains(40)))
            {
                b.Show();
            }
            if (turnNum == 3 && (player3Props.Contains(2) && player3Props.Contains(4)) ||
                (player3Props.Contains(7) && player3Props.Contains(9) && player3Props.Contains(10)) ||
                (player3Props.Contains(12) && player3Props.Contains(14) && player3Props.Contains(15)) ||
                (player3Props.Contains(17) && player3Props.Contains(19) && player3Props.Contains(20)) ||
                (player3Props.Contains(22) && player3Props.Contains(24) && player3Props.Contains(25)) ||
                (player3Props.Contains(27) && player3Props.Contains(28) && player3Props.Contains(30)) ||
                (player3Props.Contains(32) && player3Props.Contains(34) && player3Props.Contains(35)) ||
                (player3Props.Contains(38) && player3Props.Contains(40)))
            {
                b.Show();
            }
            if (turnNum == 4 && (player4Props.Contains(2) && player4Props.Contains(4)) ||
                (player4Props.Contains(7) && player4Props.Contains(9) && player4Props.Contains(10)) ||
                (player4Props.Contains(12) && player4Props.Contains(14) && player4Props.Contains(15)) ||
                (player4Props.Contains(17) && player4Props.Contains(19) && player4Props.Contains(20)) ||
                (player4Props.Contains(22) && player4Props.Contains(24) && player4Props.Contains(25)) ||
                (player4Props.Contains(27) && player4Props.Contains(28) && player4Props.Contains(30)) ||
                (player4Props.Contains(32) && player4Props.Contains(33) && player4Props.Contains(35)) ||
                (player4Props.Contains(38) && player4Props.Contains(40)))
            {
                b.Show();
            }
        }

        private void btnTrade_Click(object sender, EventArgs e)
        {
            trade t = new trade(player1Props, player2Props, player3Props, player4Props, turnNum, player1Mon, player2Mon, player3Mon, player4Mon);
            t.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void position()
        {
            switch (turnNum)
            {
                case 1:
                    switch (player1Pos)
                    {
                        case 1:
                            Point tile1 = new Point(578, 585);
                            player1.Location = tile1;
                            break;
                        case 2:
                            Point tile2 = new Point(505, 585);
                            player1.Location = tile2;
                            break;
                        case 3:
                            Point tile3 = new Point(452, 585);
                            player1.Location = tile3;
                            break;
                        case 4:
                            Point tile4 = new Point(403, 585);
                            player1.Location = tile4;
                            break;
                        case 5:
                            Point tile5 = new Point(350, 585);
                            player1.Location = tile5;
                            break;
                        case 6:
                            Point tile6 = new Point(297, 585);
                            player1.Location = tile6;
                            break;
                        case 7:
                            Point tile7 = new Point(244, 585);
                            player1.Location = tile7;
                            break;
                        case 8:
                            Point tile8 = new Point(191, 585);
                            player1.Location = tile8;
                            break;
                        case 9:
                            Point tile9 = new Point(138, 585);
                            player1.Location = tile9;
                            break;
                        case 10:
                            Point tile10 = new Point(85, 585);
                            player1.Location = tile10;
                            break;
                        case 11:
                            Point tile11 = new Point(31, 585);
                            player1.Location = tile11;
                            break;
                        case 12:
                            Point tile12 = new Point(31, 520);
                            player1.Location = tile12;
                            break;
                        case 13:
                            Point tile13 = new Point(31, 464);
                            player1.Location = tile13;
                            break;
                        case 14:
                            Point tile14 = new Point(31, 408);
                            player1.Location = tile14;
                            break;
                        case 15:
                            Point tile15 = new Point(31, 352);
                            player1.Location = tile15;
                            break;
                        case 16:
                            Point tile16 = new Point(12, 304);
                            player1.Location = tile16;
                            break;
                        case 17:
                            Point tile17 = new Point(12, 256);
                            player1.Location = tile17;
                            break;
                        case 18:
                            Point tile18 = new Point(12, 204);
                            player1.Location = tile18;
                            break;
                        case 19:
                            Point tile19 = new Point(12, 151);
                            player1.Location = tile19;
                            break;
                        case 20:
                            Point tile20 = new Point(12, 95);
                            player1.Location = tile20;
                            break;
                        case 21:
                            Point tile21 = new Point(31, 21);
                            player1.Location = tile21;
                            break;
                        case 22:
                            Point tile22 = new Point(85, 12);
                            player1.Location = tile22;
                            break;
                        case 23:
                            Point tile23 = new Point(138, 12);
                            player1.Location = tile23;
                            break;
                        case 24:
                            Point tile24 = new Point(189, 12);
                            player1.Location = tile24;
                            break;
                        case 25:
                            Point tile25 = new Point(243, 12);
                            player1.Location = tile25;
                            break;
                        case 26:
                            Point tile26 = new Point(296, 12);
                            player1.Location = tile26;
                            break;
                        case 27:
                            Point tile27 = new Point(349, 12);
                            player1.Location = tile27;
                            break;
                        case 28:
                            Point tile28 = new Point(403, 12);
                            player1.Location = tile28;
                            break;
                        case 29:
                            Point tile29 = new Point(456, 12);
                            player1.Location = tile29;
                            break;
                        case 30:
                            Point tile30 = new Point(507, 12);
                            player1.Location = tile30;
                            break;
                        case 31:
                            Point tile31 = new Point(578, 12);
                            player1.Location = tile31;
                            break;
                        case 32:
                            Point tile32 = new Point(578, 89);
                            player1.Location = tile32;
                            break;
                        case 33:
                            Point tile33 = new Point(578, 142);
                            player1.Location = tile33;
                            break;
                        case 34:
                            Point tile34 = new Point(578, 195);
                            player1.Location = tile34;
                            break;
                        case 35:
                            Point tile35 = new Point(578, 248);
                            player1.Location = tile35;
                            break;
                        case 36:
                            Point tile36 = new Point(578, 304);
                            player1.Location = tile36;
                            break;
                        case 37:
                            Point tile37 = new Point(578, 351);
                            player1.Location = tile37;
                            break;
                        case 38:
                            Point tile38 = new Point(578, 408);
                            player1.Location = tile38;
                            break;
                        case 39:
                            Point tile39 = new Point(578, 459);
                            player1.Location = tile39;
                            break;
                        case 40:
                            Point tile40 = new Point(578, 511);
                            player1.Location = tile40;
                            break;

                    }
                    break;
                case 2:
                    switch (player2Pos)
                    {
                        case 1:
                            Point tile1 = new Point(578, 585);
                            player2.Location = tile1;
                            break;
                        case 2:
                            Point tile2 = new Point(505, 585);
                            player2.Location = tile2;
                            break;
                        case 3:
                            Point tile3 = new Point(452, 585);
                            player2.Location = tile3;
                            break;
                        case 4:
                            Point tile4 = new Point(403, 585);
                            player2.Location = tile4;
                            break;
                        case 5:
                            Point tile5 = new Point(350, 585);
                            player2.Location = tile5;
                            break;
                        case 6:
                            Point tile6 = new Point(297, 585);
                            player2.Location = tile6;
                            break;
                        case 7:
                            Point tile7 = new Point(244, 585);
                            player2.Location = tile7;
                            break;
                        case 8:
                            Point tile8 = new Point(191, 585);
                            player2.Location = tile8;
                            break;
                        case 9:
                            Point tile9 = new Point(138, 585);
                            player2.Location = tile9;
                            break;
                        case 10:
                            Point tile10 = new Point(85, 585);
                            player2.Location = tile10;
                            break;
                        case 11:
                            Point tile11 = new Point(31, 585);
                            player2.Location = tile11;
                            break;
                        case 12:
                            Point tile12 = new Point(31, 520);
                            player2.Location = tile12;
                            break;
                        case 13:
                            Point tile13 = new Point(31, 464);
                            player2.Location = tile13;
                            break;
                        case 14:
                            Point tile14 = new Point(31, 408);
                            player2.Location = tile14;
                            break;
                        case 15:
                            Point tile15 = new Point(31, 352);
                            player2.Location = tile15;
                            break;
                        case 16:
                            Point tile16 = new Point(31, 296);
                            player2.Location = tile16;
                            break;
                        case 17:
                            Point tile17 = new Point(12, 257);
                            player2.Location = tile17;
                            break;
                        case 18:
                            Point tile18 = new Point(12, 204);
                            player2.Location = tile18;
                            break;
                        case 19:
                            Point tile19 = new Point(12, 145);
                            player2.Location = tile19;
                            break;
                        case 20:
                            Point tile20 = new Point(12, 95);
                            player2.Location = tile20;
                            break;
                        case 21:
                            Point tile21 = new Point(31, 21);
                            player2.Location = tile21;
                            break;
                        case 22:
                            Point tile22 = new Point(85, 12);
                            player2.Location = tile22;
                            break;
                        case 23:
                            Point tile23 = new Point(138, 12);
                            player2.Location = tile23;
                            break;
                        case 24:
                            Point tile24 = new Point(189, 12);
                            player2.Location = tile24;
                            break;
                        case 25:
                            Point tile25 = new Point(243, 12);
                            player2.Location = tile25;
                            break;
                        case 26:
                            Point tile26 = new Point(296, 12);
                            player2.Location = tile26;
                            break;
                        case 27:
                            Point tile27 = new Point(349, 12);
                            player2.Location = tile27;
                            break;
                        case 28:
                            Point tile28 = new Point(403, 12);
                            player2.Location = tile28;
                            break;
                        case 29:
                            Point tile29 = new Point(456, 12);
                            player2.Location = tile29;
                            break;
                        case 30:
                            Point tile30 = new Point(507, 12);
                            player2.Location = tile30;
                            break;
                        case 31:
                            Point tile31 = new Point(578, 12);
                            player2.Location = tile31;
                            break;
                        case 32:
                            Point tile32 = new Point(578, 89);
                            player2.Location = tile32;
                            break;
                        case 33:
                            Point tile33 = new Point(578, 142);
                            player2.Location = tile33;
                            break;
                        case 34:
                            Point tile34 = new Point(578, 195);
                            player2.Location = tile34;
                            break;
                        case 35:
                            Point tile35 = new Point(578, 248);
                            player2.Location = tile35;
                            break;
                        case 36:
                            Point tile36 = new Point(578, 304);
                            player2.Location = tile36;
                            break;
                        case 37:
                            Point tile37 = new Point(578, 351);
                            player2.Location = tile37;
                            break;
                        case 38:
                            Point tile38 = new Point(578, 408);
                            player2.Location = tile38;
                            break;
                        case 39:
                            Point tile39 = new Point(578, 459);
                            player2.Location = tile39;
                            break;
                        case 40:
                            Point tile40 = new Point(578, 511);
                            player2.Location = tile40;
                            break;

                    }
                    break;
                case 3:
                    player3Pos += derp;
                    if (player3Pos > 40)
                    {
                        int temp;
                        temp = player3Pos - 40;
                        player3Pos = temp;
                        player3Mon += 200;
                    }
                    landed(player3Pos);
                    switch (player3Pos)
                    {
                        case 1:
                            Point tile1 = new Point(578, 585);
                            player3.Location = tile1;
                            break;
                        case 2:
                            Point tile2 = new Point(505, 585);
                            player3.Location = tile2;
                            break;
                        case 3:
                            Point tile3 = new Point(452, 585);
                            player3.Location = tile3;
                            break;
                        case 4:
                            Point tile4 = new Point(403, 585);
                            player3.Location = tile4;
                            break;
                        case 5:
                            Point tile5 = new Point(350, 585);
                            player3.Location = tile5;
                            break;
                        case 6:
                            Point tile6 = new Point(297, 585);
                            player3.Location = tile6;
                            break;
                        case 7:
                            Point tile7 = new Point(244, 585);
                            player3.Location = tile7;
                            break;
                        case 8:
                            Point tile8 = new Point(191, 585);
                            player3.Location = tile8;
                            break;
                        case 9:
                            Point tile9 = new Point(138, 585);
                            player3.Location = tile9;
                            break;
                        case 10:
                            Point tile10 = new Point(85, 585);
                            player3.Location = tile10;
                            break;
                        case 11:
                            Point tile11 = new Point(31, 585);
                            player3.Location = tile11;
                            break;
                        case 12:
                            Point tile12 = new Point(31, 520);
                            player3.Location = tile12;
                            break;
                        case 13:
                            Point tile13 = new Point(31, 464);
                            player3.Location = tile13;
                            break;
                        case 14:
                            Point tile14 = new Point(31, 408);
                            player3.Location = tile14;
                            break;
                        case 15:
                            Point tile15 = new Point(31, 352);
                            player3.Location = tile15;
                            break;
                        case 16:
                            Point tile16 = new Point(31, 296);
                            player3.Location = tile16;
                            break;
                        case 17:
                            Point tile17 = new Point(12, 257);
                            player3.Location = tile17;
                            break;
                        case 18:
                            Point tile18 = new Point(12, 204);
                            player3.Location = tile18;
                            break;
                        case 19:
                            Point tile19 = new Point(12, 145);
                            player3.Location = tile19;
                            break;
                        case 20:
                            Point tile20 = new Point(12, 95);
                            player3.Location = tile20;
                            break;
                        case 21:
                            Point tile21 = new Point(31, 21);
                            player3.Location = tile21;
                            break;
                        case 22:
                            Point tile22 = new Point(85, 12);
                            player3.Location = tile22;
                            break;
                        case 23:
                            Point tile23 = new Point(138, 12);
                            player3.Location = tile23;
                            break;
                        case 24:
                            Point tile24 = new Point(189, 12);
                            player3.Location = tile24;
                            break;
                        case 25:
                            Point tile25 = new Point(243, 12);
                            player3.Location = tile25;
                            break;
                        case 26:
                            Point tile26 = new Point(296, 12);
                            player3.Location = tile26;
                            break;
                        case 27:
                            Point tile27 = new Point(349, 12);
                            player3.Location = tile27;
                            break;
                        case 28:
                            Point tile28 = new Point(403, 12);
                            player3.Location = tile28;
                            break;
                        case 29:
                            Point tile29 = new Point(456, 12);
                            player3.Location = tile29;
                            break;
                        case 30:
                            Point tile30 = new Point(507, 12);
                            player3.Location = tile30;
                            break;
                        case 31:
                            Point tile31 = new Point(578, 12);
                            player3.Location = tile31;
                            break;
                        case 32:
                            Point tile32 = new Point(578, 89);
                            player3.Location = tile32;
                            break;
                        case 33:
                            Point tile33 = new Point(578, 142);
                            player3.Location = tile33;
                            break;
                        case 34:
                            Point tile34 = new Point(578, 195);
                            player3.Location = tile34;
                            break;
                        case 35:
                            Point tile35 = new Point(578, 248);
                            player3.Location = tile35;
                            break;
                        case 36:
                            Point tile36 = new Point(578, 304);
                            player3.Location = tile36;
                            break;
                        case 37:
                            Point tile37 = new Point(578, 351);
                            player3.Location = tile37;
                            break;
                        case 38:
                            Point tile38 = new Point(578, 408);
                            player3.Location = tile38;
                            break;
                        case 39:
                            Point tile39 = new Point(578, 459);
                            player3.Location = tile39;
                            break;
                        case 40:
                            Point tile40 = new Point(578, 511);
                            player3.Location = tile40;
                            break;

                    }
                    break;
                case 4:
                    player4Pos += derp;
                    if (player4Pos > 40)
                    {
                        int temp;
                        temp = player4Pos - 40;
                        player4Pos = temp;
                        player4Mon += 200;
                    }
                    landed(player4Pos);
                    switch (player4Pos)
                    {
                        case 1:
                            Point tile1 = new Point(578, 585);
                            player4.Location = tile1;
                            break;
                        case 2:
                            Point tile2 = new Point(505, 585);
                            player4.Location = tile2;
                            break;
                        case 3:
                            Point tile3 = new Point(452, 585);
                            player4.Location = tile3;
                            break;
                        case 4:
                            Point tile4 = new Point(403, 585);
                            player4.Location = tile4;
                            break;
                        case 5:
                            Point tile5 = new Point(350, 585);
                            player4.Location = tile5;
                            break;
                        case 6:
                            Point tile6 = new Point(297, 585);
                            player4.Location = tile6;
                            break;
                        case 7:
                            Point tile7 = new Point(244, 585);
                            player4.Location = tile7;
                            break;
                        case 8:
                            Point tile8 = new Point(191, 585);
                            player4.Location = tile8;
                            break;
                        case 9:
                            Point tile9 = new Point(138, 585);
                            player4.Location = tile9;
                            break;
                        case 10:
                            Point tile10 = new Point(85, 585);
                            player4.Location = tile10;
                            break;
                        case 11:
                            Point tile11 = new Point(31, 585);
                            player4.Location = tile11;
                            break;
                        case 12:
                            Point tile12 = new Point(31, 520);
                            player4.Location = tile12;
                            break;
                        case 13:
                            Point tile13 = new Point(31, 464);
                            player4.Location = tile13;
                            break;
                        case 14:
                            Point tile14 = new Point(31, 408);
                            player4.Location = tile14;
                            break;
                        case 15:
                            Point tile15 = new Point(31, 352);
                            player4.Location = tile15;
                            break;
                        case 16:
                            Point tile16 = new Point(31, 296);
                            player4.Location = tile16;
                            break;
                        case 17:
                            Point tile17 = new Point(12, 257);
                            player4.Location = tile17;
                            break;
                        case 18:
                            Point tile18 = new Point(12, 204);
                            player4.Location = tile18;
                            break;
                        case 19:
                            Point tile19 = new Point(12, 145);
                            player4.Location = tile19;
                            break;
                        case 20:
                            Point tile20 = new Point(12, 95);
                            player4.Location = tile20;
                            break;
                        case 21:
                            Point tile21 = new Point(31, 21);//free parking
                            player4.Location = tile21;
                            break;
                        case 22:
                            Point tile22 = new Point(85, 12);
                            player4.Location = tile22;
                            break;
                        case 23:
                            Point tile23 = new Point(138, 12);
                            player4.Location = tile23;
                            break;
                        case 24:
                            Point tile24 = new Point(189, 12);
                            player4.Location = tile24;
                            break;
                        case 25:
                            Point tile25 = new Point(243, 12);
                            player4.Location = tile25;
                            break;
                        case 26:
                            Point tile26 = new Point(296, 12);
                            player4.Location = tile26;
                            break;
                        case 27:
                            Point tile27 = new Point(349, 12);
                            player4.Location = tile27;
                            break;
                        case 28:
                            Point tile28 = new Point(403, 12);
                            player4.Location = tile28;
                            break;
                        case 29:
                            Point tile29 = new Point(456, 12);
                            player4.Location = tile29;
                            break;
                        case 30:
                            Point tile30 = new Point(507, 12);
                            player4.Location = tile30;
                            break;
                        case 31:
                            Point tile31 = new Point(578, 12);
                            player4.Location = tile31;
                            break;
                        case 32:
                            Point tile32 = new Point(578, 89);
                            player4.Location = tile32;
                            break;
                        case 33:
                            Point tile33 = new Point(578, 142);
                            player4.Location = tile33;
                            break;
                        case 34:
                            Point tile34 = new Point(578, 195);
                            player4.Location = tile34;
                            break;
                        case 35:
                            Point tile35 = new Point(578, 248);
                            player4.Location = tile35;
                            break;
                        case 36:
                            Point tile36 = new Point(578, 304);
                            player4.Location = tile36;
                            break;
                        case 37:
                            Point tile37 = new Point(578, 351);
                            player4.Location = tile37;
                            break;
                        case 38:
                            Point tile38 = new Point(578, 408);
                            player4.Location = tile38;
                            break;
                        case 39:
                            Point tile39 = new Point(578, 459);
                            player4.Location = tile39;
                            break;
                        case 40:
                            Point tile40 = new Point(578, 511);
                            player4.Location = tile40;
                            break;

                    }
                    break;
            }
        }

        

    }
}
