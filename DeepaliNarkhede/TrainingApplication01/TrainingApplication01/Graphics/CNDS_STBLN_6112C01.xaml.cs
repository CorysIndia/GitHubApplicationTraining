// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CNDS_STBLN_6112C01.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CNDS_STBLN_6112C01.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TrainingApplication01.Graphics
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for CNDS_STBLN_6112C01.xaml
    /// </summary>
    [Export("CNDS_STBLN_6112C01")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class CNDS_STBLN_6112C01
    {
        public CNDS_STBLN_6112C01()
        {
            this.InitializeComponent();
        }
    }
}