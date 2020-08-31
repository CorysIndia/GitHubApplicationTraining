// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UGP_TEST_PAD.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for UGP_TEST_PAD.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.UGP_MIMICS
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for UGP_TEST_PAD.xaml
    /// </summary>
    [Export("UGP_TEST_PAD")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class UGP_TEST_PAD
    {
        public UGP_TEST_PAD()
        {
            this.InitializeComponent();
        }
    }
}