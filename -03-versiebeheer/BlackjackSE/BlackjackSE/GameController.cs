using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackSE
{
    public class GameController
    {
        // Member om de view in op te slaan
        private Blackjack view;

        // De members die de controllers van yahtzee en het scoreboard bevatten
        private KaartenController kaarten;
        private KnoppenController knoppen;
        private ScorebordController scorebord;

        public GameController()
        {
            /*
                Maak de view voor het spel aan
                Belangrijk: de huidige context, de GameController, wordt meegegeven
                met deze view instantie, zodat de view de controller op de hoogte kan
                stellen van eventuele veranderingen en data kan ophalen die in deze
                controller gedefinieerd wordt.
            */
            view = new Blackjack(this);

            /* 
                Maak een instantie van de controller van Yahtzee
                Injecteer de huidige context (de parent) = Dependency Injection
                zodat de YahtzeeController zijn bovenliggende klassen (=GameController)
                kan verwittigen van zodra er iets veranderd in zijn controller
                
            */
            knoppen = new KnoppenController(this);

            /*
                Maak een instantie aan van het scoreboard en injecteer de huidige context
            */
            scorebord = new ScorebordController(this);
            kaarten = new KaartenController();
        }

        /*
        
            Deze methode wordt aangesproken van zodra er een verandering heeft plaatsgevonden
            in het scoreboard of de yahtzee instantie
        */
        public void modelHasChanged()
        {
            scorebord.updateView();
        }

        /*
            Deze methode returnt de view voor het volledige spel
        */
        public Blackjack getView()
        {
            return view;
        }

        public KaartView getViewKaarten()
        {
            return kaarten.getView();
        }

        /*
            Deze methode returnt de User Control view voor Yahtzee
        */
        public KnoppenView getViewKnoppen()
        {
            return knoppen.getView();
        }

        /*
            Deze methode returnt de User Control view voor het Scoreboard
        */
        public ScoreBordView getViewScoreboard()
        {
            return scorebord.getView();
        }

        public int Score
        {
            get
            {
                return knoppen.Score;
            }
        }


        public int ScorePC
        {
            get
            {
                return knoppen.ScorePC;
            }
        }
        public int WinStreak
        {
            get
            {
                return knoppen.WinStreak;
            }
        }



    }
}
