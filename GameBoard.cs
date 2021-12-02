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
        public TicTacToe.Players P1 = new TicTacToe.Players();
        public TicTacToe.Players P2 = new TicTacToe.Players();

        public GameBoard(TicTacToe.Players Player1, TicTacToe.Players Player2)
        {
            InitializeComponent();
            P1 = Player1;
            P2 = Player2;
            Btn_NewGame.Hide();
            Btn_CloseGame.Hide();
        }

        public void GameBoard_Load(object sender, EventArgs e)
        {
            this.Lbl_Player1Name.BackColor = P1.backColor;
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
        }

    }
}
