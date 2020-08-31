// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoxboroPIDDetailCntrl.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for FoxboroPIDDetailCntrl.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.FoxFaceplates.Controller.Detail
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for FoxboroPIDDetailCntrl.xaml
    /// </summary>
    [Export("FoxboroPIDDetailCntrl")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FoxboroPIDDetailCntrl
    {
        public FoxboroPIDDetailCntrl()
        {
            this.InitializeComponent();
        }
    }
}