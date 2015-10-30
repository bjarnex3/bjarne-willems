using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzeee
{
    public class TeerlingController
    {
        public TeerlingView view;
        public TeerlingModel model;
        private static Random random = new Random();

        public TeerlingController()
        {
            //Maakt nieuwe instantie aan van view
            view = new TeerlingView( this );
            model = new TeerlingModel();
        }

        public bool IsVast
        {
            get
            {
                return model.IsVast;
            }
        }


        public TeerlingView getView()
        {
            return view;   
        }

        public void Werp()
        { 
            //vraagt aan model om aantal ogen te updaten
            
            int aantalOgen = random.Next(1, 7);

            model.AantalOgen = aantalOgen;

            updateUI();
        }

        public void TurnVast()
        {
            model.TurnVast();
        }

        public void updateUI()
        {   
            model.teerlingTekst = model.AantalOgen.ToString();
            model.ScoreTekst = model.Score.ToString();
            view.updateUI();
        }


    }
}
