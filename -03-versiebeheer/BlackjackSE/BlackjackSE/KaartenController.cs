using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BlackjackSE
{
    public class KaartenController
    {

        // Members die de model en de view van de teerlingen zullen onthouden
        private KaartenModel model;
        private KaartView view;

        // Constructor
        public KaartenController()
        {

            // Maak instanties van model en view aan
            model = new KaartenModel();

            /* 
                Injecteer huidige instante (=controller) zodat de view kan communiceren
                wanneer er een bepaald event heeft plaatsgevonden
            */
            view = new KaartView(this);
        }

        /*
            Return de view van de teerling
        */
        public KaartView getView()
        {
            return view;
        }

        /*
           Return de waarde met de waarde van de teerling (= aantal ogen)
       */
        public Image Kaart
        {
            get
            {
                return model.Kaart;
            }
        }

        public int NummerKaart
        {
          get
          {
            return model.NummerKaart;
          }
          set
          {
            model.NummerKaart = value;
          }
        }

        public void NeemKaart()
        {
          model.ToonKaart();

          

          view.updateUI();
        }
        public void NieuwSpel()
        {
          model.ToonKaartNieuwSpel();

          view.updateUI();
        }
    }
}
