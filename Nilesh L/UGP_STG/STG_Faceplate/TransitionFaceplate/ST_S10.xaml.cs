// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ST_S10.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ST_S10.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for ST_S10.xaml
    /// </summary>
    [Export("ST_S10")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ST_S10
    {
        public ST_S10()
        {
            this.InitializeComponent();
        }
    }
}