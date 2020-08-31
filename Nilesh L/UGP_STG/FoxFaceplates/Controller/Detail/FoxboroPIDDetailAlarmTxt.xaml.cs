// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoxboroPIDDetailAlarmTxt.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for FoxboroPIDDetailAlarmTxt.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.FoxFaceplates.Controller.Detail
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for FoxboroPIDDetailAlarmTxt.xaml
    /// </summary>
    [Export("FoxboroPIDDetailAlarmTxt")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FoxboroPIDDetailAlarmTxt
    {
        public FoxboroPIDDetailAlarmTxt()
        {
            this.InitializeComponent();
        }
    }
}