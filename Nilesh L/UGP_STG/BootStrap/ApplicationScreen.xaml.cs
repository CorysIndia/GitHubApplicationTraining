// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationScreen.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ApplicationScreen.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.BootStrap
{
    using System.ComponentModel.Composition;
    using System.Windows;
    using RSI.Common.Locator;
    using RSI.IndissLike.Controls.Helpers;
    using RSI.IndissPlus.Solution;
    using RSI.OTS.HMI.Interfaces;

    /// <summary>
    /// Interaction logic for ApplicationScreen.xaml
    /// </summary>
    [Export("ApplicationScreen")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ApplicationScreen
    {
        public ApplicationScreen()
        {
            this.InitializeComponent();
            this.Loaded += this.ApplicationScreen_Loaded;
        }

        /// <summary>
        /// Handles the Loaded event of the ApplicationScreen control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void ApplicationScreen_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Loaded -= this.ApplicationScreen_Loaded;
            var s = ServiceContext.ConfigurationService["RunTime"];
            s.AddToNotPersistedBag("NavigationPan");
            s.SetProperty("NavigationPan", this.NavigationPan);
            UIElement ui;
            ServiceLocator.Instance.ResolveType<IGraphicElementProvider>().TryGetGraphicElement("fake", out ui);

            // force Database service load
            if (LocatorService.DatabaseService == null)
            {
                return;
            }

        }
    }
}