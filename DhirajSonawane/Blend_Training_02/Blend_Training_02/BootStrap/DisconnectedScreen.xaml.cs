// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DisconnectedScreen.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for DisconnectedScreen.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blend_Training_02.BootStrap
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for DisconnectedScreen.xaml
    /// </summary>
    [Export("DisconnectedScreen")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class DisconnectedScreen
    {
        public DisconnectedScreen()
        {
            this.InitializeComponent();
        }
    }
}