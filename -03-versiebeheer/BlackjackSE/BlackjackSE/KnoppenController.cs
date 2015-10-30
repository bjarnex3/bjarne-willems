using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackSE
{
    public class KnoppenController
    {
        private GameController container;

        private KnoppenView view;
        private KnoppenModel model;

        public KnoppenController(GameController cont)
        {
            container = cont;
            view = new KnoppenView(this);
            model = new KnoppenModel();
            maakKaarten();
            
        }

        // Voeg aantal teerlingen toe aan het model
        public void maakKaarten()
        {
            // Loop over het aantal teerlingen dat er mogen zijn (gedefiniëerd in GameController)
            for (int i = 0; i < 2; i++)
            {
                // Maak een nieuwe teerling aan
                KaartenController kaart = new KaartenController();


                // Voeg de teerling toe aan het model
                model.addKaart(kaart);
            }
        }

      public void ScoreOptellen()
        {
          model.ScoreOptellen();
        }

        /*
            Haal de views op van alle teerlingen
        */
        public List<KaartView> getKaartView()
        {
            // Maak een lijst die de views zal opvangen
            List<KaartView> kaartenView = new List<KaartView>();

            // Loop over het huidig aantal teerlingen uit het model
            foreach (KaartenController kaart in model.Kaarten)
            {
                // Haal de view op voor iedere teerling
                KaartView kaartView = kaart.getView();

                // Voeg de teerling toe aan de lijst die de views opvangt
                kaartenView.Add(kaartView);
            }

            // Return de lijst met teerlingViews
            return kaartenView;
        }

        /*
           Return de volledige Yahtzee view
        */
        public KnoppenView getView()
        {
            return view;
        }

        public int Score
        {
            get
            {
                return model.Score;
            }
            set
            {
                model.Score = value;
            }

        }

        /*
            getter voor het huidig aantal worpen
        */
        public int ScorePC
        {
            get
            {
                return model.ScorePC;
            }
            set
            {
                model.ScorePC = value;
            }
        }

        public int WinStreak
        {
            get
            {
                return model.WinStreak;
            }
            set
            {
                model.WinStreak = value;
            }
        }

        /*
            Methode die uitgevoerd wordt van zodra er op de "smijt alle teerlingen" 
            knop wordt gedrukt
        */
        public void NeemKaart()
        {
          List<KaartenController> kaarten = model.Kaarten;
          foreach ( KaartenController kaart in kaarten)
          {
            kaart.NeemKaart();
          }
        }

        public void NeemGeenKaart()
        {

        }

        public void NieuwSpel ()
        {
          List<KaartenController> kaarten = model.Kaarten;
          foreach (KaartenController kaart in kaarten)
          {
            kaart.NieuwSpel();
          }

          model.NieuwSpel();

        }

    }
}
