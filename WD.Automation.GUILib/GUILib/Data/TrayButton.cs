using System;
using System.Windows;
using System.Windows.Controls;

namespace GUILib
{
    public class TrayButton : Button
    {
        static TrayButton()
        {
            // Remove default property 
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TrayButton), new FrameworkPropertyMetadata(typeof(TrayButton)));
        }

        public TrayButton()
        {
            if (IsEject)
            {
                Image = "/GUILib;component/Themes/Image/device_trayon.png";
            }
            else
            {
                Image = "/GUILib;component/Themes/Image/device_trayoff.png";
            }

            if (IsTeach)
            {
                TeachImage = "/GUILib;component/Themes/Image/status_teach2.png";
            }
            else
            {
                TeachImage = "/GUILib;component/Themes/Image/status_teach.png";
            }

        }
        #region 

        public string TrayName
        {
            get { return (string)GetValue(TrayNameProperty); }
            set { SetValue(TrayNameProperty, value); }
        }

        public static readonly DependencyProperty TrayNameProperty =
            DependencyProperty.Register("TrayName", typeof(string), typeof(TrayButton),
            new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.AffectsRender));

        public int Number
        {
            get { return (int)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        public static readonly DependencyProperty NumberProperty =
            DependencyProperty.Register("Number", typeof(int), typeof(TrayButton),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool IsEject
        {
            get { return (bool)GetValue(IsEjectProperty); }
            set
            {
                bool tmp = value;
                if (tmp == true)
                {
                    Image = "/GUILib;component/Themes/Image/device_trayon.png";
                }
                else
                {
                    Image = "/GUILib;component/Themes/Image/device_trayoff.png";
                }
                SetValue(IsEjectProperty, value);
            }
        }

        public static readonly DependencyProperty IsEjectProperty =
            DependencyProperty.Register("IsEject", typeof(bool), typeof(TrayButton),
            new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsRender));

        public string Image
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(string), typeof(TrayButton),
            new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.AffectsRender, ImageSourceChanged));


        public bool IsTeach
        {
            get { return (bool)GetValue(IsTeachProperty); }
            set
            {
                bool tmp = value;
                if (tmp == true)
                {
                    TeachImage = "/GUILib;component/Themes/Image/status_teach2.png";
                }
                else
                {
                    TeachImage = "/GUILib;component/Themes/Image/status_teach.png";
                }
                SetValue(IsTeachProperty, value);
            }
        }

        public static readonly DependencyProperty IsTeachProperty =
            DependencyProperty.Register("IsTeach", typeof(bool), typeof(TrayButton),
            new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsRender));

        public string TeachImage
        {
            get { return (string)GetValue(TeachImageProperty); }
            set { SetValue(TeachImageProperty, value); }
        }

        public static readonly DependencyProperty TeachImageProperty =
            DependencyProperty.Register("TeachImage", typeof(string), typeof(TrayButton),
            new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.AffectsRender, ImageSourceChanged));

        private static void ImageSourceChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            Application.GetResourceStream(new Uri("pack://application:,,," + (string)e.NewValue));
        }

        #endregion
    }
}
