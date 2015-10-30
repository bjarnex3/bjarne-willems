using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackSE
{
    public partial class KaartView : UserControl
    {
        // member die de controller onthoudt
        private KaartenController controller;

        /*
            Constructor die de dependency injection van de controller opvangt
        */
        public KaartView(KaartenController kaartenController)
        {
            InitializeComponent();
            
            // Ken de controller injection toe aan de member
            controller = kaartenController;
        }

        /*
            Update de view met de nieuwe waarde van de teerling
        */
        public void updateUI()
        {
            picKaart.BackgroundImage = controller.Kaart;
            
        }

     

    }
}
