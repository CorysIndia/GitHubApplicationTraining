// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LOCAL_PANEL1.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for LOCAL_PANEL1.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.LOCAL_PANEL
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for LOCAL_PANEL1.xaml
    /// </summary>
    [Export("LOCAL_PANEL1")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class LOCAL_PANEL1
    {
        public LOCAL_PANEL1()
        {
            this.InitializeComponent();
        }
    }
}