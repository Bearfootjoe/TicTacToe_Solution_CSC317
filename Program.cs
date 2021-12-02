/*

Program Author: Joseph Heirendt

USM Id: 10060206

Assignment: Tic Tac Toe GUI

Description:

This app should open up a form and take in a bunch of fields to build two players. 
Once completed, that form should close and a tic tac toe board should open up and be playable.

*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heirendt_Joseph_CSC317_TicTacToe_Solution
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TicTacToe());
        }
    }
}
