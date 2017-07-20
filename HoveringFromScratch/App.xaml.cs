using System.Windows;
using Microsoft.Kinect.Wpf.Controls;

namespace HoveringFromScratch
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        ///<summary>
        /// Gets the app level KinectRegion element, 
        ///which is created in App.xaml.cs
        ///</summary>
        ///hovering added
        internal KinectRegion KinectRegion { get;  set; }
        
    }
}
