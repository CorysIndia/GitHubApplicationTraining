// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoxboroAIDetailAlarms.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for FoxboroAIDetailAlarms.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.FoxFaceplates.Indicator.Detail
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for FoxboroAIDetailAlarms.xaml
    /// </summary>
    [Export("FoxboroAIDetailAlarms")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FoxboroAIDetailAlarms
    {
        public FoxboroAIDetailAlarms()
        {
            this.InitializeComponent();
        }
    }
}