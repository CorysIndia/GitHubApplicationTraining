// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CNDS_STBLN_6112E02.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CNDS_STBLN_6112E02.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TrainingApplication01.Graphics
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for CNDS_STBLN_6112E02.xaml
    /// </summary>
    [Export("CNDS_STBLN_6112E02")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class CNDS_STBLN_6112E02
    {
        public CNDS_STBLN_6112E02()
        {
            this.InitializeComponent();
        }
    }
}