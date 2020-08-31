// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoxboroAIDetailAlarmTxt.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for FoxboroAIDetailAlarmTxt.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.FoxFaceplates.Indicator.Detail
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for FoxboroAIDetailAlarmTxt.xaml
    /// </summary>
    [Export("FoxboroAIDetailAlarmTxt")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FoxboroAIDetailAlarmTxt
    {
        public FoxboroAIDetailAlarmTxt()
        {
            this.InitializeComponent();
        }
    }
}