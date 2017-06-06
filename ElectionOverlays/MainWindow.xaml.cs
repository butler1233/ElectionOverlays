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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ElectionOverlays
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        internal RenderWindow render = null;

        public MainWindow()
        {
            InitializeComponent();
            render = new RenderWindow();
        }

        private void RenderToggle_Click(object sender, RoutedEventArgs e)
        {
            if (RenderToggle.IsChecked.Value)
            {
                render.Show();
            }
            else
            {
                render.Hide();
            }
        }

        private void Render_NormalButton_Click(object sender, RoutedEventArgs e)
        {
            render.WindowState = WindowState.Normal;
        }

        private void Render_MaximiseButton_Click(object sender, RoutedEventArgs e)
        {
            render.WindowState = WindowState.Maximized;
        }





        #region "Seatometers"
        private void ShowSpeedoButton_Click(object sender, RoutedEventArgs e)
        {
            render.Anim_ShowSpeedo();
        }

        private void HideSpeedoButton_Click(object sender, RoutedEventArgs e)
        {
            render.Anim_HideSpeedo();
        }

        //CON
        private void ConRem_Click(object sender, RoutedEventArgs e)
        {
            render.ConservativeSpeedo.SetSeats(render.ConservativeSpeedo.GetSeats() - 1);
            ConSeats.Text = render.ConservativeSpeedo.GetSeats().ToString();
        }
        private void ConAdd_Click(object sender, RoutedEventArgs e)
        {
            render.ConservativeSpeedo.SetSeats(render.ConservativeSpeedo.GetSeats() + 1);
            ConSeats.Text = render.ConservativeSpeedo.GetSeats().ToString();
        }
        private void ConSet_Click(object sender, RoutedEventArgs e)
        {
            render.ConservativeSpeedo.SetSeats(Convert.ToInt32(ConSeats.Text));
            ConSeats.Text = render.ConservativeSpeedo.GetSeats().ToString();
        }
        //LAB
        private void LabRem_Click(object sender, RoutedEventArgs e)
        {
            render.LabourSpeedo.SetSeats(render.LabourSpeedo.GetSeats() - 1);
            LabSeats.Text = render.LabourSpeedo.GetSeats().ToString();
        }
        private void LabAdd_Click(object sender, RoutedEventArgs e)
        {
            render.LabourSpeedo.SetSeats(render.LabourSpeedo.GetSeats() + 1);
            LabSeats.Text = render.LabourSpeedo.GetSeats().ToString();
        }
        private void LabSet_Click(object sender, RoutedEventArgs e)
        {
            render.LabourSpeedo.SetSeats(Convert.ToInt32(LabSeats.Text));
            LabSeats.Text = render.LabourSpeedo.GetSeats().ToString();
        }
        //LBDM
        private void LbdRem_Click(object sender, RoutedEventArgs e)
        {
            render.LibDemSpeedo.SetSeats(render.LibDemSpeedo.GetSeats() - 1);
            LibSeats.Text = render.LibDemSpeedo.GetSeats().ToString();
        }
        private void LbdAdd_Click(object sender, RoutedEventArgs e)
        {
            render.LibDemSpeedo.SetSeats(render.LibDemSpeedo.GetSeats() + 1);
            LibSeats.Text = render.LibDemSpeedo.GetSeats().ToString();
        }
        private void LbdSet_Click(object sender, RoutedEventArgs e)
        {
            render.LibDemSpeedo.SetSeats(Convert.ToInt32(LibSeats.Text));
            LibSeats.Text = render.LibDemSpeedo.GetSeats().ToString();
        }
        //Ukip
        private void UkipRem_Click(object sender, RoutedEventArgs e)
        {
            render.UkipSpeedo.SetSeats(render.UkipSpeedo.GetSeats() - 1);
            UkipSeats.Text = render.UkipSpeedo.GetSeats().ToString();
        }
        private void UkipAdd_Click(object sender, RoutedEventArgs e)
        {
            render.UkipSpeedo.SetSeats(render.UkipSpeedo.GetSeats() + 1);
            UkipSeats.Text = render.UkipSpeedo.GetSeats().ToString();
        }
        private void UkipSet_Click(object sender, RoutedEventArgs e)
        {
            render.UkipSpeedo.SetSeats(Convert.ToInt32(UkipSeats.Text));
            UkipSeats.Text = render.UkipSpeedo.GetSeats().ToString();
        }
        //SNP
        private void SnpRem_Click(object sender, RoutedEventArgs e)
        {
            render.SNPSpeedo.SetSeats(render.SNPSpeedo.GetSeats() - 1);
            SNPSeats.Text = render.SNPSpeedo.GetSeats().ToString();
        }
        private void SnpAdd_Click(object sender, RoutedEventArgs e)
        {
            render.SNPSpeedo.SetSeats(render.SNPSpeedo.GetSeats() + 1);
            SNPSeats.Text = render.SNPSpeedo.GetSeats().ToString();
        }
        private void SnpSet_Click(object sender, RoutedEventArgs e)
        {
            render.SNPSpeedo.SetSeats(Convert.ToInt32(SNPSeats.Text));
            SNPSeats.Text = render.SNPSpeedo.GetSeats().ToString();
        }
        //Other
        private void OthRem_Click(object sender, RoutedEventArgs e)
        {
            render.MiscSpeedo.SetSeats(render.MiscSpeedo.GetSeats() - 1);
            OthSeats.Text = render.MiscSpeedo.GetSeats().ToString();
        }
        private void OthAdd_Click(object sender, RoutedEventArgs e)
        {
            render.MiscSpeedo.SetSeats(render.MiscSpeedo.GetSeats() + 1);
            OthSeats.Text = render.MiscSpeedo.GetSeats().ToString();
        }
        private void OthSet_Click(object sender, RoutedEventArgs e)
        {
            render.MiscSpeedo.SetSeats(Convert.ToInt32(OthSeats.Text));
            OthSeats.Text = render.MiscSpeedo.GetSeats().ToString();
        }


        #endregion


    }
}
