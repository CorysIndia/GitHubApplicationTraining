// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RUN_OFFFaceplate_COUT.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for RUN_OFFFaceplate_COUT.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_ERDF.Faceplate
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for RUN_OFFFaceplate_COUT.xaml
    /// </summary>
    [Export("RUN_OFFFaceplate_COUT")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class RUN_OFFFaceplate_COUT
    {
        public RUN_OFFFaceplate_COUT()
        {
            this.InitializeComponent();
        }
    }
}