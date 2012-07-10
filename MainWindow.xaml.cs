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

namespace FeedingEli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateFeeding(object sender, TextChangedEventArgs e)
        {
            int volume;
            int time;

            int.TryParse(Volume.Text, out volume);
            int.TryParse(Time.Text, out time);

            if (volume != 0 &&
                time != 0)
            {
                FeedRate.Content = Math.Round((decimal)(60 * volume) / time, 0, MidpointRounding.AwayFromZero).ToString("##,###,##0");
            }
            else
            {
                FeedRate.Content = "0";
            }

            FeedVTBD.Content = volume.ToString("##,###,##0");

        }

    }

}
