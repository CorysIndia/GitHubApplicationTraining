// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EDRFGraphic_Hierarchy2.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for EDRFGraphic_Hierarchy2.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.LOCAL_PANELS
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for EDRFGraphic_Hierarchy2.xaml
	/// </summary>
    [Export("EDRFGraphic_Hierarchy2")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class EDRFGraphic_Hierarchy2 
	{
		public EDRFGraphic_Hierarchy2()
		{
			this.InitializeComponent();
		}
	}
}