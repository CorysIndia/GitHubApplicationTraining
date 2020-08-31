// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TESTPAGE.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for TESTPAGE.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for TESTPAGE.xaml
    /// </summary>
    [Export("TESTPAGE")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class TESTPAGE
    {
        public TESTPAGE()
        {
            this.InitializeComponent();
        }
    }
}