using Microsoft.Kinect.Toolkit;
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

namespace kinectsample_usinginteractioncontrol
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        KinectSensorChooser sensorChooser;
        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            sensorChooser = new KinectSensorChooser(); 
            sensorChooser.KinectChanged +=sensorChooser_KinectChanged;
            sensorChooserUI.KinectSensorChooser = sensorChooser;
            sensorChooser.Start(); 
        }

        void sensorChooser_KinectChanged(object sender, KinectChangedEventArgs e)
        {
            if(e.NewSensor == null)
                Title = "找不到 Kinect感應器";
            else
                Title = "感應器狀態 : " + e.NewSensor.Status ;
                    
        }
    }
}
