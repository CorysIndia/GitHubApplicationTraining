// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ESDScreen.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ESDScreen.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TrainingApplication01
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