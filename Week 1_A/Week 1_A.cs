using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_1_A
{
    public partial class frmComputerJoke : Form
    {
        public frmComputerJoke()
        {
            InitializeComponent();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            //Displays the joke in the one label. 
            lblJoke.Text = "Why do app developers have such high insurance rates?";
        }

        private void btnPunchline_Click(object sender, EventArgs e)
        {
            //Displays the answer to the joke in the one label.
            lblJoke.Text = "They're always crashing!";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Resets the label to the original question when the user first opens the application. 
            lblJoke.Text = "Ready for a Joke?";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Closes the form entirely. 
            this.Close();
        }
    }
}
