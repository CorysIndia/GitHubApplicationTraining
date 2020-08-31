// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoxboroPIDDetailTune.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for FoxboroPIDDetailTune.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.FoxFaceplates.Controller.Detail
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for FoxboroPIDDetailTune.xaml
    /// </summary>
    [Export("FoxboroPIDDetailTune")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FoxboroPIDDetailTune
    {
        public FoxboroPIDDetailTune()
        {
            this.InitializeComponent();
        }
    }
}