﻿using System;
using System.Windows.Forms;

namespace PI3
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Play.CantStop(1, "1", "Azul", "asda"));
            //Application.Run(new Lobby.GameLobby());
        }
    }
}
