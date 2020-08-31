// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ST_S8.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ST_S8.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for ST_S8.xaml
    /// </summary>
    [Export("ST_S8")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ST_S8
    {
        public ST_S8()
        {
            this.InitializeComponent();
        }
    }
}