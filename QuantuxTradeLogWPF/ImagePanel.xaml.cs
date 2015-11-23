using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace QuantuxTradeLogWPF
{
    /// <summary>
    /// Interaction logic for ImagePanel.xaml
    /// </summary>
    public partial class ImagePanel : UserControl
    {

        public static DependencyProperty TextForeColorProperty;
        public static DependencyProperty LabelBackgroundProperty;

        public static DependencyProperty TextBoxContentProperty;

       // public static DependencyProperty ImageSourcePathProperty;

        public static DependencyProperty ImageHeightProperty;
        public static DependencyProperty ImageWidthProperty;
        public static DependencyProperty ImageVisibilityProperty;

        public static DependencyProperty TextBoxHeightProperty;
        public static DependencyProperty TextBoxWidthProperty;
        public static DependencyProperty TextBoxVisibilityProperty;

        public ImagePanel()
        {
            InitializeComponent();
            
        }

        static ImagePanel() 
        {

            TextBoxContentProperty = DependencyProperty.Register(
               "TextBoxContent", typeof(string), typeof(ImagePanel),
               new FrameworkPropertyMetadata(""));

            TextForeColorProperty = DependencyProperty.Register(
            "TextForeColor", typeof(Color), typeof(ImagePanel),
             new FrameworkPropertyMetadata((Color)ColorConverter.ConvertFromString("#00C8FF")));

            LabelBackgroundProperty = DependencyProperty.Register(
           "LabelBackground", typeof(Color), typeof(ImagePanel),
            new FrameworkPropertyMetadata((Color)ColorConverter.ConvertFromString("#00C8FF")));

            ImageHeightProperty = DependencyProperty.Register(
                 "ImageHeight", typeof(int), typeof(ImagePanel),
                 new FrameworkPropertyMetadata(200));

            ImageWidthProperty = DependencyProperty.Register(
                 "ImageWidth", typeof(int), typeof(ImagePanel),
                 new FrameworkPropertyMetadata(20));

            
            ImageVisibilityProperty = DependencyProperty.Register(
                 "ImageVisibility", typeof(bool), typeof(ImagePanel),
                 new FrameworkPropertyMetadata(true));
           
            TextBoxHeightProperty = DependencyProperty.Register(
                "TextBoxHeight", typeof(int), typeof(ImagePanel),
                new FrameworkPropertyMetadata(20));

           
            TextBoxWidthProperty = DependencyProperty.Register(
               "TextBoxWidth", typeof(int), typeof(ImagePanel),
               new FrameworkPropertyMetadata());

           
            TextBoxVisibilityProperty = DependencyProperty.Register(
              "TextBoxVisibility", typeof(bool), typeof(ImagePanel),
              new FrameworkPropertyMetadata(true));

            

           //ImageSourcePathProperty = DependencyProperty.Register("ImageSourcePath",
           //                    typeof(BitmapImage), typeof(ImagePanel),
           //                    new FrameworkPropertyMetadata(null,
           //                    FrameworkPropertyMetadataOptions.None));
   
        }

       

        public Color TextForeColor
        {
            get { return (Color)GetValue(TextForeColorProperty); }
            set { SetValue(TextForeColorProperty, value); }
        }

        public Color LabelBackground
        {
            get { return (Color)GetValue(LabelBackgroundProperty); }
            set { SetValue(LabelBackgroundProperty, value); }
        }

        public int ImageHeight
        {
            get { return (int)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }

        public int ImageWidth
        {
            get { return (int)GetValue(ImageWidthProperty); }
            set { SetValue(ImageWidthProperty, value); }
        }

        public int TextBoxHeight
        {
            get { return (int)GetValue(TextBoxHeightProperty); }
            set { SetValue(TextBoxHeightProperty, value); }
        }
       

        public int TextBoxWidth
        {
            get { return (int)GetValue(TextBoxWidthProperty); }
            set { SetValue(TextBoxWidthProperty, value); }
        }

        public string TextBoxContent
        {
            get { return (string)GetValue(TextBoxContentProperty); }
            set { SetValue(TextBoxContentProperty, value); }
        }

        public bool ImageVisibility
        {
            get { return (bool)GetValue(ImageVisibilityProperty); }
            set { SetValue(ImageVisibilityProperty, value); }
        }

        public bool TextBoxVisibility
        {
            get { return (bool)GetValue(TextBoxVisibilityProperty); }
            set { SetValue(TextBoxVisibilityProperty, value); }
        }

       //public BitmapImage ImageSourcePath
       //{
       //    get { return (BitmapImage)GetValue(ImageSourcePathProperty); }
       //    set { SetValue(ImageSourcePathProperty, value); }
       //}
		
    }

    /// <summary>
    /// Convert Color to string value
    /// </summary>
    public class ColorToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color color = (Color)value;
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class objectToImageSourceConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            string packUri = value.ToString();
            ImageSource Source = new ImageSourceConverter().ConvertFromString(packUri) as ImageSource;
            return Source;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class VisibilityConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool isChecked = bool.Parse(value.ToString());
            if (isChecked)
                return "Visible";
            else
                return "Collapsed";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var isChecked = value.ToString().ToLower() ;
            if (isChecked == "visible")
                return true;
            else
                return false;
        }
    }

    public class Ticker : INotifyPropertyChanged
    {
        public Ticker()
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second updates
            timer.Elapsed += timer_Elapsed;
            timer.Start();
        }

        public DateTime Now
        {
            get { return DateTime.Now; }
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("Now"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}





