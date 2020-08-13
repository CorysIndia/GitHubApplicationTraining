// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Synoptic1.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for Synoptic1.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RSIStandardEmulationV1ToV3App1.Graphics
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for Synoptic1.xaml
    /// </summary>
    [Export("Synoptic1")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class Synoptic1
    {
        public Synoptic1()
        {
            this.InitializeComponent();
        }
    }
}