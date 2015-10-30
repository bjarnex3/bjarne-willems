using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackSE
{
    public class ScorebordController
    {
        // Member die de bovenliggende klasse opslaagt
        private GameController container;

        /*
            Members die het huidige model en view zullen opslaan
        */
        private ScoreBordView view;
       

        public ScorebordController( GameController cont )
        {
            // Vang de geïnjecteerde bovenliggende klasse op in de member container
            container = cont;

            /*
                Maak een view en een model aan voor deze klasse
            */
            view = new ScoreBordView(this);
            
        }

        /*
            Return de view van het scoreboard
        */
        public ScoreBordView getView()
        {
            return view;
        }

        /*
            Return het maximum aantal worden
        */
        public int Score
        {
            get
            {
                /*
                    Het maximum aantal worpen wordt gedefinieerd in de bovenliggende klasse
                    Deze klasse is de container en bevat een methode MaximumAantalWorpen
                    die deze waarde zal returnen
                */
                return container.Score;
            }
        }

        /*
            Return het huidig aantal worden
        */
        public int ScorePC
        {
            get
            {
                /*
                    Het huidig aantal worpen wordt onthouden in de bovenliggende klasse
                    Deze klasse is de container en bevat een methode HuidigAantalWorpen
                    die deze waarde zal returnen
                */
                return container.ScorePC;
            }
        }

        public int WinStreak
        {
            get
            {
                /*
                    Het huidig aantal worpen wordt onthouden in de bovenliggende klasse
                    Deze klasse is de container en bevat een methode HuidigAantalWorpen
                    die deze waarde zal returnen
                */
                return container.WinStreak;
            }
        }

        /*
            Deze methode spreekt de view aan die een methode updateView heeft
            In deze methode wordt gedefinieerd wat er moet gebeuren wanneer er iets wijzigt
            (zoals bv. drukken op de "smijt allemaal" knop waardoor het huidig aantal worpen 
            wijzigt)
        */
        public void updateView()
        {
            view.updateView();
        }

    }
}
