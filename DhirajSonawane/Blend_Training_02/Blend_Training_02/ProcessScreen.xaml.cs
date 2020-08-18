// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProcessScreen.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ProcessScreen.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blend_Training_02
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