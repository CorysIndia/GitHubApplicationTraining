// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ESDScreen.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ESDScreen.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blend_Training_02
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