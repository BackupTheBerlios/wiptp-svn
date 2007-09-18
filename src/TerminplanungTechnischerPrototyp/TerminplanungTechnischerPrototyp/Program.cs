using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TerminplanungTechnischerPrototyp.GUI;

namespace TerminplanungTechnischerPrototyp
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GuiMainFrame());
            CSV_Handling.CSVHandling data = new CSV_Handling.CSVHandling();
            data.loadData("C:\\Dokumente und Einstellungen\\mySelf\\Eigene Dateien\\_PRE\\_PRE-Projekt\\Altsystem2006\\nachprüfungen.csv");

        }
    }
}