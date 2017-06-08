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
using System.Windows.Shapes;

namespace ElectionOverlays
{
    /// <summary>
    /// Interaction logic for RenderWindow.xaml
    /// </summary>
    public partial class RenderWindow : Window
    {
        public RenderWindow()
        {
            InitializeComponent();
        }

        private void StartStoryboard(string ResourceKey)
        {
            var sb = (Storyboard)this.FindResource(ResourceKey);
            sb.Begin();
        }


        internal void Anim_ShowSpeedo()
        {
            StartStoryboard("sbShowSpeedos");
        }
        internal void Anim_HideSpeedo()
        {
            StartStoryboard("sbHideSpeedos");
        }

        internal void Anim_ShowTicker()
        {
            StartStoryboard("TickerIn");
        }
        internal void Anim_HideTicker()
        {
            StartStoryboard("TickerOut");
        }


        public void SetZoom(double Zoom)
        {
            // For this code to work: add the Microsoft.mshtml .NET reference      
            mshtml.IHTMLDocument2 doc = Ticker.Document as mshtml.IHTMLDocument2;
            doc.parentWindow.execScript("document.body.style.zoom=" + Zoom.ToString().Replace(",", ".") + ";");
        }


    }
        
}
