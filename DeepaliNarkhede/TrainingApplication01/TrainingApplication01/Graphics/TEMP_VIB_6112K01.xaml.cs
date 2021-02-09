// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TEMP_VIB_6112K01.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for TEMP_VIB_6112K01.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TrainingApplication01.Graphics
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for TEMP_VIB_6112K01.xaml
    /// </summary>
    [Export("TEMP_VIB_6112K01")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class TEMP_VIB_6112K01
    {
        public TEMP_VIB_6112K01()
        {
            this.InitializeComponent();
        }
    }
}