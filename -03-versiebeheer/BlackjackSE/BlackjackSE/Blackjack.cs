using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackSE
{
    public partial class Blackjack : Form
    {
        private GameController controller;
        public Blackjack( GameController c)
        {
            controller = c;
            InitializeComponent();
        }

        private void Blackjack_Load(object sender, EventArgs e)
        {
            /* 
                Haal de views op, op basis van de controller die bij het aanmaken
                van deze klasse werd meegegeven
            */
            KaartView kaarten = controller.getViewKaarten();
            KnoppenView knoppen = controller.getViewKnoppen();
            ScoreBordView scoreboard = controller.getViewScoreboard();

            /*
                Haal de hoogte van het scoreboard op zodat de yahtzee met de teerlingen
                hier onder geplaatst kunnen worden
            */
            scoreboard.Location = new Point(kaarten.Width + 15, kaarten.Height);

            /*
                Voeg de views toe aan het formulier
            */
            Controls.Add( scoreboard );
            Controls.Add( knoppen );
        
        }
    }

}

