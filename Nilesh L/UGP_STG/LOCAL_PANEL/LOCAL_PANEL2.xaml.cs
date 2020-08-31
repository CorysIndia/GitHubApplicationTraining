// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LOCAL_PANEL2.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for LOCAL_PANEL2.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.LOCAL_PANEL
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for LOCAL_PANEL2.xaml
    /// </summary>
    [Export("LOCAL_PANEL2")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class LOCAL_PANEL2
    {
        public LOCAL_PANEL2()
        {
            this.InitializeComponent();
        }
    }
}