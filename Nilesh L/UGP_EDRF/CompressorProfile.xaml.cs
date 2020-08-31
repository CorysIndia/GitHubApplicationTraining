// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompressorProfile.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CompressorProfile.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CompressorProfileDemo
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for CompressorProfile.xaml
    /// </summary>
    [Export("CompressorProfile")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class CompressorProfile
    {
        public CompressorProfile()
        {
            this.InitializeComponent();
        }
    }
}