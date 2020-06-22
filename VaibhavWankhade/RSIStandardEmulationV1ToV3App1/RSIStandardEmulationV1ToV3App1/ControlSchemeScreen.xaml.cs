// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ControlSchemeScreen.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ControlSchemeScreen.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RSIStandardEmulationV1ToV3App1
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for ControlSchemeScreen.xaml
    /// </summary>
    [Export("ControlSchemeScreen")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ControlSchemeScreen
    {
        public ControlSchemeScreen()
        {
            this.InitializeComponent();
        }
    }
}