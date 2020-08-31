// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EDRFGraphic_Hierarchy1.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for EDRFGraphic_Hierarchy1.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.LOCAL_PANELS
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for EDRFGraphic_Hierarchy1.xaml
	/// </summary>
    [Export("EDRFGraphic_Hierarchy1")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class EDRFGraphic_Hierarchy1 
	{
		public EDRFGraphic_Hierarchy1()
		{
			this.InitializeComponent();
		}
	}
}