// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeScreen.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for HomeScreen.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RSIStandardEmulationApp1
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for HomeScreen.xaml
    /// </summary>
    [Export("HomeScreen")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class HomeScreen
    {
        public HomeScreen()
        {
            this.InitializeComponent();
        }
    }
}