using System.Windows.Controls;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System;
using New_EZexeat.Word;

namespace New_EZexeat
{
    /// <summary>
    /// A base page for all pages to gain base functionality
    /// </summary>

    public class BasePage : Page1
    {
        #region Public Properties

        /// <summary>
        /// The animation to play when the page first loads
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

        /// <summary>
        /// The animation to play when the page is unloaded
        /// </summary>
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

        /// <summary>
        /// The time any slide animation takes to complete
        /// </summary>
        public float SlideSeconds { get; set; } = 0.8f;

        #endregion

        #region constructor

        /// <summary>
        /// Default constructor
        /// </summary>

        public BasePage()
        {
            // If we are animating in, hide to begin with
            if (this.PageLoadAnimation != PageAnimation.None)
                this.Visibility = Visibility.Collapsed;

            // Listen out for the page loading
            this.Loaded += BasePage_Loaded;
        }


        #endregion


        #region Animation Load / Unload

        /// <summary>
        /// Once the page is loaded perform any required animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasePage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            // Animate the page in 
            await AnimateIn();
        }

        /// <summary>
        /// Animates in this page
        /// </summary>
        /// <returns></returns>

        public async Task AnimateIn()
        {
            // Make sure we have something to do
            if (this.PageLoadAnimation == PageAnimation.None)
                return;

            switch (this.PageLoadAnimation)
            {

                case PageAnimation.SlideAndFadeInFromRight:

                    var sb = new Storyboard();
                    var SlideAnimation = new ThicknessAnimation {
                        Duration = new Duration(TimeSpan.FromSeconds(this.SlideSeconds)),
                        From = new Thickness(this.WindowWidth, 0, -this.WindowWidth, 0),
                        To = new Thickness(0),
                        DecelerationRatio = 0.9f
                    };
                    Storyboard.SetTargetProperty(SlideAnimation, new PropertyPath("Margin"));
                    sb.Children.Add(SlideAnimation);

                    sb.Begin();

                    this.Visibility = Visibility.Visible;

                    await Task.Delay((int)(this.SlideSeconds * 100));

                    break;
            }
        }

        #endregion
    }
}
