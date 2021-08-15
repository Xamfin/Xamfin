using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamfin.Controls;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Xamfin.Pages
{
    public partial class PlayerPage : ModalPage
    {
        public PlayerPage()
        {
            InitializeComponent();

            artwork.On<iOS>().UseBlurEffect(BlurEffectStyle.Dark);
        }
    }
}
