// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PumpFaceplate.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for PumpFaceplate.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TrainingApplication01.Faceplate
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for PumpFaceplate.xaml
    /// </summary>
    [Export("PumpFaceplate")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class PumpFaceplate
    {
        public PumpFaceplate()
        {
            this.InitializeComponent();
        }
    }
}