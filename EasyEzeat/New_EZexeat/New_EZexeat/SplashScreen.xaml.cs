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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace New_EZexeat
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        DispatcherTimer dT = new DispatcherTimer();

        public SplashScreen()
        {
            InitializeComponent();

            dT.Tick += new EventHandler(dt_Tick);
            dT.Interval = new TimeSpan(0, 0, 8);
            dT.Start();

            loadprogressbar();
        }

        private void loadprogressbar()
        {
            Duration dur = new Duration(TimeSpan.FromSeconds(5));
            DoubleAnimation dblani = new DoubleAnimation(200.0, dur);
            progress.BeginAnimation(ProgressBar.ValueProperty, dblani);
        }

        private void dt_Tick(object sender, EventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();

            dT.Stop();
            this.Close();
        }
    }
}
