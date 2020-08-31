// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EDRFGraphic_Hierarchy3.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for EDRFGraphic_Hierarchy3.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.LOCAL_PANELS
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for EDRFGraphic_Hierarchy3.xaml
	/// </summary>
    [Export("EDRFGraphic_Hierarchy3")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class EDRFGraphic_Hierarchy3 
	{
		public EDRFGraphic_Hierarchy3()
		{
			this.InitializeComponent();
		}
	}
}