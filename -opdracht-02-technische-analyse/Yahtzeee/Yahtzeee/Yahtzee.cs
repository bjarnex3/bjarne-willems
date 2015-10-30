using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzeee
{
    public partial class Yahtzee : Form
    {
        int aantalTeerlingen = 5;
        int aantalWorpen = 0;
        int aantalMogelijkeWorpen = 3;

        List<TeerlingController> teerlingen = new List<TeerlingController>();

        public Yahtzee()
        {
            InitializeComponent();
        }

        private void Yahtzee_Load(object sender, EventArgs e)
        {
            

            //Teerlingen tonen
            for (int i = 0; i < aantalTeerlingen; i++)
            {
                //maakt instantie van teerlingcontroller
                TeerlingController tijdelijkeTeerling = new TeerlingController();
                teerlingen.Add(tijdelijkeTeerling);
            }

            //Teerlingen tonen
            for (int i = 0; i < aantalTeerlingen; i++)
            {
                //maakt instantie van teerlingcontroller
                TeerlingView teerlingView = teerlingen[i].getView();

                //Teerlingen naast elkaar plaatsen
                int horizontalPosition;
                horizontalPosition = i * teerlingView.Width;

                teerlingView.Location = new System.Drawing.Point(horizontalPosition, 0);
                Controls.Add(teerlingView);
            }         
        }

        private void btnWerpen_Click(object sender, EventArgs e)
        {
            aantalWorpen++;

            if (aantalWorpen <= aantalMogelijkeWorpen)
            {
                foreach (TeerlingController teerling in teerlingen)
                {
                    if (!teerling.IsVast)
                    {
                        // Voer een worp uit

                        teerling.Werp();

                        teerling.updateUI();
                    }
                }
            }
            
        }
    }
}
