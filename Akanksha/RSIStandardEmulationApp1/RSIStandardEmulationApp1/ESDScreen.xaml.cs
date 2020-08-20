// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ESDScreen.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ESDScreen.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RSIStandardEmulationApp1
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for ESDScreen.xaml
    /// </summary>
    [Export("ESDScreen")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ESDScreen
    {
        public ESDScreen()
        {
            this.InitializeComponent();
        }
    }
}