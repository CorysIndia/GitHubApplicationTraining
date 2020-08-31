// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HEATING_NOT_COMPLETED01.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for HEATING_NOT_COMPLETED01.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.Faceplates
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for HEATING_NOT_COMPLETED01.xaml
	/// </summary>
    [Export("HEATING_NOT_COMPLETED01")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class HEATING_NOT_COMPLETED01 
	{
		public HEATING_NOT_COMPLETED01()
		{
			this.InitializeComponent();
		}
	}
}