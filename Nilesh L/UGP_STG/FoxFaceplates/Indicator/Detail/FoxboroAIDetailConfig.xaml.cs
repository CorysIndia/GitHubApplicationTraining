// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoxboroAIDetailConfig.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for FoxboroAIDetailConfig.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.FoxFaceplates.Indicator.Detail
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for FoxboroAIDetailConfig.xaml
    /// </summary>
    [Export("FoxboroAIDetailConfig")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FoxboroAIDetailConfig
    {
        public FoxboroAIDetailConfig()
        {
            this.InitializeComponent();
        }
    }
}