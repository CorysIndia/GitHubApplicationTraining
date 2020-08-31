// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoxboroPIDFaceplate.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for FoxboroPIDFaceplate.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.FoxFaceplates.Controller
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for FoxboroPIDFaceplate.xaml
    /// </summary>
    [Export("FoxboroPIDFaceplate")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FoxboroPIDFaceplate
    {
        public FoxboroPIDFaceplate()
        {
            this.InitializeComponent();
        }
    }
}
