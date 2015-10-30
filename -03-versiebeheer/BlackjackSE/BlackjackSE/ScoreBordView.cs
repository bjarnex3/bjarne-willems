using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackSE
{
    public partial class ScoreBordView : UserControl
    {
        private ScorebordController controller;
        public ScoreBordView(ScorebordController c)
        {
            controller = c;
            InitializeComponent();
        }

        private void ScoreBordView_Load(object sender, EventArgs e)
        {
            // Toon het maximum aantal worpen in het overeenstemmende label
            lblScore.Text = controller.Score.ToString();

            // Toon het huidig aantal worpen in het overeenstemmende label
            lblScorePC.Text = controller.ScorePC.ToString();

            // Toon het huidig aantal worpen in het overeenstemmende label
            lblWinStreak.Text = controller.WinStreak.ToString();
        }



        /*
            Methode die uitgevoerd wordt wanneer er iets wijzigt
        */
        public void updateView()
        {
          lblScore.Text = "lel";
        }

        
    }
}
