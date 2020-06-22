// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AlarmScreen.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for AlarmScreen.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RSIStandardEmulationV1ToV3App1
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for AlarmScreen.xaml
    /// </summary>
    [Export("AlarmScreen")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class AlarmScreen
    {
        public AlarmScreen()
        {
            this.InitializeComponent();
        }
    }
}