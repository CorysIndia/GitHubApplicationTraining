// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoxboroPIDDetailOverride.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for FoxboroPIDDetailOverride.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.FoxFaceplates.Controller.Detail
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for FoxboroPIDDetailOverride.xaml
    /// </summary>
    [Export("FoxboroPIDDetailOverride")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FoxboroPIDDetailOverride
    {
        public FoxboroPIDDetailOverride()
        {
            this.InitializeComponent();
        }
    }
}