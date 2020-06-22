// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TrendScreen.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for TrendScreen.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RSIStandardEmulationV1ToV3App1
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for TrendScreen.xaml
    /// </summary>
    [Export("TrendScreen")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class TrendScreen
    {
        public TrendScreen()
        {
            this.InitializeComponent();
        }
    }
}