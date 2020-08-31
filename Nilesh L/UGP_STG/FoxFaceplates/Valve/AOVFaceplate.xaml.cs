// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AOVFaceplate.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for AOVFaceplate.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_ERDF.Faceplate
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for AOVFaceplate.xaml
    /// </summary>
    [Export("AOVFaceplate")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class AOVFaceplate
    {
        public AOVFaceplate()
        {
            this.InitializeComponent();
        }
    }
}