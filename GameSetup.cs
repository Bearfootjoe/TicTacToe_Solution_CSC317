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
    
    public partial class TicTacToe : Form
    {

        public Players Player1 = new Players();
        public Players Player2 = new Players();
        public bool GameStartFlag = false;
        public TicTacToe()
        {
            InitializeComponent();

        }
        public void TicTacToe_Load(object sender, EventArgs e)
        {

        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void Btn_Player1TitleColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = Txt_Player1_Name.ForeColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                Btn_Player1TitleColor.ForeColor = MyDialog.Color;
                Btn_Player1TitleColor.BackColor = MyDialog.Color;
                this.Player1.backColor = MyDialog.Color;
            }

        }
        private void Btn_Player1CharacterColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
           // MyDialog.Color = Txt_Player1_Name.ForeColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)

            {
                Btn_Player1CharacterColor.ForeColor = MyDialog.Color;
                Btn_Player1CharacterColor.BackColor = MyDialog.Color;
                this.Player1.foreColor = MyDialog.Color;
              
            }
        }
        private void Btn_Player2CharacterColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
           // MyDialog.Color = Txt_Player1_Name.ForeColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                Btn_Player2CharacterColor.ForeColor = MyDialog.Color;
                Btn_Player2CharacterColor.BackColor = MyDialog.Color;
                this.Player2.backColor = MyDialog.Color;
            }
        }
        private void Btn_Player2TitleColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            //MyDialog.Color = Txt_Player1_Name.ForeColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                Btn_Player2TitleColor.ForeColor = MyDialog.Color;
                Btn_Player2TitleColor.BackColor = MyDialog.Color;
                this.Player2.foreColor = MyDialog.Color;
            }
        }
        private void Btn_Player1Ready_Click(object sender, EventArgs e)
        {
            Btn_Player1Ready.Text = "Player 1 Ready!!";
            Btn_Player1Ready.BackColor = Btn_Player1CharacterColor.BackColor;
            this.Player1.name = Txt_Player1_Name.Text;
            GameStartFlag = true;

        }
        private void Btn_Player2Ready_Click(object sender, EventArgs e)
        {
            Btn_Player2Ready.Text = "Player 2 Ready!!";
            Btn_Player2Ready.BackColor = Btn_Player2CharacterColor.BackColor;

            if (GameStartFlag == true)
            {
                this.Player2.name = Txt_Player2_Name.Text;
                Form f2 = new GameBoard(Player1, Player2);
                f2.Show(); // Shows GameBoard();   
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Btn_Player1TitleColor.BackColor;
            label11.BackColor = Btn_Player1TitleColor.BackColor;
            this.Player1.character = label1.Text;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Btn_Player1TitleColor.BackColor;
            label12.BackColor = Btn_Player1TitleColor.BackColor;
            this.Player1.character = label2.Text;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            label3.BackColor = Btn_Player1TitleColor.BackColor;
            label13.BackColor = Btn_Player1TitleColor.BackColor;
            this.Player1.character = label3.Text;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            label4.BackColor = Btn_Player1TitleColor.BackColor;
            label14.BackColor = Btn_Player1TitleColor.BackColor;
            this.Player1.character = label4.Text;
        }
        private void label5_Click(object sender, EventArgs e)
        {
            label5.BackColor = Btn_Player1TitleColor.BackColor;
            label15.BackColor = Btn_Player1TitleColor.BackColor;
            this.Player1.character = label5.Text;
        }
        private void label6_Click(object sender, EventArgs e)
        {
            label6.BackColor = Btn_Player1TitleColor.BackColor;
            label16.BackColor = Btn_Player1TitleColor.BackColor;
            this.Player1.character = label6.Text;
        }
        private void label7_Click(object sender, EventArgs e)
        {
            label7.BackColor = Btn_Player1TitleColor.BackColor;
            label17.BackColor = Btn_Player1TitleColor.BackColor;
            this.Player1.character = label7.Text;
        }
        private void label8_Click(object sender, EventArgs e)
        {
            label8.BackColor = Btn_Player1TitleColor.BackColor;
            label18.BackColor = Btn_Player1TitleColor.BackColor;
            this.Player1.character = label8.Text;
        }
        private void label11_Click(object sender, EventArgs e)
        {
            if (label11.BackColor == Btn_Player1TitleColor.BackColor)
                return;
            else
            {
                label11.BackColor = Btn_Player2TitleColor.BackColor;
                this.Player2.character = label11.Text;
            }
        }
        private void label12_Click(object sender, EventArgs e)
        {
            if (label12.BackColor == Btn_Player1TitleColor.BackColor)
            return;
            else
            {
                label12.BackColor = Btn_Player2TitleColor.BackColor;
                this.Player2.character = label12.Text;
            }
        }
        private void label13_Click(object sender, EventArgs e)
        {
            if (label13.BackColor == Btn_Player1TitleColor.BackColor)
                return;
            else
            {
                label13.BackColor = Btn_Player2TitleColor.BackColor;
                this.Player2.character = label13.Text;
            }
        }
        private void label14_Click(object sender, EventArgs e)
        {
            if (label14.BackColor == Btn_Player1TitleColor.BackColor)
                return;
            else
            {
                label14.BackColor = Btn_Player2TitleColor.BackColor;
                this.Player2.character = label14.Text;
            }
        }
        private void label15_Click(object sender, EventArgs e)
        {
            if (label15.BackColor == Btn_Player1TitleColor.BackColor)
                return;
            else
            {
                label15.BackColor = Btn_Player2TitleColor.BackColor;
                this.Player2.character = label15.Text;
            }
        }
        private void label16_Click(object sender, EventArgs e)
        {
            if (label16.BackColor == Btn_Player1TitleColor.BackColor)
                return;
            else
            {
                label16.BackColor = Btn_Player2TitleColor.BackColor;
                this.Player2.character = label16.Text;
            }
        }
        private void label17_Click(object sender, EventArgs e)
        {
            if (label17.BackColor == Btn_Player1TitleColor.BackColor)
                return;
            else
            {
                label17.BackColor = Btn_Player2TitleColor.BackColor;
                this.Player2.character = label17.Text;
            }
        }
        private void label18_Click(object sender, EventArgs e)
        {
            if (label18.BackColor == Btn_Player1TitleColor.BackColor)
                return;
            else
            {
                label18.BackColor = Btn_Player2TitleColor.BackColor;
                this.Player2.character = label18.Text;
            }
        }

        public class Players
        {
            public string name;
            public string character;
            public System.Drawing.Color foreColor;
            public System.Drawing.Color backColor;
        }
    }
}
