using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzeee
{
    
    public partial class TeerlingView : UserControl
    {

        private TeerlingController controller;
        public TeerlingView( TeerlingController c)
        {
            InitializeComponent();

            controller = c;
        }

        private void btnWerpen_Click(object sender, EventArgs e)
        {
            //if (!controller.IsVast)
            //{
            //    // Voer een worp uit
            //    controller.Werp();

            //}

            //int nieuwAantalOgen = controller.model.AantalOgen;
            
            
        }
        
        public void updateUI()
        {
            lblTeerlingView1.Text = controller.model.teerlingTekst;
        }

        private void lblTeerlingView1_Click(object sender, EventArgs e)
        {
            controller.TurnVast();
            if (controller.IsVast)
            {
                lblTeerlingView1.BackColor = Color.Red;
            }
            else
            {
                lblTeerlingView1.BackColor = Color.LightGray;
            }
            
        }
    }
}
