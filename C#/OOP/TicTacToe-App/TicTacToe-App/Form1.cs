using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicTacToe_App.Components;
using TicTacToe_App.Enum;

namespace TicTacToe_App
{
    public partial class Form1 : Form
    {
        IBoard b;
        ResultAnalyser ra;
        Game game;
        string[] displayResult = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public Form1()
        {
            InitializeComponent();
            SetButton(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = new ThreeDBoard();
            ra = new ResultAnalyser(b);
            Button myBtn = (Button)sender;

            switch (myBtn.Name)
            {
                case "btnStart":
                    string pname1 = player1.Text;
                    string pname2 = player2.Text;
                    Player p1 = new Player(pname1, Mark.X);
                    Player p2 = new Player(pname2, Mark.O);
                    Player[] p = { p1, p2 };
                    game = new Game(b, p, ra);
                    SetButton(true);
                    btnStart.Enabled = false;
                    break;
                case "button1": Input(1, button1);
                    break;
                case "button2":
                    Input(2, button2);
                    break;
                case "button3":
                    Input(3, button3);
                    break;
                case "button4":
                    Input(4, button4);
                    break;
                case "button5":
                    Input(5, button5);
                    break;
                case "button6":
                    Input(6, button6);
                    break;
                case "button7":
                    Input(7, button7);
                    break;
                case "button8":
                    Input(8, button8);
                    break;
                case "button9":
                    Input(9, button9);
                    break;
                default:
                    break;
            }
        }

        public void Input(int input, Button btn)
        {
            btn.Enabled = false;
            Result result = game.play(GetRow(input), GetColumn(input));
            //btn.Text = b.GetCell(GetRow(input), GetColumn(input)).ToString();
            if (result == Result.WIN)
            {
                MessageBox.Show("Player " + game.GetCurrentPlayer() + " Wins");
                SetButton(false);
            }
            if (result == Result.TIE)
            { MessageBox.Show("Its a TIE"); }
        }

        public void SetButton(bool value)
        {
            button1.Enabled = value;
            button2.Enabled = value;
            button3.Enabled = value;
            button4.Enabled = value;
            button5.Enabled = value;
            button6.Enabled = value;
            button7.Enabled = value;
            button8.Enabled = value;
            button9.Enabled = value;
        }

        public int GetRow(int no)
        {
            return (no - 1) / 3;
        }

        public int GetColumn(int no)
        {
            return (no - 1) % 3;
        }
    }
}
