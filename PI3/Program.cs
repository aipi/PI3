﻿using System;
using System.Windows.Forms;

namespace PI3.Lobby
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
            //Application.Run(new CantStop(326, "1", "Azul", "asda"));
            Application.Run(new GameLobby());
        }
    }
}
