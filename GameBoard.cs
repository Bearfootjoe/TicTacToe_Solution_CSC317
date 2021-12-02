using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heirendt_Joseph_CSC317_TicTacToe_Solution
{
    public partial class GameBoard : Form
    {
        int turnTaker;
        Players P1 = new Players();
        Players P2 = new Players();

        public GameBoard()
        {
            InitializeComponent();     
            Btn_NewGame.Hide();
            Btn_CloseGame.Hide();
        }

        public void GetPlayers(Players player1, Players player2)
        {

        }
        public void GameBoard_Load(object sender, EventArgs e)
        {
            this.Lbl_Player1Name.BackColor = this.P1.backColor;
            this.Lbl_Player1Name.ForeColor = P1.foreColor;
            this.Lbl_Player1Name.Text = P1.name;

            this.Lbl_Player1Character.BackColor = P1.backColor;
            this.Lbl_Player1Character.ForeColor = P1.foreColor;
            this.Lbl_Player1Character.Text = P1.character;

            this.Lbl_Player2Name.BackColor = P2.backColor;
            this.Lbl_Player2Name.ForeColor = P2.foreColor;
            this.Lbl_Player2Name.Text = P2.name;

            this.Lbl_Player2Character.BackColor = P2.backColor;
            this.Lbl_Player2Character.ForeColor = P2.foreColor;
            this.Lbl_Player2Character.Text = P2.character;

            GameLoop();
        }
        public void ClaimP1(Label label)
        {
            label.Text = P1.character;
            label.BackColor = P1.backColor;
            label.ForeColor = P1.foreColor;
            label.Enabled = false;
        }
        public void ClaimP2(Label label)
        {
            label.Text = P2.character;
            label.BackColor = P2.backColor;
            label.ForeColor = P2.foreColor;
            label.Enabled = false;
        }

        public void GameLoop()
        {
           
            bool gameFlag = true;

            while(gameFlag == true)
            {
                if(turnTaker % 2 != 0)
                {
                    Lbl_TurnsAndWins.Text = P1.name + "'s Turn";
                    Lbl_TurnsAndWins.BackColor = P1.backColor;
                    Lbl_TurnsAndWins.ForeColor = P1.foreColor;

                    //bool gameFlag = endGame();

                }
                else if(turnTaker % 2 == 0)
                {
                    Lbl_TurnsAndWins.Text = P2.name + "'s Turn";
                    Lbl_TurnsAndWins.BackColor = P2.backColor;
                    Lbl_TurnsAndWins.ForeColor = P2.foreColor;

                    //bool gameFlag = endGame();
                }
            }
        }

        public void GameTileFill(Players player)
        {
            
        }
        public void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Lbl_pos1_Click(object sender, EventArgs e)
        {
            if(turnTaker % 2 != 0)
            {
                ClaimP1(Lbl_pos1);
                turnTaker++;
                Lbl_pos1.Enabled = false;
            }
            else
            {
                ClaimP2(Lbl_pos1);
                turnTaker++;
                Lbl_pos1.Enabled = false;
            }
        }

        private void Lbl_pos2_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_pos3_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_pos4_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_pos5_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_pos6_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_pos7_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_pos8_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_pos9_Click(object sender, EventArgs e)
        {

        }
    }
}
