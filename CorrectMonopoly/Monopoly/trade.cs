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
    public partial class trade : Form
    {
        List<int> Player1;
        List<int> Player2;
        List<int> Player3;
        List<int> Player4;

        List<int> Playerx = new List<int>();
        List<int> Playery = new List<int>();

        int player1x = 43, player1y = 59;
        int player2x = 210, player2y = 59;
        int offer1x = 43, offer1y = 266;
        int offer2x = 210, offer2y = 266;
        int selectedPlayer = 0;
        int money1, money2, money3, money4;

        int playerxMon = 0;
        int playeryMon = 0;
        
        int turn;
        public trade(List<int> player1, List<int> player2, List<int> player3, List<int> player4, int number,int player1Mon,int player2Mon,int player3Mon,int player4Mon)
        {

            InitializeComponent();

            money1 = player1Mon;
            money2 = player2Mon;
            money3 = player3Mon;
            money4 = player4Mon;

            Player1 = player1;
            Player2 = player2;
            Player3 = player3;
            Player4 = player4;
            
            turn = number;

            switch (turn)
            {
                case 1:
                    tradePlayer1.Visible = false;
                    break;
                case 2:
                    tradePlayer2.Visible = false;
                    break;
                case 3:
                    tradePlayer3.Visible = false;
                    break;
                case 4:
                    tradePlayer4.Visible = false;
                    break;
            }
        }
        public void selectPlayer1()
        {
            if (Player1.Contains(2))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                MeditAveLbl.Location = tile1;
                MeditAveLbl.Visible = true;
            }
            if (Player1.Contains(4))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                BaltAveLbl.Location = tile1;
                BaltAveLbl.Visible = true;
            }
            if (Player1.Contains(6))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                RR1Lbl.Location = tile1;
                RR1Lbl.Visible = true;
            }
            if (Player1.Contains(7))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                OriAveLbl.Location = tile1;
                OriAveLbl.Visible = true;
            }
            if (Player1.Contains(9))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                VermAveLbl.Location = tile1;
                VermAveLbl.Visible = true;
            }
            if (Player1.Contains(10))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                ConAveLbl.Location = tile1;
                ConAveLbl.Visible = true;
            }
            if (Player1.Contains(12))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                CharAveLbl.Location = tile1;
                CharAveLbl.Visible = true;
            }
            if (Player1.Contains(14))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                StateAveLbl.Location = tile1;
                StateAveLbl.Visible = true;
            }
            if (Player1.Contains(15))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                VirgAveLbl.Location = tile1;
                VirgAveLbl.Visible = true;
            }
            if (Player1.Contains(16))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                RR2Lbl.Location = tile1;
                RR2Lbl.Visible = true;
            }
            if (Player1.Contains(17))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                JamesAveLbl.Location = tile1;
                JamesAveLbl.Visible = true;
            }
            if (Player1.Contains(19))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                TenAveLbl.Location = tile1;
                TenAveLbl.Visible = true;
            }
            if (Player1.Contains(20))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                NYAveLbl.Location = tile1;
                NYAveLbl.Visible = true;
            }
            if (Player1.Contains(22))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                KentAveLbl.Location = tile1;
                KentAveLbl.Visible = true;
            }
            if (Player1.Contains(24))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                IndiAveLbl.Location = tile1;
                IndiAveLbl.Visible = true;
            }
            if (Player1.Contains(25))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                MartinAveLbl.Location = tile1;
                MartinAveLbl.Visible = true;
            }
            if (Player1.Contains(26))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                RR3Lbl.Location = tile1;
                RR3Lbl.Visible = true;
            }
            if (Player1.Contains(27))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                AtlanAveLbl.Location = tile1;
                AtlanAveLbl.Visible = true;
            }
            if (Player1.Contains(28))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                VentAveLbl.Location = tile1;
                VentAveLbl.Visible = true;
            }
            if (Player1.Contains(30))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                MartinAveLbl.Location = tile1;
                MartinAveLbl.Visible = true;
            }
            if (Player1.Contains(32))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                PacAveLbl.Location = tile1;
                PacAveLbl.Visible = true;
            }
            if (Player1.Contains(33))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                NorthAveLbl.Location = tile1;
                NorthAveLbl.Visible = true;
            }
            if (Player1.Contains(35))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                PennAveLbl.Location = tile1;
                PennAveLbl.Visible = true;
            }
            if (Player1.Contains(36))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                RR4Lbl.Location = tile1;
                RR4Lbl.Visible = true;
            }
            if (Player1.Contains(38))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                ParkPlaceLbl.Location = tile1;
                ParkPlaceLbl.Visible = true;
            }
            if (Player1.Contains(40))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                BoardWalkLbl.Location = tile1;
                BoardWalkLbl.Visible = true;
            }
        }

        public void selectPlayer2()
        {
            if (Player2.Contains(2))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                MeditAveLbl.Location = tile1;
                MeditAveLbl.Visible = true;
            }
            if (Player2.Contains(4))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                BaltAveLbl.Location = tile1;
                BaltAveLbl.Visible = true;
            }
            if (Player2.Contains(6))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                RR1Lbl.Location = tile1;
                RR1Lbl.Visible = true;
            }
            if (Player2.Contains(7))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                OriAveLbl.Location = tile1;
                OriAveLbl.Visible = true;
            }
            if (Player2.Contains(9))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                VermAveLbl.Location = tile1;
                VermAveLbl.Visible = true;
            }
            if (Player2.Contains(10))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                ConAveLbl.Location = tile1;
                ConAveLbl.Visible = true;
            }
            if (Player2.Contains(12))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                CharAveLbl.Location = tile1;
                CharAveLbl.Visible = true;
            }
            if (Player2.Contains(14))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                StateAveLbl.Location = tile1;
                StateAveLbl.Visible = true;
            }
            if (Player2.Contains(15))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                VirgAveLbl.Location = tile1;
                VirgAveLbl.Visible = true;
            }
            if (Player2.Contains(16))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                RR2Lbl.Location = tile1;
                RR2Lbl.Visible = true;
            }
            if (Player2.Contains(17))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                JamesAveLbl.Location = tile1;
                JamesAveLbl.Visible = true;
            }
            if (Player2.Contains(19))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                TenAveLbl.Location = tile1;
                TenAveLbl.Visible = true;
            }
            if (Player2.Contains(20))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                NYAveLbl.Location = tile1;
                NYAveLbl.Visible = true;
            }
            if (Player2.Contains(22))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                KentAveLbl.Location = tile1;
                KentAveLbl.Visible = true;
            }
            if (Player2.Contains(24))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                IndiAveLbl.Location = tile1;
                IndiAveLbl.Visible = true;
            }
            if (Player2.Contains(25))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                MartinAveLbl.Location = tile1;
                MartinAveLbl.Visible = true;
            }
            if (Player2.Contains(26))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                RR3Lbl.Location = tile1;
                RR3Lbl.Visible = true;
            }
            if (Player2.Contains(27))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                AtlanAveLbl.Location = tile1;
                AtlanAveLbl.Visible = true;
            }
            if (Player2.Contains(28))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                VentAveLbl.Location = tile1;
                VentAveLbl.Visible = true;
            }
            if (Player2.Contains(30))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                MartinAveLbl.Location = tile1;
                MartinAveLbl.Visible = true;
            }
            if (Player2.Contains(32))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                PacAveLbl.Location = tile1;
                PacAveLbl.Visible = true;
            }
            if (Player2.Contains(33))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                NorthAveLbl.Location = tile1;
                NorthAveLbl.Visible = true;
            }
            if (Player2.Contains(35))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                PennAveLbl.Location = tile1;
                PennAveLbl.Visible = true;
            }
            if (Player2.Contains(36))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                RR4Lbl.Location = tile1;
                RR4Lbl.Visible = true;
            }
            if (Player2.Contains(38))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                ParkPlaceLbl.Location = tile1;
                ParkPlaceLbl.Visible = true;
            }
            if (Player2.Contains(40))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                BoardWalkLbl.Location = tile1;
                BoardWalkLbl.Visible = true;
            }
        }
        public void selectPlayer3()
        {
            if (Player3.Contains(2))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                MeditAveLbl.Location = tile1;
                MeditAveLbl.Visible = true;
            }
            if (Player3.Contains(4))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                BaltAveLbl.Location = tile1;
                BaltAveLbl.Visible = true;
            }
            if (Player3.Contains(6))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                RR1Lbl.Location = tile1;
                RR1Lbl.Visible = true;
            }
            if (Player3.Contains(7))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                OriAveLbl.Location = tile1;
                OriAveLbl.Visible = true;
            }
            if (Player3.Contains(9))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                VermAveLbl.Location = tile1;
                VermAveLbl.Visible = true;
            }
            if (Player3.Contains(10))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                ConAveLbl.Location = tile1;
                ConAveLbl.Visible = true;
            }
            if (Player3.Contains(12))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                CharAveLbl.Location = tile1;
                CharAveLbl.Visible = true;
            }
            if (Player3.Contains(14))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                StateAveLbl.Location = tile1;
                StateAveLbl.Visible = true;
            }
            if (Player3.Contains(15))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                VirgAveLbl.Location = tile1;
                VirgAveLbl.Visible = true;
            }
            if (Player3.Contains(16))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                RR2Lbl.Location = tile1;
                RR2Lbl.Visible = true;
            }
            if (Player3.Contains(17))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                JamesAveLbl.Location = tile1;
                JamesAveLbl.Visible = true;
            }
            if (Player3.Contains(19))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                TenAveLbl.Location = tile1;
                TenAveLbl.Visible = true;
            }
            if (Player3.Contains(20))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                NYAveLbl.Location = tile1;
                NYAveLbl.Visible = true;
            }
            if (Player3.Contains(22))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                KentAveLbl.Location = tile1;
                KentAveLbl.Visible = true;
            }
            if (Player3.Contains(24))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                IndiAveLbl.Location = tile1;
                IndiAveLbl.Visible = true;
            }
            if (Player3.Contains(25))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                MartinAveLbl.Location = tile1;
                MartinAveLbl.Visible = true;
            }
            if (Player3.Contains(26))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                RR3Lbl.Location = tile1;
                RR3Lbl.Visible = true;
            }
            if (Player3.Contains(27))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                AtlanAveLbl.Location = tile1;
                AtlanAveLbl.Visible = true;
            }
            if (Player3.Contains(28))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                VentAveLbl.Location = tile1;
                VentAveLbl.Visible = true;
            }
            if (Player3.Contains(30))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                MartinAveLbl.Location = tile1;
                MartinAveLbl.Visible = true;
            }
            if (Player3.Contains(32))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                PacAveLbl.Location = tile1;
                PacAveLbl.Visible = true;
            }
            if (Player3.Contains(33))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                NorthAveLbl.Location = tile1;
                NorthAveLbl.Visible = true;
            }
            if (Player3.Contains(35))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                PennAveLbl.Location = tile1;
                PennAveLbl.Visible = true;
            }
            if (Player3.Contains(36))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                RR4Lbl.Location = tile1;
                RR4Lbl.Visible = true;
            }
            if (Player3.Contains(38))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                ParkPlaceLbl.Location = tile1;
                ParkPlaceLbl.Visible = true;
            }
            if (Player3.Contains(40))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                BoardWalkLbl.Location = tile1;
                BoardWalkLbl.Visible = true;
            }
        }

        public void selectPlayer4()
        {
            if (Player4.Contains(2))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                MeditAveLbl.Location = tile1;
                MeditAveLbl.Visible = true;
            }
            if (Player4.Contains(4))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                BaltAveLbl.Location = tile1;
                BaltAveLbl.Visible = true;
            }
            if (Player4.Contains(6))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                RR1Lbl.Location = tile1;
                RR1Lbl.Visible = true;
            }
            if (Player4.Contains(7))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                OriAveLbl.Location = tile1;
                OriAveLbl.Visible = true;
            }
            if (Player4.Contains(9))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                VermAveLbl.Location = tile1;
                VermAveLbl.Visible = true;
            }
            if (Player4.Contains(10))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                ConAveLbl.Location = tile1;
                ConAveLbl.Visible = true;
            }
            if (Player4.Contains(12))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                CharAveLbl.Location = tile1;
                CharAveLbl.Visible = true;
            }
            if (Player4.Contains(14))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                StateAveLbl.Location = tile1;
                StateAveLbl.Visible = true;
            }
            if (Player4.Contains(15))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                VirgAveLbl.Location = tile1;
                VirgAveLbl.Visible = true;
            }
            if (Player4.Contains(16))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                RR2Lbl.Location = tile1;
                RR2Lbl.Visible = true;
            }
            if (Player4.Contains(17))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                JamesAveLbl.Location = tile1;
                JamesAveLbl.Visible = true;
            }
            if (Player4.Contains(19))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                TenAveLbl.Location = tile1;
                TenAveLbl.Visible = true;
            }
            if (Player4.Contains(20))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                NYAveLbl.Location = tile1;
                NYAveLbl.Visible = true;
            }
            if (Player4.Contains(22))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                KentAveLbl.Location = tile1;
                KentAveLbl.Visible = true;
            }
            if (Player4.Contains(24))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                IndiAveLbl.Location = tile1;
                IndiAveLbl.Visible = true;
            }
            if (Player4.Contains(25))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                MartinAveLbl.Location = tile1;
                MartinAveLbl.Visible = true;
            }
            if (Player4.Contains(26))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                RR3Lbl.Location = tile1;
                RR3Lbl.Visible = true;
            }
            if (Player4.Contains(27))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                AtlanAveLbl.Location = tile1;
                AtlanAveLbl.Visible = true;
            }
            if (Player4.Contains(28))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                VentAveLbl.Location = tile1;
                VentAveLbl.Visible = true;
            }
            if (Player4.Contains(30))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                MartinAveLbl.Location = tile1;
                MartinAveLbl.Visible = true;
            }
            if (Player4.Contains(32))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                PacAveLbl.Location = tile1;
                PacAveLbl.Visible = true;
            }
            if (Player4.Contains(33))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                NorthAveLbl.Location = tile1;
                NorthAveLbl.Visible = true;
            }
            if (Player4.Contains(35))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                PennAveLbl.Location = tile1;
                PennAveLbl.Visible = true;
            }
            if (Player4.Contains(36))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                RR4Lbl.Location = tile1;
                RR4Lbl.Visible = true;
            }
            if (Player4.Contains(38))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                ParkPlaceLbl.Location = tile1;
                ParkPlaceLbl.Visible = true;
            }
            if (Player4.Contains(40))
            {
                Point tile1 = new Point(player2x, player2y);
                player2y += 13;
                BoardWalkLbl.Location = tile1;
                BoardWalkLbl.Visible = true;
            }
        }

        private void tradePlayer1_Click(object sender, EventArgs e)
        {
            selectedPlayer = 1;
            tradePlayer1.Visible = false;
            tradePlayer2.Visible = false;
            tradePlayer3.Visible = false;
            tradePlayer4.Visible = false;
            yourProps.Visible = true;
            thereProps.Visible = true;
            yourOffer.Visible = true;
            thereOffer.Visible = true;
            tradeAcc.Visible = true;
            selectPlayer1();
            switch (turn)
            {
                case 1:
                    if (Player1.Contains(2))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MeditAveLbl.Location = tile1;
                        MeditAveLbl.Visible = true;
                    }
                    if (Player1.Contains(4))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BaltAveLbl.Location = tile1;
                        BaltAveLbl.Visible = true;
                    }
                    if (Player1.Contains(6))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR1Lbl.Location = tile1;
                        RR1Lbl.Visible = true;
                    }
                    if (Player1.Contains(7))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        OriAveLbl.Location = tile1;
                        OriAveLbl.Visible = true;
                    }
                    if (Player1.Contains(9))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VermAveLbl.Location = tile1;
                        VermAveLbl.Visible = true;
                    }
                    if (Player1.Contains(10))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ConAveLbl.Location = tile1;
                        ConAveLbl.Visible = true;
                    }
                    if (Player1.Contains(12))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        CharAveLbl.Location = tile1;
                        CharAveLbl.Visible = true;
                    }
                    if (Player1.Contains(14))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        StateAveLbl.Location = tile1;
                        StateAveLbl.Visible = true;
                    }
                    if (Player1.Contains(15))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VirgAveLbl.Location = tile1;
                        VirgAveLbl.Visible = true;
                    }
                    if (Player1.Contains(16))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR2Lbl.Location = tile1;
                        RR2Lbl.Visible = true;
                    }
                    if (Player1.Contains(17))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        JamesAveLbl.Location = tile1;
                        JamesAveLbl.Visible = true;
                    }
                    if (Player1.Contains(19))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        TenAveLbl.Location = tile1;
                        TenAveLbl.Visible = true;
                    }
                    if (Player1.Contains(20))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NYAveLbl.Location = tile1;
                        NYAveLbl.Visible = true;
                    }
                    if (Player1.Contains(22))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        KentAveLbl.Location = tile1;
                        KentAveLbl.Visible = true;
                    }
                    if (Player1.Contains(24))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        IndiAveLbl.Location = tile1;
                        IndiAveLbl.Visible = true;
                    }
                    if (Player1.Contains(25))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player1.Contains(26))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR3Lbl.Location = tile1;
                        RR3Lbl.Visible = true;
                    }
                    if (Player1.Contains(27))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        AtlanAveLbl.Location = tile1;
                        AtlanAveLbl.Visible = true;
                    }
                    if (Player1.Contains(28))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VentAveLbl.Location = tile1;
                        VentAveLbl.Visible = true;
                    }
                    if (Player1.Contains(30))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player1.Contains(32))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PacAveLbl.Location = tile1;
                        PacAveLbl.Visible = true;
                    }
                    if (Player1.Contains(33))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NorthAveLbl.Location = tile1;
                        NorthAveLbl.Visible = true;
                    }
                    if (Player1.Contains(35))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PennAveLbl.Location = tile1;
                        PennAveLbl.Visible = true;
                    }
                    if (Player1.Contains(36))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR4Lbl.Location = tile1;
                        RR4Lbl.Visible = true;
                    }
                    if (Player1.Contains(38))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ParkPlaceLbl.Location = tile1;
                        ParkPlaceLbl.Visible = true;
                    }
                    if (Player1.Contains(40))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BoardWalkLbl.Location = tile1;
                        BoardWalkLbl.Visible = true;
                    }
                    
                    break;
                case 2:
                    if (Player2.Contains(2))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MeditAveLbl.Location = tile1;
                        MeditAveLbl.Visible = true;
                    }
                    if (Player2.Contains(4))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BaltAveLbl.Location = tile1;
                        BaltAveLbl.Visible = true;
                    }
                    if (Player2.Contains(6))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR1Lbl.Location = tile1;
                        RR1Lbl.Visible = true;
                    }
                    if (Player2.Contains(7))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        OriAveLbl.Location = tile1;
                        OriAveLbl.Visible = true;
                    }
                    if (Player2.Contains(9))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VermAveLbl.Location = tile1;
                        VermAveLbl.Visible = true;
                    }
                    if (Player2.Contains(10))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ConAveLbl.Location = tile1;
                        ConAveLbl.Visible = true;
                    }
                    if (Player2.Contains(12))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        CharAveLbl.Location = tile1;
                        CharAveLbl.Visible = true;
                    }
                    if (Player2.Contains(14))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        StateAveLbl.Location = tile1;
                        StateAveLbl.Visible = true;
                    }
                    if (Player2.Contains(15))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VirgAveLbl.Location = tile1;
                        VirgAveLbl.Visible = true;
                    }
                    if (Player2.Contains(16))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR2Lbl.Location = tile1;
                        RR2Lbl.Visible = true;
                    }
                    if (Player2.Contains(17))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        JamesAveLbl.Location = tile1;
                        JamesAveLbl.Visible = true;
                    }
                    if (Player2.Contains(19))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        TenAveLbl.Location = tile1;
                        TenAveLbl.Visible = true;
                    }
                    if (Player2.Contains(20))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NYAveLbl.Location = tile1;
                        NYAveLbl.Visible = true;
                    }
                    if (Player2.Contains(22))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        KentAveLbl.Location = tile1;
                        KentAveLbl.Visible = true;
                    }
                    if (Player2.Contains(24))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        IndiAveLbl.Location = tile1;
                        IndiAveLbl.Visible = true;
                    }
                    if (Player2.Contains(25))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player2.Contains(26))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR3Lbl.Location = tile1;
                        RR3Lbl.Visible = true;
                    }
                    if (Player2.Contains(27))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        AtlanAveLbl.Location = tile1;
                        AtlanAveLbl.Visible = true;
                    }
                    if (Player2.Contains(28))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VentAveLbl.Location = tile1;
                        VentAveLbl.Visible = true;
                    }
                    if (Player2.Contains(30))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player2.Contains(32))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PacAveLbl.Location = tile1;
                        PacAveLbl.Visible = true;
                    }
                    if (Player2.Contains(33))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NorthAveLbl.Location = tile1;
                        NorthAveLbl.Visible = true;
                    }
                    if (Player2.Contains(35))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PennAveLbl.Location = tile1;
                        PennAveLbl.Visible = true;
                    }
                    if (Player2.Contains(36))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR4Lbl.Location = tile1;
                        RR4Lbl.Visible = true;
                    }
                    if (Player2.Contains(38))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ParkPlaceLbl.Location = tile1;
                        ParkPlaceLbl.Visible = true;
                    }
                    if (Player2.Contains(40))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BoardWalkLbl.Location = tile1;
                        BoardWalkLbl.Visible = true;
                    }

                    break;
                case 3:
                    if (Player3.Contains(2))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MeditAveLbl.Location = tile1;
                        MeditAveLbl.Visible = true;
                    }
                    if (Player3.Contains(4))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BaltAveLbl.Location = tile1;
                        BaltAveLbl.Visible = true;
                    }
                    if (Player3.Contains(6))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR1Lbl.Location = tile1;
                        RR1Lbl.Visible = true;
                    }
                    if (Player3.Contains(7))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        OriAveLbl.Location = tile1;
                        OriAveLbl.Visible = true;
                    }
                    if (Player3.Contains(9))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VermAveLbl.Location = tile1;
                        VermAveLbl.Visible = true;
                    }
                    if (Player3.Contains(10))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ConAveLbl.Location = tile1;
                        ConAveLbl.Visible = true;
                    }
                    if (Player3.Contains(12))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        CharAveLbl.Location = tile1;
                        CharAveLbl.Visible = true;
                    }
                    if (Player3.Contains(14))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        StateAveLbl.Location = tile1;
                        StateAveLbl.Visible = true;
                    }
                    if (Player3.Contains(15))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VirgAveLbl.Location = tile1;
                        VirgAveLbl.Visible = true;
                    }
                    if (Player3.Contains(16))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR2Lbl.Location = tile1;
                        RR2Lbl.Visible = true;
                    }
                    if (Player3.Contains(17))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        JamesAveLbl.Location = tile1;
                        JamesAveLbl.Visible = true;
                    }
                    if (Player3.Contains(19))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        TenAveLbl.Location = tile1;
                        TenAveLbl.Visible = true;
                    }
                    if (Player3.Contains(20))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NYAveLbl.Location = tile1;
                        NYAveLbl.Visible = true;
                    }
                    if (Player3.Contains(22))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        KentAveLbl.Location = tile1;
                        KentAveLbl.Visible = true;
                    }
                    if (Player3.Contains(24))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        IndiAveLbl.Location = tile1;
                        IndiAveLbl.Visible = true;
                    }
                    if (Player3.Contains(25))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player3.Contains(26))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR3Lbl.Location = tile1;
                        RR3Lbl.Visible = true;
                    }
                    if (Player3.Contains(27))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        AtlanAveLbl.Location = tile1;
                        AtlanAveLbl.Visible = true;
                    }
                    if (Player3.Contains(28))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VentAveLbl.Location = tile1;
                        VentAveLbl.Visible = true;
                    }
                    if (Player3.Contains(30))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player3.Contains(32))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PacAveLbl.Location = tile1;
                        PacAveLbl.Visible = true;
                    }
                    if (Player3.Contains(33))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NorthAveLbl.Location = tile1;
                        NorthAveLbl.Visible = true;
                    }
                    if (Player3.Contains(35))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PennAveLbl.Location = tile1;
                        PennAveLbl.Visible = true;
                    }
                    if (Player3.Contains(36))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR4Lbl.Location = tile1;
                        RR4Lbl.Visible = true;
                    }
                    if (Player3.Contains(38))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ParkPlaceLbl.Location = tile1;
                        ParkPlaceLbl.Visible = true;
                    }
                    if (Player3.Contains(40))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BoardWalkLbl.Location = tile1;
                        BoardWalkLbl.Visible = true;
                    }

                    break;
                case 4:
                    if (Player4.Contains(2))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MeditAveLbl.Location = tile1;
                        MeditAveLbl.Visible = true;
                    }
                    if (Player4.Contains(4))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BaltAveLbl.Location = tile1;
                        BaltAveLbl.Visible = true;
                    }
                    if (Player4.Contains(6))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR1Lbl.Location = tile1;
                        RR1Lbl.Visible = true;
                    }
                    if (Player4.Contains(7))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        OriAveLbl.Location = tile1;
                        OriAveLbl.Visible = true;
                    }
                    if (Player4.Contains(9))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VermAveLbl.Location = tile1;
                        VermAveLbl.Visible = true;
                    }
                    if (Player4.Contains(10))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ConAveLbl.Location = tile1;
                        ConAveLbl.Visible = true;
                    }
                    if (Player4.Contains(12))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        CharAveLbl.Location = tile1;
                        CharAveLbl.Visible = true;
                    }
                    if (Player4.Contains(14))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        StateAveLbl.Location = tile1;
                        StateAveLbl.Visible = true;
                    }
                    if (Player4.Contains(15))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VirgAveLbl.Location = tile1;
                        VirgAveLbl.Visible = true;
                    }
                    if (Player4.Contains(16))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR2Lbl.Location = tile1;
                        RR2Lbl.Visible = true;
                    }
                    if (Player4.Contains(17))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        JamesAveLbl.Location = tile1;
                        JamesAveLbl.Visible = true;
                    }
                    if (Player4.Contains(19))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        TenAveLbl.Location = tile1;
                        TenAveLbl.Visible = true;
                    }
                    if (Player4.Contains(20))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NYAveLbl.Location = tile1;
                        NYAveLbl.Visible = true;
                    }
                    if (Player4.Contains(22))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        KentAveLbl.Location = tile1;
                        KentAveLbl.Visible = true;
                    }
                    if (Player4.Contains(24))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        IndiAveLbl.Location = tile1;
                        IndiAveLbl.Visible = true;
                    }
                    if (Player4.Contains(25))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player4.Contains(26))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR3Lbl.Location = tile1;
                        RR3Lbl.Visible = true;
                    }
                    if (Player4.Contains(27))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        AtlanAveLbl.Location = tile1;
                        AtlanAveLbl.Visible = true;
                    }
                    if (Player4.Contains(28))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VentAveLbl.Location = tile1;
                        VentAveLbl.Visible = true;
                    }
                    if (Player4.Contains(30))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player4.Contains(32))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PacAveLbl.Location = tile1;
                        PacAveLbl.Visible = true;
                    }
                    if (Player4.Contains(33))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NorthAveLbl.Location = tile1;
                        NorthAveLbl.Visible = true;
                    }
                    if (Player4.Contains(35))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PennAveLbl.Location = tile1;
                        PennAveLbl.Visible = true;
                    }
                    if (Player4.Contains(36))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR4Lbl.Location = tile1;
                        RR4Lbl.Visible = true;
                    }
                    if (Player4.Contains(38))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ParkPlaceLbl.Location = tile1;
                        ParkPlaceLbl.Visible = true;
                    }
                    if (Player4.Contains(40))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BoardWalkLbl.Location = tile1;
                        BoardWalkLbl.Visible = true;
                    }

                    break;
            }
        }

        private void tradePlayer2_Click(object sender, EventArgs e)
        {
            selectedPlayer = 2;
            tradePlayer1.Visible = false;
            tradePlayer2.Visible = false;
            tradePlayer3.Visible = false;
            tradePlayer4.Visible = false;
            yourProps.Visible = true;
            thereProps.Visible = true;
            yourOffer.Visible = true;
            thereOffer.Visible = true;
            tradeAcc.Visible = true;
            selectPlayer2();
            switch (turn)
            {
                case 1:
                    if (Player1.Contains(2))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MeditAveLbl.Location = tile1;
                        MeditAveLbl.Visible = true;
                    }
                    if (Player1.Contains(4))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BaltAveLbl.Location = tile1;
                        BaltAveLbl.Visible = true;
                    }
                    if (Player1.Contains(6))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR1Lbl.Location = tile1;
                        RR1Lbl.Visible = true;
                    }
                    if (Player1.Contains(7))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        OriAveLbl.Location = tile1;
                        OriAveLbl.Visible = true;
                    }
                    if (Player1.Contains(9))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VermAveLbl.Location = tile1;
                        VermAveLbl.Visible = true;
                    }
                    if (Player1.Contains(10))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ConAveLbl.Location = tile1;
                        ConAveLbl.Visible = true;
                    }
                    if (Player1.Contains(12))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        CharAveLbl.Location = tile1;
                        CharAveLbl.Visible = true;
                    }
                    if (Player1.Contains(14))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        StateAveLbl.Location = tile1;
                        StateAveLbl.Visible = true;
                    }
                    if (Player1.Contains(15))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VirgAveLbl.Location = tile1;
                        VirgAveLbl.Visible = true;
                    }
                    if (Player1.Contains(16))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR2Lbl.Location = tile1;
                        RR2Lbl.Visible = true;
                    }
                    if (Player1.Contains(17))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        JamesAveLbl.Location = tile1;
                        JamesAveLbl.Visible = true;
                    }
                    if (Player1.Contains(19))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        TenAveLbl.Location = tile1;
                        TenAveLbl.Visible = true;
                    }
                    if (Player1.Contains(20))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NYAveLbl.Location = tile1;
                        NYAveLbl.Visible = true;
                    }
                    if (Player1.Contains(22))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        KentAveLbl.Location = tile1;
                        KentAveLbl.Visible = true;
                    }
                    if (Player1.Contains(24))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        IndiAveLbl.Location = tile1;
                        IndiAveLbl.Visible = true;
                    }
                    if (Player1.Contains(25))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player1.Contains(26))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR3Lbl.Location = tile1;
                        RR3Lbl.Visible = true;
                    }
                    if (Player1.Contains(27))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        AtlanAveLbl.Location = tile1;
                        AtlanAveLbl.Visible = true;
                    }
                    if (Player1.Contains(28))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VentAveLbl.Location = tile1;
                        VentAveLbl.Visible = true;
                    }
                    if (Player1.Contains(30))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player1.Contains(32))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PacAveLbl.Location = tile1;
                        PacAveLbl.Visible = true;
                    }
                    if (Player1.Contains(33))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NorthAveLbl.Location = tile1;
                        NorthAveLbl.Visible = true;
                    }
                    if (Player1.Contains(35))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PennAveLbl.Location = tile1;
                        PennAveLbl.Visible = true;
                    }
                    if (Player1.Contains(36))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR4Lbl.Location = tile1;
                        RR4Lbl.Visible = true;
                    }
                    if (Player1.Contains(38))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ParkPlaceLbl.Location = tile1;
                        ParkPlaceLbl.Visible = true;
                    }
                    if (Player1.Contains(40))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BoardWalkLbl.Location = tile1;
                        BoardWalkLbl.Visible = true;
                    }

                    break;
                case 2:
                    if (Player2.Contains(2))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MeditAveLbl.Location = tile1;
                        MeditAveLbl.Visible = true;
                    }
                    if (Player2.Contains(4))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BaltAveLbl.Location = tile1;
                        BaltAveLbl.Visible = true;
                    }
                    if (Player2.Contains(6))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR1Lbl.Location = tile1;
                        RR1Lbl.Visible = true;
                    }
                    if (Player2.Contains(7))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        OriAveLbl.Location = tile1;
                        OriAveLbl.Visible = true;
                    }
                    if (Player2.Contains(9))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VermAveLbl.Location = tile1;
                        VermAveLbl.Visible = true;
                    }
                    if (Player2.Contains(10))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ConAveLbl.Location = tile1;
                        ConAveLbl.Visible = true;
                    }
                    if (Player2.Contains(12))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        CharAveLbl.Location = tile1;
                        CharAveLbl.Visible = true;
                    }
                    if (Player2.Contains(14))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        StateAveLbl.Location = tile1;
                        StateAveLbl.Visible = true;
                    }
                    if (Player2.Contains(15))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VirgAveLbl.Location = tile1;
                        VirgAveLbl.Visible = true;
                    }
                    if (Player2.Contains(16))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR2Lbl.Location = tile1;
                        RR2Lbl.Visible = true;
                    }
                    if (Player2.Contains(17))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        JamesAveLbl.Location = tile1;
                        JamesAveLbl.Visible = true;
                    }
                    if (Player2.Contains(19))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        TenAveLbl.Location = tile1;
                        TenAveLbl.Visible = true;
                    }
                    if (Player2.Contains(20))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NYAveLbl.Location = tile1;
                        NYAveLbl.Visible = true;
                    }
                    if (Player2.Contains(22))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        KentAveLbl.Location = tile1;
                        KentAveLbl.Visible = true;
                    }
                    if (Player2.Contains(24))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        IndiAveLbl.Location = tile1;
                        IndiAveLbl.Visible = true;
                    }
                    if (Player2.Contains(25))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player2.Contains(26))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR3Lbl.Location = tile1;
                        RR3Lbl.Visible = true;
                    }
                    if (Player2.Contains(27))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        AtlanAveLbl.Location = tile1;
                        AtlanAveLbl.Visible = true;
                    }
                    if (Player2.Contains(28))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VentAveLbl.Location = tile1;
                        VentAveLbl.Visible = true;
                    }
                    if (Player2.Contains(30))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player2.Contains(32))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PacAveLbl.Location = tile1;
                        PacAveLbl.Visible = true;
                    }
                    if (Player2.Contains(33))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NorthAveLbl.Location = tile1;
                        NorthAveLbl.Visible = true;
                    }
                    if (Player2.Contains(35))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PennAveLbl.Location = tile1;
                        PennAveLbl.Visible = true;
                    }
                    if (Player2.Contains(36))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR4Lbl.Location = tile1;
                        RR4Lbl.Visible = true;
                    }
                    if (Player2.Contains(38))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ParkPlaceLbl.Location = tile1;
                        ParkPlaceLbl.Visible = true;
                    }
                    if (Player2.Contains(40))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BoardWalkLbl.Location = tile1;
                        BoardWalkLbl.Visible = true;
                    }

                    break;
                case 3:
                    if (Player3.Contains(2))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MeditAveLbl.Location = tile1;
                        MeditAveLbl.Visible = true;
                    }
                    if (Player3.Contains(4))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BaltAveLbl.Location = tile1;
                        BaltAveLbl.Visible = true;
                    }
                    if (Player3.Contains(6))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR1Lbl.Location = tile1;
                        RR1Lbl.Visible = true;
                    }
                    if (Player3.Contains(7))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        OriAveLbl.Location = tile1;
                        OriAveLbl.Visible = true;
                    }
                    if (Player3.Contains(9))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VermAveLbl.Location = tile1;
                        VermAveLbl.Visible = true;
                    }
                    if (Player3.Contains(10))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ConAveLbl.Location = tile1;
                        ConAveLbl.Visible = true;
                    }
                    if (Player3.Contains(12))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        CharAveLbl.Location = tile1;
                        CharAveLbl.Visible = true;
                    }
                    if (Player3.Contains(14))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        StateAveLbl.Location = tile1;
                        StateAveLbl.Visible = true;
                    }
                    if (Player3.Contains(15))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VirgAveLbl.Location = tile1;
                        VirgAveLbl.Visible = true;
                    }
                    if (Player3.Contains(16))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR2Lbl.Location = tile1;
                        RR2Lbl.Visible = true;
                    }
                    if (Player3.Contains(17))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        JamesAveLbl.Location = tile1;
                        JamesAveLbl.Visible = true;
                    }
                    if (Player3.Contains(19))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        TenAveLbl.Location = tile1;
                        TenAveLbl.Visible = true;
                    }
                    if (Player3.Contains(20))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NYAveLbl.Location = tile1;
                        NYAveLbl.Visible = true;
                    }
                    if (Player3.Contains(22))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        KentAveLbl.Location = tile1;
                        KentAveLbl.Visible = true;
                    }
                    if (Player3.Contains(24))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        IndiAveLbl.Location = tile1;
                        IndiAveLbl.Visible = true;
                    }
                    if (Player3.Contains(25))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player3.Contains(26))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR3Lbl.Location = tile1;
                        RR3Lbl.Visible = true;
                    }
                    if (Player3.Contains(27))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        AtlanAveLbl.Location = tile1;
                        AtlanAveLbl.Visible = true;
                    }
                    if (Player3.Contains(28))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VentAveLbl.Location = tile1;
                        VentAveLbl.Visible = true;
                    }
                    if (Player3.Contains(30))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player3.Contains(32))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PacAveLbl.Location = tile1;
                        PacAveLbl.Visible = true;
                    }
                    if (Player3.Contains(33))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NorthAveLbl.Location = tile1;
                        NorthAveLbl.Visible = true;
                    }
                    if (Player3.Contains(35))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PennAveLbl.Location = tile1;
                        PennAveLbl.Visible = true;
                    }
                    if (Player3.Contains(36))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR4Lbl.Location = tile1;
                        RR4Lbl.Visible = true;
                    }
                    if (Player3.Contains(38))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ParkPlaceLbl.Location = tile1;
                        ParkPlaceLbl.Visible = true;
                    }
                    if (Player3.Contains(40))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BoardWalkLbl.Location = tile1;
                        BoardWalkLbl.Visible = true;
                    }

                    break;
                case 4:
                    if (Player4.Contains(2))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MeditAveLbl.Location = tile1;
                        MeditAveLbl.Visible = true;
                    }
                    if (Player4.Contains(4))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BaltAveLbl.Location = tile1;
                        BaltAveLbl.Visible = true;
                    }
                    if (Player4.Contains(6))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR1Lbl.Location = tile1;
                        RR1Lbl.Visible = true;
                    }
                    if (Player4.Contains(7))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        OriAveLbl.Location = tile1;
                        OriAveLbl.Visible = true;
                    }
                    if (Player4.Contains(9))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VermAveLbl.Location = tile1;
                        VermAveLbl.Visible = true;
                    }
                    if (Player4.Contains(10))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ConAveLbl.Location = tile1;
                        ConAveLbl.Visible = true;
                    }
                    if (Player4.Contains(12))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        CharAveLbl.Location = tile1;
                        CharAveLbl.Visible = true;
                    }
                    if (Player4.Contains(14))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        StateAveLbl.Location = tile1;
                        StateAveLbl.Visible = true;
                    }
                    if (Player4.Contains(15))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VirgAveLbl.Location = tile1;
                        VirgAveLbl.Visible = true;
                    }
                    if (Player4.Contains(16))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR2Lbl.Location = tile1;
                        RR2Lbl.Visible = true;
                    }
                    if (Player4.Contains(17))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        JamesAveLbl.Location = tile1;
                        JamesAveLbl.Visible = true;
                    }
                    if (Player4.Contains(19))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        TenAveLbl.Location = tile1;
                        TenAveLbl.Visible = true;
                    }
                    if (Player4.Contains(20))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NYAveLbl.Location = tile1;
                        NYAveLbl.Visible = true;
                    }
                    if (Player4.Contains(22))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        KentAveLbl.Location = tile1;
                        KentAveLbl.Visible = true;
                    }
                    if (Player4.Contains(24))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        IndiAveLbl.Location = tile1;
                        IndiAveLbl.Visible = true;
                    }
                    if (Player4.Contains(25))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player4.Contains(26))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR3Lbl.Location = tile1;
                        RR3Lbl.Visible = true;
                    }
                    if (Player4.Contains(27))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        AtlanAveLbl.Location = tile1;
                        AtlanAveLbl.Visible = true;
                    }
                    if (Player4.Contains(28))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VentAveLbl.Location = tile1;
                        VentAveLbl.Visible = true;
                    }
                    if (Player4.Contains(30))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player4.Contains(32))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PacAveLbl.Location = tile1;
                        PacAveLbl.Visible = true;
                    }
                    if (Player4.Contains(33))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NorthAveLbl.Location = tile1;
                        NorthAveLbl.Visible = true;
                    }
                    if (Player4.Contains(35))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PennAveLbl.Location = tile1;
                        PennAveLbl.Visible = true;
                    }
                    if (Player4.Contains(36))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR4Lbl.Location = tile1;
                        RR4Lbl.Visible = true;
                    }
                    if (Player4.Contains(38))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ParkPlaceLbl.Location = tile1;
                        ParkPlaceLbl.Visible = true;
                    }
                    if (Player4.Contains(40))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BoardWalkLbl.Location = tile1;
                        BoardWalkLbl.Visible = true;
                    }

                    break;
            }
        }

        private void tradePlayer3_Click(object sender, EventArgs e)
        {
            selectedPlayer = 3;
            tradePlayer1.Visible = false;
            tradePlayer2.Visible = false;
            tradePlayer3.Visible = false;
            tradePlayer4.Visible = false;
            yourProps.Visible = true;
            thereProps.Visible = true;
            yourOffer.Visible = true;
            thereOffer.Visible = true;
            tradeAcc.Visible = true;
            selectPlayer3();
            switch (turn)
            {
                case 1:
                    if (Player1.Contains(2))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MeditAveLbl.Location = tile1;
                        MeditAveLbl.Visible = true;
                    }
                    if (Player1.Contains(4))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BaltAveLbl.Location = tile1;
                        BaltAveLbl.Visible = true;
                    }
                    if (Player1.Contains(6))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR1Lbl.Location = tile1;
                        RR1Lbl.Visible = true;
                    }
                    if (Player1.Contains(7))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        OriAveLbl.Location = tile1;
                        OriAveLbl.Visible = true;
                    }
                    if (Player1.Contains(9))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VermAveLbl.Location = tile1;
                        VermAveLbl.Visible = true;
                    }
                    if (Player1.Contains(10))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ConAveLbl.Location = tile1;
                        ConAveLbl.Visible = true;
                    }
                    if (Player1.Contains(12))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        CharAveLbl.Location = tile1;
                        CharAveLbl.Visible = true;
                    }
                    if (Player1.Contains(14))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        StateAveLbl.Location = tile1;
                        StateAveLbl.Visible = true;
                    }
                    if (Player1.Contains(15))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VirgAveLbl.Location = tile1;
                        VirgAveLbl.Visible = true;
                    }
                    if (Player1.Contains(16))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR2Lbl.Location = tile1;
                        RR2Lbl.Visible = true;
                    }
                    if (Player1.Contains(17))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        JamesAveLbl.Location = tile1;
                        JamesAveLbl.Visible = true;
                    }
                    if (Player1.Contains(19))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        TenAveLbl.Location = tile1;
                        TenAveLbl.Visible = true;
                    }
                    if (Player1.Contains(20))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NYAveLbl.Location = tile1;
                        NYAveLbl.Visible = true;
                    }
                    if (Player1.Contains(22))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        KentAveLbl.Location = tile1;
                        KentAveLbl.Visible = true;
                    }
                    if (Player1.Contains(24))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        IndiAveLbl.Location = tile1;
                        IndiAveLbl.Visible = true;
                    }
                    if (Player1.Contains(25))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player1.Contains(26))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR3Lbl.Location = tile1;
                        RR3Lbl.Visible = true;
                    }
                    if (Player1.Contains(27))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        AtlanAveLbl.Location = tile1;
                        AtlanAveLbl.Visible = true;
                    }
                    if (Player1.Contains(28))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VentAveLbl.Location = tile1;
                        VentAveLbl.Visible = true;
                    }
                    if (Player1.Contains(30))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player1.Contains(32))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PacAveLbl.Location = tile1;
                        PacAveLbl.Visible = true;
                    }
                    if (Player1.Contains(33))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NorthAveLbl.Location = tile1;
                        NorthAveLbl.Visible = true;
                    }
                    if (Player1.Contains(35))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PennAveLbl.Location = tile1;
                        PennAveLbl.Visible = true;
                    }
                    if (Player1.Contains(36))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR4Lbl.Location = tile1;
                        RR4Lbl.Visible = true;
                    }
                    if (Player1.Contains(38))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ParkPlaceLbl.Location = tile1;
                        ParkPlaceLbl.Visible = true;
                    }
                    if (Player1.Contains(40))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BoardWalkLbl.Location = tile1;
                        BoardWalkLbl.Visible = true;
                    }

                    break;
                case 2:
                    if (Player2.Contains(2))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MeditAveLbl.Location = tile1;
                        MeditAveLbl.Visible = true;
                    }
                    if (Player2.Contains(4))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BaltAveLbl.Location = tile1;
                        BaltAveLbl.Visible = true;
                    }
                    if (Player2.Contains(6))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR1Lbl.Location = tile1;
                        RR1Lbl.Visible = true;
                    }
                    if (Player2.Contains(7))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        OriAveLbl.Location = tile1;
                        OriAveLbl.Visible = true;
                    }
                    if (Player2.Contains(9))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VermAveLbl.Location = tile1;
                        VermAveLbl.Visible = true;
                    }
                    if (Player2.Contains(10))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ConAveLbl.Location = tile1;
                        ConAveLbl.Visible = true;
                    }
                    if (Player2.Contains(12))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        CharAveLbl.Location = tile1;
                        CharAveLbl.Visible = true;
                    }
                    if (Player2.Contains(14))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        StateAveLbl.Location = tile1;
                        StateAveLbl.Visible = true;
                    }
                    if (Player2.Contains(15))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VirgAveLbl.Location = tile1;
                        VirgAveLbl.Visible = true;
                    }
                    if (Player2.Contains(16))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR2Lbl.Location = tile1;
                        RR2Lbl.Visible = true;
                    }
                    if (Player2.Contains(17))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        JamesAveLbl.Location = tile1;
                        JamesAveLbl.Visible = true;
                    }
                    if (Player2.Contains(19))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        TenAveLbl.Location = tile1;
                        TenAveLbl.Visible = true;
                    }
                    if (Player2.Contains(20))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NYAveLbl.Location = tile1;
                        NYAveLbl.Visible = true;
                    }
                    if (Player2.Contains(22))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        KentAveLbl.Location = tile1;
                        KentAveLbl.Visible = true;
                    }
                    if (Player2.Contains(24))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        IndiAveLbl.Location = tile1;
                        IndiAveLbl.Visible = true;
                    }
                    if (Player2.Contains(25))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player2.Contains(26))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR3Lbl.Location = tile1;
                        RR3Lbl.Visible = true;
                    }
                    if (Player2.Contains(27))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        AtlanAveLbl.Location = tile1;
                        AtlanAveLbl.Visible = true;
                    }
                    if (Player2.Contains(28))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VentAveLbl.Location = tile1;
                        VentAveLbl.Visible = true;
                    }
                    if (Player2.Contains(30))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player2.Contains(32))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PacAveLbl.Location = tile1;
                        PacAveLbl.Visible = true;
                    }
                    if (Player2.Contains(33))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NorthAveLbl.Location = tile1;
                        NorthAveLbl.Visible = true;
                    }
                    if (Player2.Contains(35))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PennAveLbl.Location = tile1;
                        PennAveLbl.Visible = true;
                    }
                    if (Player2.Contains(36))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR4Lbl.Location = tile1;
                        RR4Lbl.Visible = true;
                    }
                    if (Player2.Contains(38))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ParkPlaceLbl.Location = tile1;
                        ParkPlaceLbl.Visible = true;
                    }
                    if (Player2.Contains(40))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BoardWalkLbl.Location = tile1;
                        BoardWalkLbl.Visible = true;
                    }

                    break;
                case 3:
                    if (Player3.Contains(2))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MeditAveLbl.Location = tile1;
                        MeditAveLbl.Visible = true;
                    }
                    if (Player3.Contains(4))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BaltAveLbl.Location = tile1;
                        BaltAveLbl.Visible = true;
                    }
                    if (Player3.Contains(6))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR1Lbl.Location = tile1;
                        RR1Lbl.Visible = true;
                    }
                    if (Player3.Contains(7))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        OriAveLbl.Location = tile1;
                        OriAveLbl.Visible = true;
                    }
                    if (Player3.Contains(9))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VermAveLbl.Location = tile1;
                        VermAveLbl.Visible = true;
                    }
                    if (Player3.Contains(10))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ConAveLbl.Location = tile1;
                        ConAveLbl.Visible = true;
                    }
                    if (Player3.Contains(12))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        CharAveLbl.Location = tile1;
                        CharAveLbl.Visible = true;
                    }
                    if (Player3.Contains(14))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        StateAveLbl.Location = tile1;
                        StateAveLbl.Visible = true;
                    }
                    if (Player3.Contains(15))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VirgAveLbl.Location = tile1;
                        VirgAveLbl.Visible = true;
                    }
                    if (Player3.Contains(16))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR2Lbl.Location = tile1;
                        RR2Lbl.Visible = true;
                    }
                    if (Player3.Contains(17))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        JamesAveLbl.Location = tile1;
                        JamesAveLbl.Visible = true;
                    }
                    if (Player3.Contains(19))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        TenAveLbl.Location = tile1;
                        TenAveLbl.Visible = true;
                    }
                    if (Player3.Contains(20))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NYAveLbl.Location = tile1;
                        NYAveLbl.Visible = true;
                    }
                    if (Player3.Contains(22))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        KentAveLbl.Location = tile1;
                        KentAveLbl.Visible = true;
                    }
                    if (Player3.Contains(24))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        IndiAveLbl.Location = tile1;
                        IndiAveLbl.Visible = true;
                    }
                    if (Player3.Contains(25))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player3.Contains(26))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR3Lbl.Location = tile1;
                        RR3Lbl.Visible = true;
                    }
                    if (Player3.Contains(27))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        AtlanAveLbl.Location = tile1;
                        AtlanAveLbl.Visible = true;
                    }
                    if (Player3.Contains(28))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VentAveLbl.Location = tile1;
                        VentAveLbl.Visible = true;
                    }
                    if (Player3.Contains(30))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player3.Contains(32))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PacAveLbl.Location = tile1;
                        PacAveLbl.Visible = true;
                    }
                    if (Player3.Contains(33))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NorthAveLbl.Location = tile1;
                        NorthAveLbl.Visible = true;
                    }
                    if (Player3.Contains(35))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PennAveLbl.Location = tile1;
                        PennAveLbl.Visible = true;
                    }
                    if (Player3.Contains(36))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR4Lbl.Location = tile1;
                        RR4Lbl.Visible = true;
                    }
                    if (Player3.Contains(38))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ParkPlaceLbl.Location = tile1;
                        ParkPlaceLbl.Visible = true;
                    }
                    if (Player3.Contains(40))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BoardWalkLbl.Location = tile1;
                        BoardWalkLbl.Visible = true;
                    }

                    break;
                case 4:
                    if (Player4.Contains(2))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MeditAveLbl.Location = tile1;
                        MeditAveLbl.Visible = true;
                    }
                    if (Player4.Contains(4))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BaltAveLbl.Location = tile1;
                        BaltAveLbl.Visible = true;
                    }
                    if (Player4.Contains(6))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR1Lbl.Location = tile1;
                        RR1Lbl.Visible = true;
                    }
                    if (Player4.Contains(7))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        OriAveLbl.Location = tile1;
                        OriAveLbl.Visible = true;
                    }
                    if (Player4.Contains(9))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VermAveLbl.Location = tile1;
                        VermAveLbl.Visible = true;
                    }
                    if (Player4.Contains(10))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ConAveLbl.Location = tile1;
                        ConAveLbl.Visible = true;
                    }
                    if (Player4.Contains(12))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        CharAveLbl.Location = tile1;
                        CharAveLbl.Visible = true;
                    }
                    if (Player4.Contains(14))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        StateAveLbl.Location = tile1;
                        StateAveLbl.Visible = true;
                    }
                    if (Player4.Contains(15))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VirgAveLbl.Location = tile1;
                        VirgAveLbl.Visible = true;
                    }
                    if (Player4.Contains(16))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR2Lbl.Location = tile1;
                        RR2Lbl.Visible = true;
                    }
                    if (Player4.Contains(17))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        JamesAveLbl.Location = tile1;
                        JamesAveLbl.Visible = true;
                    }
                    if (Player4.Contains(19))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        TenAveLbl.Location = tile1;
                        TenAveLbl.Visible = true;
                    }
                    if (Player4.Contains(20))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NYAveLbl.Location = tile1;
                        NYAveLbl.Visible = true;
                    }
                    if (Player4.Contains(22))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        KentAveLbl.Location = tile1;
                        KentAveLbl.Visible = true;
                    }
                    if (Player4.Contains(24))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        IndiAveLbl.Location = tile1;
                        IndiAveLbl.Visible = true;
                    }
                    if (Player4.Contains(25))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player4.Contains(26))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR3Lbl.Location = tile1;
                        RR3Lbl.Visible = true;
                    }
                    if (Player4.Contains(27))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        AtlanAveLbl.Location = tile1;
                        AtlanAveLbl.Visible = true;
                    }
                    if (Player4.Contains(28))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VentAveLbl.Location = tile1;
                        VentAveLbl.Visible = true;
                    }
                    if (Player4.Contains(30))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player4.Contains(32))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PacAveLbl.Location = tile1;
                        PacAveLbl.Visible = true;
                    }
                    if (Player4.Contains(33))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NorthAveLbl.Location = tile1;
                        NorthAveLbl.Visible = true;
                    }
                    if (Player4.Contains(35))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PennAveLbl.Location = tile1;
                        PennAveLbl.Visible = true;
                    }
                    if (Player4.Contains(36))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR4Lbl.Location = tile1;
                        RR4Lbl.Visible = true;
                    }
                    if (Player4.Contains(38))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ParkPlaceLbl.Location = tile1;
                        ParkPlaceLbl.Visible = true;
                    }
                    if (Player4.Contains(40))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BoardWalkLbl.Location = tile1;
                        BoardWalkLbl.Visible = true;
                    }

                    break;
            }
        }

        private void tradePlayer4_Click(object sender, EventArgs e)
        {
            selectedPlayer = 4;
            tradePlayer1.Visible = false;
            tradePlayer2.Visible = false;
            tradePlayer3.Visible = false;
            tradePlayer4.Visible = false;
            yourProps.Visible = true;
            thereProps.Visible = true;
            yourOffer.Visible = true;
            thereOffer.Visible = true;
            tradeAcc.Visible = true;
            selectPlayer4();
            switch (turn)
            {
                case 1:
                    if (Player1.Contains(2))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MeditAveLbl.Location = tile1;
                        MeditAveLbl.Visible = true;
                    }
                    if (Player1.Contains(4))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BaltAveLbl.Location = tile1;
                        BaltAveLbl.Visible = true;
                    }
                    if (Player1.Contains(6))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR1Lbl.Location = tile1;
                        RR1Lbl.Visible = true;
                    }
                    if (Player1.Contains(7))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        OriAveLbl.Location = tile1;
                        OriAveLbl.Visible = true;
                    }
                    if (Player1.Contains(9))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VermAveLbl.Location = tile1;
                        VermAveLbl.Visible = true;
                    }
                    if (Player1.Contains(10))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ConAveLbl.Location = tile1;
                        ConAveLbl.Visible = true;
                    }
                    if (Player1.Contains(12))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        CharAveLbl.Location = tile1;
                        CharAveLbl.Visible = true;
                    }
                    if (Player1.Contains(14))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        StateAveLbl.Location = tile1;
                        StateAveLbl.Visible = true;
                    }
                    if (Player1.Contains(15))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VirgAveLbl.Location = tile1;
                        VirgAveLbl.Visible = true;
                    }
                    if (Player1.Contains(16))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR2Lbl.Location = tile1;
                        RR2Lbl.Visible = true;
                    }
                    if (Player1.Contains(17))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        JamesAveLbl.Location = tile1;
                        JamesAveLbl.Visible = true;
                    }
                    if (Player1.Contains(19))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        TenAveLbl.Location = tile1;
                        TenAveLbl.Visible = true;
                    }
                    if (Player1.Contains(20))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NYAveLbl.Location = tile1;
                        NYAveLbl.Visible = true;
                    }
                    if (Player1.Contains(22))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        KentAveLbl.Location = tile1;
                        KentAveLbl.Visible = true;
                    }
                    if (Player1.Contains(24))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        IndiAveLbl.Location = tile1;
                        IndiAveLbl.Visible = true;
                    }
                    if (Player1.Contains(25))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player1.Contains(26))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR3Lbl.Location = tile1;
                        RR3Lbl.Visible = true;
                    }
                    if (Player1.Contains(27))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        AtlanAveLbl.Location = tile1;
                        AtlanAveLbl.Visible = true;
                    }
                    if (Player1.Contains(28))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VentAveLbl.Location = tile1;
                        VentAveLbl.Visible = true;
                    }
                    if (Player1.Contains(30))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player1.Contains(32))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PacAveLbl.Location = tile1;
                        PacAveLbl.Visible = true;
                    }
                    if (Player1.Contains(33))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NorthAveLbl.Location = tile1;
                        NorthAveLbl.Visible = true;
                    }
                    if (Player1.Contains(35))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PennAveLbl.Location = tile1;
                        PennAveLbl.Visible = true;
                    }
                    if (Player1.Contains(36))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR4Lbl.Location = tile1;
                        RR4Lbl.Visible = true;
                    }
                    if (Player1.Contains(38))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ParkPlaceLbl.Location = tile1;
                        ParkPlaceLbl.Visible = true;
                    }
                    if (Player1.Contains(40))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BoardWalkLbl.Location = tile1;
                        BoardWalkLbl.Visible = true;
                    }

                    break;
                case 2:
                    if (Player2.Contains(2))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MeditAveLbl.Location = tile1;
                        MeditAveLbl.Visible = true;
                    }
                    if (Player2.Contains(4))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BaltAveLbl.Location = tile1;
                        BaltAveLbl.Visible = true;
                    }
                    if (Player2.Contains(6))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR1Lbl.Location = tile1;
                        RR1Lbl.Visible = true;
                    }
                    if (Player2.Contains(7))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        OriAveLbl.Location = tile1;
                        OriAveLbl.Visible = true;
                    }
                    if (Player2.Contains(9))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VermAveLbl.Location = tile1;
                        VermAveLbl.Visible = true;
                    }
                    if (Player2.Contains(10))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ConAveLbl.Location = tile1;
                        ConAveLbl.Visible = true;
                    }
                    if (Player2.Contains(12))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        CharAveLbl.Location = tile1;
                        CharAveLbl.Visible = true;
                    }
                    if (Player2.Contains(14))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        StateAveLbl.Location = tile1;
                        StateAveLbl.Visible = true;
                    }
                    if (Player2.Contains(15))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VirgAveLbl.Location = tile1;
                        VirgAveLbl.Visible = true;
                    }
                    if (Player2.Contains(16))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR2Lbl.Location = tile1;
                        RR2Lbl.Visible = true;
                    }
                    if (Player2.Contains(17))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        JamesAveLbl.Location = tile1;
                        JamesAveLbl.Visible = true;
                    }
                    if (Player2.Contains(19))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        TenAveLbl.Location = tile1;
                        TenAveLbl.Visible = true;
                    }
                    if (Player2.Contains(20))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NYAveLbl.Location = tile1;
                        NYAveLbl.Visible = true;
                    }
                    if (Player2.Contains(22))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        KentAveLbl.Location = tile1;
                        KentAveLbl.Visible = true;
                    }
                    if (Player2.Contains(24))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        IndiAveLbl.Location = tile1;
                        IndiAveLbl.Visible = true;
                    }
                    if (Player2.Contains(25))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player2.Contains(26))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR3Lbl.Location = tile1;
                        RR3Lbl.Visible = true;
                    }
                    if (Player2.Contains(27))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        AtlanAveLbl.Location = tile1;
                        AtlanAveLbl.Visible = true;
                    }
                    if (Player2.Contains(28))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VentAveLbl.Location = tile1;
                        VentAveLbl.Visible = true;
                    }
                    if (Player2.Contains(30))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player2.Contains(32))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PacAveLbl.Location = tile1;
                        PacAveLbl.Visible = true;
                    }
                    if (Player2.Contains(33))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NorthAveLbl.Location = tile1;
                        NorthAveLbl.Visible = true;
                    }
                    if (Player2.Contains(35))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PennAveLbl.Location = tile1;
                        PennAveLbl.Visible = true;
                    }
                    if (Player2.Contains(36))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR4Lbl.Location = tile1;
                        RR4Lbl.Visible = true;
                    }
                    if (Player2.Contains(38))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ParkPlaceLbl.Location = tile1;
                        ParkPlaceLbl.Visible = true;
                    }
                    if (Player2.Contains(40))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BoardWalkLbl.Location = tile1;
                        BoardWalkLbl.Visible = true;
                    }

                    break;
                case 3:
                    if (Player3.Contains(2))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MeditAveLbl.Location = tile1;
                        MeditAveLbl.Visible = true;
                    }
                    if (Player3.Contains(4))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BaltAveLbl.Location = tile1;
                        BaltAveLbl.Visible = true;
                    }
                    if (Player3.Contains(6))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR1Lbl.Location = tile1;
                        RR1Lbl.Visible = true;
                    }
                    if (Player3.Contains(7))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        OriAveLbl.Location = tile1;
                        OriAveLbl.Visible = true;
                    }
                    if (Player3.Contains(9))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VermAveLbl.Location = tile1;
                        VermAveLbl.Visible = true;
                    }
                    if (Player3.Contains(10))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ConAveLbl.Location = tile1;
                        ConAveLbl.Visible = true;
                    }
                    if (Player3.Contains(12))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        CharAveLbl.Location = tile1;
                        CharAveLbl.Visible = true;
                    }
                    if (Player3.Contains(14))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        StateAveLbl.Location = tile1;
                        StateAveLbl.Visible = true;
                    }
                    if (Player3.Contains(15))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VirgAveLbl.Location = tile1;
                        VirgAveLbl.Visible = true;
                    }
                    if (Player3.Contains(16))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR2Lbl.Location = tile1;
                        RR2Lbl.Visible = true;
                    }
                    if (Player3.Contains(17))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        JamesAveLbl.Location = tile1;
                        JamesAveLbl.Visible = true;
                    }
                    if (Player3.Contains(19))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        TenAveLbl.Location = tile1;
                        TenAveLbl.Visible = true;
                    }
                    if (Player3.Contains(20))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NYAveLbl.Location = tile1;
                        NYAveLbl.Visible = true;
                    }
                    if (Player3.Contains(22))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        KentAveLbl.Location = tile1;
                        KentAveLbl.Visible = true;
                    }
                    if (Player3.Contains(24))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        IndiAveLbl.Location = tile1;
                        IndiAveLbl.Visible = true;
                    }
                    if (Player3.Contains(25))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player3.Contains(26))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR3Lbl.Location = tile1;
                        RR3Lbl.Visible = true;
                    }
                    if (Player3.Contains(27))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        AtlanAveLbl.Location = tile1;
                        AtlanAveLbl.Visible = true;
                    }
                    if (Player3.Contains(28))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VentAveLbl.Location = tile1;
                        VentAveLbl.Visible = true;
                    }
                    if (Player3.Contains(30))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player3.Contains(32))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PacAveLbl.Location = tile1;
                        PacAveLbl.Visible = true;
                    }
                    if (Player3.Contains(33))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NorthAveLbl.Location = tile1;
                        NorthAveLbl.Visible = true;
                    }
                    if (Player3.Contains(35))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PennAveLbl.Location = tile1;
                        PennAveLbl.Visible = true;
                    }
                    if (Player3.Contains(36))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR4Lbl.Location = tile1;
                        RR4Lbl.Visible = true;
                    }
                    if (Player3.Contains(38))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ParkPlaceLbl.Location = tile1;
                        ParkPlaceLbl.Visible = true;
                    }
                    if (Player3.Contains(40))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BoardWalkLbl.Location = tile1;
                        BoardWalkLbl.Visible = true;
                    }

                    break;
                case 4:
                    if (Player4.Contains(2))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MeditAveLbl.Location = tile1;
                        MeditAveLbl.Visible = true;
                    }
                    if (Player4.Contains(4))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BaltAveLbl.Location = tile1;
                        BaltAveLbl.Visible = true;
                    }
                    if (Player4.Contains(6))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR1Lbl.Location = tile1;
                        RR1Lbl.Visible = true;
                    }
                    if (Player4.Contains(7))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        OriAveLbl.Location = tile1;
                        OriAveLbl.Visible = true;
                    }
                    if (Player4.Contains(9))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VermAveLbl.Location = tile1;
                        VermAveLbl.Visible = true;
                    }
                    if (Player4.Contains(10))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ConAveLbl.Location = tile1;
                        ConAveLbl.Visible = true;
                    }
                    if (Player4.Contains(12))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        CharAveLbl.Location = tile1;
                        CharAveLbl.Visible = true;
                    }
                    if (Player4.Contains(14))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        StateAveLbl.Location = tile1;
                        StateAveLbl.Visible = true;
                    }
                    if (Player4.Contains(15))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VirgAveLbl.Location = tile1;
                        VirgAveLbl.Visible = true;
                    }
                    if (Player4.Contains(16))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR2Lbl.Location = tile1;
                        RR2Lbl.Visible = true;
                    }
                    if (Player4.Contains(17))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        JamesAveLbl.Location = tile1;
                        JamesAveLbl.Visible = true;
                    }
                    if (Player4.Contains(19))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        TenAveLbl.Location = tile1;
                        TenAveLbl.Visible = true;
                    }
                    if (Player4.Contains(20))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NYAveLbl.Location = tile1;
                        NYAveLbl.Visible = true;
                    }
                    if (Player4.Contains(22))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        KentAveLbl.Location = tile1;
                        KentAveLbl.Visible = true;
                    }
                    if (Player4.Contains(24))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        IndiAveLbl.Location = tile1;
                        IndiAveLbl.Visible = true;
                    }
                    if (Player4.Contains(25))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player4.Contains(26))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR3Lbl.Location = tile1;
                        RR3Lbl.Visible = true;
                    }
                    if (Player4.Contains(27))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        AtlanAveLbl.Location = tile1;
                        AtlanAveLbl.Visible = true;
                    }
                    if (Player4.Contains(28))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        VentAveLbl.Location = tile1;
                        VentAveLbl.Visible = true;
                    }
                    if (Player4.Contains(30))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        MartinAveLbl.Location = tile1;
                        MartinAveLbl.Visible = true;
                    }
                    if (Player4.Contains(32))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PacAveLbl.Location = tile1;
                        PacAveLbl.Visible = true;
                    }
                    if (Player4.Contains(33))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        NorthAveLbl.Location = tile1;
                        NorthAveLbl.Visible = true;
                    }
                    if (Player4.Contains(35))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        PennAveLbl.Location = tile1;
                        PennAveLbl.Visible = true;
                    }
                    if (Player4.Contains(36))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        RR4Lbl.Location = tile1;
                        RR4Lbl.Visible = true;
                    }
                    if (Player4.Contains(38))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        ParkPlaceLbl.Location = tile1;
                        ParkPlaceLbl.Visible = true;
                    }
                    if (Player4.Contains(40))
                    {
                        Point tile1 = new Point(player1x, player1y);
                        player1y += 13;
                        BoardWalkLbl.Location = tile1;
                        BoardWalkLbl.Visible = true;
                    }

                    break;
            }
        }

        public void propClick(int num)
        {
            switch (turn)
            {
                case 1:
                    if (Player1.Contains(num))
                    {
                        Point offer1 = new Point(offer1x,offer1y);
                        offer1y += 13;
                        propFinder(offer1,num);
                    }
                    break;
                case 2:
                    if (Player2.Contains(num))
                    {
                        Point offer1 = new Point(offer1x, offer1y);
                        offer1y += 13;
                        propFinder(offer1, num);
                    }
                    break;
                case 3:
                    if (Player3.Contains(num))
                    {
                        Point offer1 = new Point(offer1x, offer1y);
                        offer1y += 13;
                        propFinder(offer1, num);
                    }
                    break;
                case 4:
                    if (Player4.Contains(num))
                    {
                        Point offer1 = new Point(offer1x, offer1y);
                        offer1y += 13;
                        propFinder(offer1, num);
                    }
                    break;
            }

            switch (selectedPlayer)
            {
                case 1:
                    if (Player1.Contains(num))
                    {
                        Point offer2 = new Point(offer2x, offer2y);
                        offer2y += 13;
                        propFinder(offer2, num);
                    }
                    break;
                case 2:
                    if (Player2.Contains(num))
                    {
                        Point offer2 = new Point(offer2x, offer2y);
                        offer2y += 13;
                        propFinder(offer2, num);
                    }
                    break;
                case 3:
                    if (Player3.Contains(num))
                    {
                        Point offer2 = new Point(offer2x, offer2y);
                        offer2y += 13;
                        propFinder(offer2, num);
                    }
                    break;
                case 4:
                    if (Player4.Contains(num))
                    {
                        Point offer2 = new Point(offer2x, offer2y);
                        offer2y += 13;
                        propFinder(offer2, num);
                    }
                    break;

            }


        }

        public void propFinder(Point pin,int num)
        {
            switch(num)
            {
                case 2:
                    MeditAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 4:
                    BaltAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                    
                case 6:
                    RR1Lbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 7:
                    OriAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 9:
                    VermAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 10:
                    ConAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 12:
                    CharAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 14:
                    StateAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 15:
                    VirgAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 16:
                    RR2Lbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 17:
                    JamesAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 19:
                    TenAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 20:
                    NYAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 22:
                    KentAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 24:
                    IndiAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 25:
                    MarAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 26:
                    RR3Lbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 27:
                    AtlanAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 28:
                    VentAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 30:
                    MarAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 32:
                    PacAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 33:
                    NorthAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 35:
                    PennAveLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 36:
                    RR4Lbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 38:
                    ParkPlaceLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
                case 40:
                    BoardWalkLbl.Location = pin;
                    if (pin.X == 43)
                    {
                        Playerx.Add(num);
                    }
                    else
                    {
                        Playery.Add(num);
                    }
                    break;
            }
        }

        private void MeditAveLbl_Click(object sender, EventArgs e)
        {
            propClick(2);
        }

        private void BaltAveLbl_Click(object sender, EventArgs e)
        {
            propClick(4);
        }

        private void RR1Lbl_Click(object sender, EventArgs e)
        {
            propClick(6);
        }

        private void OriAveLbl_Click(object sender, EventArgs e)
        {
            propClick(7);
        }

        private void VermAveLbl_Click(object sender, EventArgs e)
        {
            propClick(9);
        }

        private void ConAveLbl_Click(object sender, EventArgs e)
        {
            propClick(10);
        }

        private void CharAveLbl_Click(object sender, EventArgs e)
        {
            propClick(12);
        }

        private void StateAveLbl_Click(object sender, EventArgs e)
        {
            propClick(14);
        }

        private void VirgAveLbl_Click(object sender, EventArgs e)
        {
            propClick(15);
        }

        private void RR2Lbl_Click(object sender, EventArgs e)
        {
            propClick(16);
        }

        private void JamesAveLbl_Click(object sender, EventArgs e)
        {
            propClick(17);
        }

        private void TenAveLbl_Click(object sender, EventArgs e)
        {
            propClick(19);
        }

        private void NYAveLbl_Click(object sender, EventArgs e)
        {
            propClick(20);
        }

        private void KentAveLbl_Click(object sender, EventArgs e)
        {
            propClick(22);
        }

        private void IndiAveLbl_Click(object sender, EventArgs e)
        {
            propClick(24);
        }

        private void MartinAveLbl_Click(object sender, EventArgs e)
        {
            propClick(25);
        }

        private void RR3Lbl_Click(object sender, EventArgs e)
        {
            propClick(26);
        }

        private void AtlanAveLbl_Click(object sender, EventArgs e)
        {
            propClick(27);
        }

        private void VentAveLbl_Click(object sender, EventArgs e)
        {
            propClick(28);
        }

        private void MarAveLbl_Click(object sender, EventArgs e)
        {
            propClick(30);
        }

        private void PacAveLbl_Click(object sender, EventArgs e)
        {
            propClick(32);
        }

        private void NorthAveLbl_Click(object sender, EventArgs e)
        {
            propClick(33);
        }

        private void PennAveLbl_Click(object sender, EventArgs e)
        {
            propClick(35);
        }

        private void RR4Lbl_Click(object sender, EventArgs e)
        {
            propClick(36);
        }

        private void ParkPlaceLbl_Click(object sender, EventArgs e)
        {
            propClick(38);
        }

        private void BoardWalkLbl_Click(object sender, EventArgs e)
        {
            propClick(40);
        }

        private void tradeAcc_Click(object sender, EventArgs e)
        {
            bool deal = true;
            if (yourMoney.Text == "Moneys")
            {
                yourMoney.Text = "0";
            }
            if (thereMoney.Text == "Moneys")
            {
                thereMoney.Text = "0";
            }
            playerxMon = Convert.ToInt32(yourMoney.Text);
            playeryMon = Convert.ToInt32(thereMoney.Text);
            switch (turn)
            {
                case 1:
                    if (money1 < playerxMon)
                    {
                        deal = false;
                    }
                    break;
                case 2:
                    if (money2 < playerxMon)
                    {
                        deal = false;
                    }
                    break;
                case 3:
                    if (money3 < playerxMon)
                    {
                        deal = false;
                    }
                    break;
                case 4:
                    if (money4 < playerxMon)
                    {
                        deal = false;
                    }
                    break;
            }
            switch (selectedPlayer)
            {
                case 1:
                    if (money1 < playeryMon)
                    {
                        deal = false;
                    }
                    break;
                case 2:
                    if (money2 < playeryMon)
                    {
                        deal = false;
                    }
                    break;
                case 3:
                    if (money3 < playeryMon)
                    {
                        deal = false;
                    }
                    break;
                case 4:
                    if (money4 < playeryMon)
                    {
                        deal = false;
                    }
                    break;
            }
            if (deal == false)
            {
            }
            else{
            for (int i = 0; i < 41; i++)
            {
                if (Playerx.Contains(i))
                {
                    switch (turn)
                    {
                        case 1:
                            Player1.Remove(i);
                            money1 -= playerxMon;
                            money1 += playeryMon;
                            playerxMon = 0;
                            playeryMon = 0;
                            switch (selectedPlayer)
                            {
                                case 1:
                                    Player1.Add(i);
                                    break;
                                case 2:
                                    Player2.Add(i);
                                    break;
                                case 3:
                                    Player3.Add(i);
                                    break;
                                case 4:
                                    Player4.Add(i);
                                    break;
                            }
                            break;
                        case 2:
                            Player2.Remove(i);
                            money2 -= playerxMon;
                            money2 += playeryMon;
                            playerxMon = 0;
                            playeryMon = 0;
                            switch (selectedPlayer)
                            {
                                case 1:
                                    Player1.Add(i);
                                    break;
                                case 2:
                                    Player2.Add(i);
                                    break;
                                case 3:
                                    Player3.Add(i);
                                    break;
                                case 4:
                                    Player4.Add(i);
                                    break;
                            }
                            break;
                        case 3:
                            money3 -= playerxMon;
                            money3 += playeryMon;
                            playerxMon = 0;
                            playeryMon = 0;
                            Player3.Remove(i);
                            switch (selectedPlayer)
                            {
                                case 1:
                                    Player1.Add(i);
                                    break;
                                case 2:
                                    Player2.Add(i);
                                    break;
                                case 3:
                                    Player3.Add(i);
                                    break;
                                case 4:
                                    Player4.Add(i);
                                    break;
                            }
                            break;
                        case 4:
                            money4 -= playerxMon;
                            money4 += playeryMon;
                            playerxMon = 0;
                            playeryMon = 0;
                            Player4.Remove(i);
                            switch (selectedPlayer)
                            {
                                case 1:
                                    Player1.Add(i);
                                    break;
                                case 2:
                                    Player2.Add(i);
                                    break;
                                case 3:
                                    Player3.Add(i);
                                    break;
                                case 4:
                                    Player4.Add(i);
                                    break;
                            }
                            break;
                    }
                }
                if (Playery.Contains(i))
                {
                    switch (selectedPlayer)
                    {
                        case 1:
                            money1 -= playeryMon;
                            money1 += playerxMon;
                            playerxMon = 0;
                            playeryMon = 0;
                            Player1.Remove(i);
                            switch (turn)
                            {
                                case 1:
                                    Player1.Add(i);
                                    break;
                                case 2:
                                    Player2.Add(i);
                                    break;
                                case 3:
                                    Player3.Add(i);
                                    break;
                                case 4:
                                    Player4.Add(i);
                                    break;
                            }
                            break;
                        case 2:
                            money2 -= playeryMon;
                            money2 += playerxMon;
                            playerxMon = 0;
                            playeryMon = 0;
                            Player2.Remove(i);
                            switch (turn)
                            {
                                case 1:
                                    Player1.Add(i);
                                    break;
                                case 2:
                                    Player2.Add(i);
                                    break;
                                case 3:
                                    Player3.Add(i);
                                    break;
                                case 4:
                                    Player4.Add(i);
                                    break;
                            }
                            break;
                        case 3:
                            money3 -= playeryMon;
                            money3 += playerxMon;
                            playerxMon = 0;
                            playeryMon = 0;
                            Player3.Remove(i);
                            switch (turn)
                            {
                                case 1:
                                    Player1.Add(i);
                                    break;
                                case 2:
                                    Player2.Add(i);
                                    break;
                                case 3:
                                    Player3.Add(i);
                                    break;
                                case 4:
                                    Player4.Add(i);
                                    break;
                            }
                            break;
                        case 4:
                            money4 -= playeryMon;
                            money4 += playerxMon;
                            playerxMon = 0;
                            playeryMon = 0;
                            Player4.Remove(i);
                            switch (turn)
                            {
                                case 1:
                                    Player1.Add(i);
                                    break;
                                case 2:
                                    Player2.Add(i);
                                    break;
                                case 3:
                                    Player3.Add(i);
                                    break;
                                case 4:
                                    Player4.Add(i);
                                    break;
                            }
                            break;
                    }
                }
                }
            }
            Form1 f = new Form1(Player1, Player2, Player3, Player4,money1,money2,money3,money4);
            this.Hide();
            //f.Show();

        }

    }
}
