// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Overview.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for Overview.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------


namespace UGP_STG
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for Overview.xaml
    /// </summary>
    [Export("Overview")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class Overview
    {
        public Overview()
        {
            this.InitializeComponent();
        }
    }
}