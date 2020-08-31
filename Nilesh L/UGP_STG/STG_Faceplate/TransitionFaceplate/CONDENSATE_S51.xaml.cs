// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CONDENSATE_S51.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CONDENSATE_S51.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for CONDENSATE_S51.xaml
    /// </summary>
    [Export("CONDENSATE_S51")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class CONDENSATE_S51
    {
        public CONDENSATE_S51()
        {
            this.InitializeComponent();
        }
    }
}