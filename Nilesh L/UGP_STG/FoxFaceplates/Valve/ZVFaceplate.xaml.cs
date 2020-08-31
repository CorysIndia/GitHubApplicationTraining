// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ZVFaceplate.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ZVFaceplate.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_ERDF.Faceplate
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for ZVFaceplate.xaml
    /// </summary>
    [Export("ZVFaceplate")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ZVFaceplate
    {
        public ZVFaceplate()
        {
            this.InitializeComponent();
        }
    }
}