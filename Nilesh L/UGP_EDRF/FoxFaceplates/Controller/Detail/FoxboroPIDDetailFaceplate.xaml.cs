
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoxboroPIDDetailFaceplate.xaml.cs)" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for FoxboroPIDDetailFaceplate.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.FoxFaceplates.Controller.Detail
{
    using System.ComponentModel.Composition;

    [Export("FoxboroPIDDetailFaceplate")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FoxboroPIDDetailFaceplate
    {
        public FoxboroPIDDetailFaceplate()
        {
            this.InitializeComponent();
        }
    }
}