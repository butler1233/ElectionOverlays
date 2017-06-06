using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ElectionOverlays.Controls
{
    /// <summary>
    /// Interaction logic for DeclarationControl.xaml
    /// </summary>
    public partial class DeclarationControl : UserControl
    {
        public DeclarationControl()
        {
            InitializeComponent();
        }

        public Color OldPartyColor
        {
            get
            {
                return OldPartyGradStop.Color;
            }
            set
            {
                OldPartyGradStop.Color = value;
            }
        }

        public String Constituency
        {
            get
            {
                return Constit.Text;
            }
            set
            {
                Constit.Text = value;
                var sb = (Storyboard)this.FindResource("SlideIn");
                sb.Begin();
            }
        }

        private void Transition()
        {
            var sb = (Storyboard)this.FindResource("PartyTransition");
            sb.Begin();
        }
         
        internal void Declare(string Declaration, Color NewPartyColor)
        {
            DeclarationInfo.Text = Declaration;
            NewPartyGradStop.Color = NewPartyColor;
            Transition();
        }

    }
}
