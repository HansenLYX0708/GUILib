using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace GUILib
{
    public class PickerButton : Button
    {
        static PickerButton()
        {
            // Remove default property 
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PickerButton), new FrameworkPropertyMetadata(typeof(PickerButton)));
        }

        public PickerButton()
        {
            if (HasSlider)
            {
                Image = "/GUILib;component/Themes/Image/device_picker withtray.png";
            }
            else
            {
                Image = "/GUILib;component/Themes/Image/device_Picker withouttray.png";
            }
            LifeTimeStr = LifeTime.ToString();
        }
        #region 

        public string PickerName
        {
            get { return (string)GetValue(PickerNameProperty); }
            set { SetValue(PickerNameProperty, value); }
        }

        public static readonly DependencyProperty PickerNameProperty =
            DependencyProperty.Register("PickerName", typeof(string), typeof(PickerButton),
            new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.AffectsRender));

        public int Number
        {
            get { return (int)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        public static readonly DependencyProperty NumberProperty =
            DependencyProperty.Register("Number", typeof(int), typeof(PickerButton),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool HasSlider
        {
            get { return (bool)GetValue(HasSliderProperty); }
            set
            {
                bool tmp = value;
                if (tmp == true)
                {
                    Image = "/GUILib;component/Themes/Image/device_picker withtray.png";
                }
                else
                {
                    Image = "/GUILib;component/Themes/Image/device_Picker withouttray.png";
                }
                SetValue(HasSliderProperty, value);
            }
        }

        public static readonly DependencyProperty HasSliderProperty =
            DependencyProperty.Register("HasSlider", typeof(bool), typeof(PickerButton),
            new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsRender));

        public string Image
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(string), typeof(PickerButton),
            new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.AffectsRender, ImageSourceChanged));

        public string SliderSerialNumber
        {
            get { return (string)GetValue(SliderSerialNumberProperty); }
            set { SetValue(SliderSerialNumberProperty, value); }
        }

        public static readonly DependencyProperty SliderSerialNumberProperty =
            DependencyProperty.Register("SliderSerialNumber", typeof(string), typeof(PickerButton),
            new FrameworkPropertyMetadata("-----", FrameworkPropertyMetadataOptions.AffectsRender));

        public int LifeTime
        {
            get { return (int)GetValue(LifeTimeProperty); }
            set
            {
                LifeTimeStr = value.ToString();
                SetValue(LifeTimeProperty, value);
            }
        }

        public static readonly DependencyProperty LifeTimeProperty =
            DependencyProperty.Register("LifeTime", typeof(int), typeof(PickerButton),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender));

        public string LifeTimeStr
        {
            get { return (string)GetValue(LifeTimeStrProperty); }
            set { SetValue(LifeTimeStrProperty, value); }
        }

        public static readonly DependencyProperty LifeTimeStrProperty =
            DependencyProperty.Register("LifeTimeStr", typeof(string), typeof(PickerButton),
            new FrameworkPropertyMetadata("-----", FrameworkPropertyMetadataOptions.AffectsRender));

        private static void ImageSourceChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            Application.GetResourceStream(new Uri("pack://application:,,," + (string)e.NewValue));
        }

        #endregion
    }
}
