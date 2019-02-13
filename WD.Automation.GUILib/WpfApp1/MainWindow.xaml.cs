using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Blade1.IsEject = true;
            Blade1.IsConnect = true;
            Blade1.IsTeach = true;
            Blade1.Status = 2;


            Tray1.IsEject = true;
            Tray1.IsTeach = true;
            Tray1.TrayName = "TRAY 01";

            Picker1.HasSlider = true;
            Picker1.SliderSerialNumber = "sdfdsgferg";
            Picker1.LifeTime = 134424;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Blade1.IsEject = false;
            Blade1.IsConnect = false;
            Blade1.IsTeach = false;
            Blade1.Status = 1;


            Tray1.IsEject = false;
            Tray1.IsTeach = false;
            Tray1.TrayName = "TRAY 01";

            Picker1.HasSlider = false;
            Picker1.SliderSerialNumber = "AAAA";
            Picker1.LifeTime = 4545;
        }
    }
}
