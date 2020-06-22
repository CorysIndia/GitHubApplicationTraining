// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProcessScreen.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ProcessScreen.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RSIStandardEmulationV1ToV3App1
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for ProcessScreen.xaml
    /// </summary>
    [Export("ProcessScreen")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ProcessScreen
    {
        public ProcessScreen()
        {
            this.InitializeComponent();
        }
    }
}