// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ST_S3.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ST_S3.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for ST_S3.xaml
    /// </summary>
    [Export("ST_S3")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ST_S3
    {
        public ST_S3()
        {
            this.InitializeComponent();
        }
    }
}