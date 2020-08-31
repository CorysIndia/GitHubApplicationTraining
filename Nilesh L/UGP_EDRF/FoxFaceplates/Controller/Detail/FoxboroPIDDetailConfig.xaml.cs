// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoxboroPIDDetailConfig.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for FoxboroPIDDetailConfig.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.FoxFaceplates.Controller.Detail
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for FoxboroPIDDetailConfig.xaml
    /// </summary>
    [Export("FoxboroPIDDetailConfig")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FoxboroPIDDetailConfig
    {
        public FoxboroPIDDetailConfig()
        {
            this.InitializeComponent();
        }
    }
}