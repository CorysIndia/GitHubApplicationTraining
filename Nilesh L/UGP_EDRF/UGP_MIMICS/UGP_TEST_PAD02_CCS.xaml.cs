﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UGP_TEST_PAD02_CCS.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for UGP_TEST_PAD02_CCS.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.UGP_MIMICS
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for UGP_TEST_PAD02_CCS.xaml
    /// </summary>
    [Export("UGP_TEST_PAD02_CCS")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class UGP_TEST_PAD02_CCS
    {
        public UGP_TEST_PAD02_CCS()
        {
            this.InitializeComponent();
        }
    }
}