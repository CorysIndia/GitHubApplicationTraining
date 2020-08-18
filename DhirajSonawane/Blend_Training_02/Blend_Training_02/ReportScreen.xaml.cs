// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportScreen.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ReportScreen.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blend_Training_02
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for ReportScreen.xaml
    /// </summary>
    [Export("ReportScreen")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ReportScreen
    {
        public ReportScreen()
        {
            this.InitializeComponent();
        }
    }
}