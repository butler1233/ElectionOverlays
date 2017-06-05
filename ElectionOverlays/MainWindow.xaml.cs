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



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            render.speedo1.SetSeats(Convert.ToInt32(SetTextbox.Text));
        }

        private void Rem1_Click(object sender, RoutedEventArgs e)
        {
            render.speedo1.SetSeats(render.speedo1.GetSeats() - 1);
        }

        private void Add1_Click(object sender, RoutedEventArgs e)
        {
            render.speedo1.SetSeats(render.speedo1.GetSeats() + 1);
        }


    }
}
