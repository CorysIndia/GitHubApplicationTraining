// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UGP_TEST_PAD01.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for UGP_TEST_PAD01.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.UGP_MIMICS
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for UGP_TEST_PAD01.xaml
    /// </summary>
    [Export("UGP_TEST_PAD01")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class UGP_TEST_PAD01
    {
        public UGP_TEST_PAD01()
        {
            this.InitializeComponent();
        }
    }
}