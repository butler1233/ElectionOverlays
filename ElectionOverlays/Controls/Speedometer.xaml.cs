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
    /// Interaction logic for Speedometer.xaml
    /// </summary>
    public partial class Speedometer : UserControl
    {
        public Speedometer()
        {
            InitializeComponent();
        }

        int CurrentSeats = 0;

        public int GetSeats()
        {
            return CurrentSeats;
        }
        
        public void SetSeats(int seats)
        {
           
            Seats.Text = seats.ToString();

            Storyboard sb = new Storyboard();

            //vars
            double multiplier = ((double)180 / (double)480);
            double newangle = seats * multiplier;
            double oldangle = CurrentSeats * multiplier;
            TimeSpan duration = TimeSpan.FromMilliseconds(750);
            CurrentSeats = seats;
            
            //needletransform.BeginAnimation(RotateTransform.AngleProperty, animation);


            Storyboard storyboard = new Storyboard();

            RotateTransform scale = new RotateTransform(oldangle);
            Needle.RenderTransformOrigin = new Point(0.5, 0.5);
            Needle.RenderTransform = scale;

            DoubleAnimation growAnimation = new DoubleAnimation();
            growAnimation.Duration = duration;
            var ease = new CubicEase();
            ease.EasingMode = EasingMode.EaseOut;
            growAnimation.EasingFunction = ease;
            growAnimation.From = oldangle;
            growAnimation.To = newangle;
            storyboard.Children.Add(growAnimation);

            Storyboard.SetTargetProperty(growAnimation, new PropertyPath("RenderTransform.Angle"));
            Storyboard.SetTarget(growAnimation, Needle);

            storyboard.Begin();
            //scale.Angle = newangle;


        }

        public string PartyName
        {
            get
            {
                return PartyNameTB.Text;
            }
            set
            {
                PartyNameTB.Text = value;
            }

        }

        public Brush PartyColor
        {
            get
            {
                return SpeedBackgroundPanel.Background;
            }
            set
            {
                SpeedBackgroundPanel.Background = value;
            }

        }



    }

    
}
