// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoxboroPIDDetailCntrlBias.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for FoxboroPIDDetailCntrlBias.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.FoxFaceplates.Controller.Detail
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for FoxboroPIDDetailCntrlBias.xaml
    /// </summary>
    [Export("FoxboroPIDDetailCntrlBias")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FoxboroPIDDetailCntrlBias
    {
        public FoxboroPIDDetailCntrlBias()
        {
            this.InitializeComponent();
        }
    }
}