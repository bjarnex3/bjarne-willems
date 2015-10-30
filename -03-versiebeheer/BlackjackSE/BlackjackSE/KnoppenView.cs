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
    public partial class KnoppenView : UserControl
    {
        private KnoppenController controller;
        
        public KnoppenView(KnoppenController knoppenController)
        {
            controller = knoppenController;
            
            InitializeComponent();
        }

        private void KnoppenView_Load(object sender, EventArgs e)
        {
            // Maak een lijst die alle views van de teerlingen zal bevatten
            List<KaartView> kaarten = controller.getKaartView();

            // De breedte van één teerling ophalen om de positie te kunnen berekenen
            int kaartBreedte = kaarten.First().Width;

            // De hoogte van een teerling ophalen om de "smijt ze allemaal" knop op de juiste
            // positie te kunnen zetten
            int kaartHoogte = kaarten.First().Height;

            // Teerlingen overlopen om zo de horizontale positie van elke teerling te kunnen bepalen
            foreach (KaartView kaart in kaarten)
            {
                // View van één teerling ophalen
                KaartView huidigeKaart = kaart;

                /*
                    De positie van de huidige teerling bepalen op basis van de index van de lijst
                    bv. teerling[0] => 0 * width = 0 * 150 => xPos = 0
                    teerling[1] => 1 * width = 1 * 150 => xPos = 150
                    etc. 
                */
                int xPos = kaarten.IndexOf(kaart) * kaartBreedte;

                // De positie van de huidige teerling setten
                huidigeKaart.Location = new Point(xPos, 0);

                // De view van de huidige teerling toevoegen
                Controls.Add(huidigeKaart);
            }
        }

        private void btnKaartNemen_Click(object sender, EventArgs e)
        {
          controller.NeemKaart();
          controller.ScoreOptellen();
          
        }

        private void btnGeenKaart_Click(object sender, EventArgs e)
        {

        }

        private void btnNieuwSpel_Click(object sender, EventArgs e)
        {
          controller.NieuwSpel();
        }

    }
}
