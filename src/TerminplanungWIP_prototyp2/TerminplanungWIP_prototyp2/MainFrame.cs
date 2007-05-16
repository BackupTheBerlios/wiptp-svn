using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TerminplanungWIP_prototyp2
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MMItemFile_MouseEnter(object sender, EventArgs e)
        {
            MMItemFile.ForeColor = Color.Black;
        }

        private void MMItemFile_MouseLeave(object sender, EventArgs e)
        {
            MMItemFile.ForeColor = Color.LightGray;
        }

    }
}