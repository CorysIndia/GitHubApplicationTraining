// --------------------------------------------------------------------------------------------------------------------
// <copyright file="STG_TEST_PAD01.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for STG_TEST_PAD01.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.UGP_MIMICS
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for STG_TEST_PAD01.xaml
    /// </summary>
    [Export("STG_TEST_PAD01")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class STG_TEST_PAD01
    {
        public STG_TEST_PAD01()
        {
            this.InitializeComponent();
        }
    }
}