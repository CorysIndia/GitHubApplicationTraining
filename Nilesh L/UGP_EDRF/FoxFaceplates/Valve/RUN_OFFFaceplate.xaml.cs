// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RUN_OFFFaceplate.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for RUN_OFFFaceplate.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_ERDF.Faceplate
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for RUN_OFFFaceplate.xaml
    /// </summary>
    [Export("RUN_OFFFaceplate")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class RUN_OFFFaceplate
    {
        public RUN_OFFFaceplate()
        {
            this.InitializeComponent();
        }
    }
}