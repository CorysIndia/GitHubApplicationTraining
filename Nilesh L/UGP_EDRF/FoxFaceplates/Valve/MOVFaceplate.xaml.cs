// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MOVFaceplate.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for MOVFaceplate.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_ERDF.Faceplate
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for MOVFaceplate.xaml
    /// </summary>
    [Export("MOVFaceplate")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class MOVFaceplate
    {
        public MOVFaceplate()
        {
            this.InitializeComponent();
        }
    }
}