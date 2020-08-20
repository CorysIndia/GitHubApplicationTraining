// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProfileScreen.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ProfileScreen.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RSIStandardEmulationApp1
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for ProfileScreen.xaml
    /// </summary>
    [Export("ProfileScreen")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ProfileScreen
    {
        public ProfileScreen()
        {
            this.InitializeComponent();
        }
    }
}