// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OverviewScreen.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for OverviewScreen.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Training01
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for OverviewScreen.xaml
    /// </summary>
    [Export("OverviewScreen")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class OverviewScreen
    {
        public OverviewScreen()
        {
            this.InitializeComponent();
        }
    }
}