using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackSE
{
    class KnoppenModel
    {
        private List<KaartenController> kaarten = new List<KaartenController>();

        /*
            De members die de configuratie voor het Yahtzeespel zullen onthouden
        */
        private int score;
        private int scorePC;
        private int winStreak;
        private int aantalKaarten;
        
        /*
            Voeg een teerling toe aan de lijst met teerlingen
        */
        internal void addKaart(KaartenController kaart)
        {
            kaarten.Add(kaart);
        }

      public void ScoreOptellen()
        {
          score = kaarten[0].NummerKaart;
        }

        /*
            Getter voor de lijst met eerlingen
        */
        public List<KaartenController> Kaarten
        {
            get
            {
                return kaarten;
            }
        }

        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                Score = value;
            }
        }

        /*
            getter en setter voor het maximum aantal worpen
        */
        public int ScorePC
        {
            get
            {
                return scorePC;
            }
            set
            {
                scorePC = value;
            }
        }

        public int WinStreak
        {
            get
            {
                return winStreak;
            }
            set
            {
                winStreak = value;
            }
        }

        /*
            getter en setter voor het aantal teerlingen
        */
        public int AantalKaarten
        {
            get
            {
                return aantalKaarten;
            }
            set
            {
                aantalKaarten = value;
            }
        }
    
        public void NieuwSpel()
        {
          score = 10;
        }
    }
}
