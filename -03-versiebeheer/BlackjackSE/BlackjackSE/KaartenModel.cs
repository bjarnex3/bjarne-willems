using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace BlackjackSE
{
    class KaartenModel
    {
        // Members die de waarde van de kaart onthouden

        public Image kaart;
        private string[,] kaarten;
        private static Random randomNummer;
        private int nummerKaart;
        private int arrayRow = 0;
        private int arrayColumn = 0;
        private List<int> usedNumbersRow = new List<int>();
        private List<int> usedNumbersColumn = new List<int>(); 

      

        public KaartenModel()
        {        
          kaarten = new string[14, 4] { { "default.jpg", "", "", "" }, 
                                        { "hart1.jpg", "klaveren1.jpg", "ruiten1.jpg", "schoppen1.jpg" }, 
                                        { "hart2.jpg", "klaveren2.jpg", "ruiten2.jpg", "schoppen2.jpg" }, 
                                        { "hart3.jpg", "klaveren3.jpg", "ruiten3.jpg", "schoppen3.jpg" }, 
                                        { "hart4.jpg", "klaveren4.jpg", "ruiten4.jpg", "schoppen4.jpg" }, 
                                        { "hart5.jpg", "klaveren5.jpg", "ruiten5.jpg", "schoppen5.jpg" }, 
                                        { "hart6.jpg", "klaveren6.jpg", "ruiten6.jpg", "schoppen6.jpg" }, 
                                        { "hart7.jpg", "klaveren7.jpg", "ruiten7.jpg", "schoppen7.jpg" }, 
                                        { "hart8.jpg", "klaveren8.jpg", "ruiten8.jpg", "schoppen8.jpg" }, 
                                        { "hart9.jpg", "klaveren9.jpg", "ruiten9.jpg", "schoppen9.jpg" }, 
                                        { "hart10.jpg", "klaveren10.jpg", "ruiten10.jpg", "schoppen10.jpg" }, 
                                        { "hartboer.jpg", "klaverenboer.jpg", "ruitenboer.jpg", "schoppenboer.jpg" }, 
                                        { "hartqueen.jpg", "klaverenqueen.jpg", "ruitenqueen.jpg", "schoppenqueen.jpg" }, 
                                        { "hartkoning.jpg", "klaverenkoning.jpg", "ruitenkoning.jpg", "schoppenkoning.jpg" } };
          // Zet elke kaart op standaardkaart  

          //kaart = Image.FromFile(@"D:\school\2e jaar\software engineering\Examen\BlackjackSE\BlackjackSE\bin\Debug\" + kaarten[0, 0]);
          
            // Maak een instantie van de random generator
            if (randomNummer == null)
            {
                randomNummer = new Random();
            }
        }

        /*
            Methode die een willekeurig getal berekent voor de kaart
        */
        public void ToonKaart()
        {
          
          do
          {
            arrayRow = randomNummer.Next(1, 14);
            
          } while (usedNumbersRow.Contains(arrayRow));

          usedNumbersRow.Add(arrayRow);

          
          arrayColumn = randomNummer.Next(0, 4);
         
         
          kaart = Image.FromFile(Path.Combine(Environment.CurrentDirectory, kaarten[arrayRow, arrayColumn]));
          ScoreOptellen();
          
        }

        public void ToonKaartNieuwSpel()
        {


          kaart = Image.FromFile(Path.Combine(Environment.CurrentDirectory, kaarten[0, 0]));

          nummerKaart = 0;
        }
      
        public int ScoreOptellen()
        {
          return nummerKaart += arrayRow;

        }
      

        /*
            Getter voor de waarde van de kaart
        */
        public int NummerKaart
        {
            get
            {
                return nummerKaart;
            }
            set
            {
              nummerKaart =  value;
            }
        }

      public Image Kaart
        {
            get
            {
              return kaart;
            }
        }
    }
}
