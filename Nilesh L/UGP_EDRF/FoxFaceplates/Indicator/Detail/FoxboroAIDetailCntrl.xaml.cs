// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoxboroAIDetailCntrl.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for FoxboroAIDetailCntrl.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.FoxFaceplates.Indicator.Detail
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for FoxboroAIDetailCntrl.xaml
    /// </summary>
    [Export("FoxboroAIDetailCntrl")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FoxboroAIDetailCntrl
    {
        public FoxboroAIDetailCntrl()
        {
            this.InitializeComponent();
        }
    }
}