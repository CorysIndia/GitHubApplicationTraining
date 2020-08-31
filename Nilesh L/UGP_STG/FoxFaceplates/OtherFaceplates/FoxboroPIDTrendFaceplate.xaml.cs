// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoxboroPIDTrendFaceplate.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for FoxboroPIDTrendFaceplate.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.ComponentModel.Composition;

namespace UGP_STG.FoxFaceplates.OtherFaceplates
{
    /// <summary>
    /// Interaction logic for FoxboroPIDTrendFaceplate.xaml
    /// </summary>
    [Export("FoxboroPIDTrendFaceplate")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FoxboroPIDTrendFaceplate
    {
        public FoxboroPIDTrendFaceplate()
        {
            this.InitializeComponent();
        }
    }
}