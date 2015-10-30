using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzeee
{
    
    public class TeerlingModel
    {
        private string TeerlingTekst = "";
        private string scoreTekst = "";
        private int aantalOgen;
        private int score = 0;
        private bool isVast;

        public TeerlingModel()
        {
            isVast = false;
        }

        public string teerlingTekst
        {
            get { return TeerlingTekst; }
            set { TeerlingTekst = value; }
        }

        public string ScoreTekst
        {
            get { return scoreTekst; }
            set { scoreTekst = value; }
        }
        
	    public int AantalOgen
	    {
		get { return aantalOgen;}
		set { aantalOgen = value;}
	    }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }


        public bool IsVast
        {
            get { return isVast; }
        }

        public void TurnVast()
        {
            isVast = !isVast;
        }
	
        
    }
}
