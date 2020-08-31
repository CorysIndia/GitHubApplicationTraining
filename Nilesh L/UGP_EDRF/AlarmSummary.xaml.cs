// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AlarmSummary.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for AlarmSummary.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for AlarmSummary.xaml
    /// </summary>
    [Export("AlarmSummary")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class AlarmSummary
    {
        public AlarmSummary()
        {
            this.InitializeComponent();
        }
    }
}