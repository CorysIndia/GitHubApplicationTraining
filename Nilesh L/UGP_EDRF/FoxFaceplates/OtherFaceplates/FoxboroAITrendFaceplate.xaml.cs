// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoxboroAITrendFaceplate.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for FoxboroAITrendFaceplate.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.ComponentModel.Composition;

namespace UGP_EDRF.FoxFaceplates.OtherFaceplates
{
    /// <summary>
    /// Interaction logic for FoxboroAITrendFaceplate.xaml
    /// </summary>
    [Export("FoxboroAITrendFaceplate")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FoxboroAITrendFaceplate
    {
        public FoxboroAITrendFaceplate()
        {
            this.InitializeComponent();
        }
    }
}