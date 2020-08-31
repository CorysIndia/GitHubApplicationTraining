// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoxboroPIDDetailAlarms.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for FoxboroPIDDetailAlarms.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.FoxFaceplates.Controller.Detail
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for FoxboroPIDDetailAlarms.xaml
    /// </summary>
    [Export("FoxboroPIDDetailAlarms")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FoxboroPIDDetailAlarms
    {
        public FoxboroPIDDetailAlarms()
        {
            this.InitializeComponent();
        }
    }
}