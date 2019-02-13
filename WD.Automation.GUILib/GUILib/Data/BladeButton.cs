using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace GUILib
{
    public class BladeButton : Button
    {
        static BladeButton()
        {
            // Remove default property 
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BladeButton), new FrameworkPropertyMetadata(typeof(BladeButton)));
        }

        public BladeButton()
        {
            if (IsEject)
            {
                Image = "/GUILib;component/Themes/Image/device_bladeon.png";
            }
            else
            {
                Image = "/GUILib;component/Themes/Image/device_bladeoff.png";
            }

            if (IsConnect)
            {
                ConnectImage = "/GUILib;component/Themes/Image/status_bladeconnect.png";
            }
            else
            {
                ConnectImage = "/GUILib;component/Themes/Image/status_bladedisconnect.png";
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

        public string BladeName
        {
            get { return (string)GetValue(BladeNameProperty); }
            set { SetValue(BladeNameProperty, value); }
        }

        public static readonly DependencyProperty BladeNameProperty =
            DependencyProperty.Register("BladeName", typeof(string), typeof(BladeButton),
            new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.AffectsRender));

        public int Number
        {
            get { return (int)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        public static readonly DependencyProperty NumberProperty =
            DependencyProperty.Register("Number", typeof(int), typeof(BladeButton),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool IsEject
        {
            get { return (bool)GetValue(IsEjectProperty); }
            set
            {
                bool tmp = value;
                if (tmp == true)
                {
                    Image = "/GUILib;component/Themes/Image/device_bladeon.png";
                }
                else
                {
                    Image = "/GUILib;component/Themes/Image/device_bladeoff.png";
                }
                SetValue(IsEjectProperty, value);
            }
        }

        public static readonly DependencyProperty IsEjectProperty =
            DependencyProperty.Register("IsEject", typeof(bool), typeof(BladeButton),
            new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsRender));

        public string Image
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(string), typeof(BladeButton),
            new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.AffectsRender, ImageSourceChanged));

        

        public bool IsConnect
        {
            get { return (bool)GetValue(IsConnectProperty); }
            set
            {
                bool tmp = value;
                if (tmp == true)
                {
                    ConnectImage = "/GUILib;component/Themes/Image/status_bladeconnect.png";
                }
                else
                {
                    ConnectImage = "/GUILib;component/Themes/Image/status_bladedisconnect.png";
                }
                SetValue(IsConnectProperty, value);
            }
        }

        public static readonly DependencyProperty IsConnectProperty =
            DependencyProperty.Register("IsConnect", typeof(bool), typeof(BladeButton),
            new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsRender));

        public string ConnectImage
        {
            get { return (string)GetValue(ConnectImageProperty); }
            set { SetValue(ConnectImageProperty, value); }
        }

        public static readonly DependencyProperty ConnectImageProperty =
            DependencyProperty.Register("ConnectImage", typeof(string), typeof(BladeButton),
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
            DependencyProperty.Register("IsTeach", typeof(bool), typeof(BladeButton),
            new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsRender));

        public string TeachImage
        {
            get { return (string)GetValue(TeachImageProperty); }
            set { SetValue(TeachImageProperty, value); }
        }

        public static readonly DependencyProperty TeachImageProperty =
            DependencyProperty.Register("TeachImage", typeof(string), typeof(BladeButton),
            new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.AffectsRender, ImageSourceChanged));

        public int Status
        {
            get { return (int)GetValue(StatusProperty); }
            set
            {
                switch (value)
                {
                    case 1:
                        StatusColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF89C949"));
                        break;
                    case 2:
                        StatusColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFB1C30"));
                        break;
                    case 3:
                        StatusColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFBCC6CF"));
                        break;
                    case 4:
                        StatusColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F6B777"));
                        break;

                };
                SetValue(StatusProperty, value);
            }
        }

        public static readonly DependencyProperty StatusProperty =
            DependencyProperty.Register("Status", typeof(int), typeof(BladeButton),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender));

        public SolidColorBrush StatusColor
        {
            get { return (SolidColorBrush)GetValue(StatusColorProperty); }
            set { SetValue(StatusColorProperty, value); }
        }

        public static readonly DependencyProperty StatusColorProperty =
            DependencyProperty.Register("StatusColor", typeof(SolidColorBrush), typeof(BladeButton),
            new FrameworkPropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFBCC6CF")), FrameworkPropertyMetadataOptions.AffectsRender));

        private static void ImageSourceChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            Application.GetResourceStream(new Uri("pack://application:,,," + (string)e.NewValue));
        }

        #endregion
    }
}
