// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoxboroAIFaceplate.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for FoxboroAIFaceplate.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.FoxFaceplates.Indicator
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for FoxboroAIFaceplate.xaml
    /// </summary>
    [Export("FoxboroAIFaceplate")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FoxboroAIFaceplate
    {
        public FoxboroAIFaceplate()
        {
            this.InitializeComponent();
        }
    }
}
