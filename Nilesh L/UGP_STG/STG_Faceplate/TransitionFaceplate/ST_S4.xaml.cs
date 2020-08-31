// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ST_S4.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ST_S4.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for ST_S4.xaml
    /// </summary>
    [Export("ST_S4")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ST_S4
    {
        public ST_S4()
        {
            this.InitializeComponent();
        }
    }
}