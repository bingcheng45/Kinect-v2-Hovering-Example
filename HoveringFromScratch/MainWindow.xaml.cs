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
using Microsoft.Kinect.Toolkit.Input;
using Microsoft.Kinect.Wpf.Controls;
using Microsoft.Kinect;

namespace HoveringFromScratch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //hovering start
            KinectRegion.SetKinectRegion(this, kinectRegion);

            App app = ((App)Application.Current);
            app.KinectRegion = kinectRegion;

            // Use the default sensor
            this.kinectRegion.KinectSensor = KinectSensor.GetDefault();
            //hovering end
        }

        private void btnCenter_Click(object sender, RoutedEventArgs e)
        {
            lbtext.Content = "clicked";
        }

        private void btnCenter_MouseEnter(object sender, MouseEventArgs e)
        {
            btnCenter.Background = Brushes.ForestGreen;
            btnCenter.Content = "Mouse Entered!";
        }

        private void btnCenter_MouseLeave(object sender, MouseEventArgs e)
        {
            btnCenter.Background = Brushes.Gray;
            btnCenter.Content = "CLICK HERE";
        }

        private void btnCenter_TouchEnter(object sender, TouchEventArgs e)
        {
            btnCenter.Background = Brushes.Blue;
        }
    }
}
