// --------------------------------------------------------------------------------------------------------------------
// <copyright file="COOLING_NOT_COMPLETED01.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for COOLING_NOT_COMPLETED01.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.Faceplates
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for COOLING_NOT_COMPLETED01.xaml
	/// </summary>
    [Export("COOLING_NOT_COMPLETED01")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class COOLING_NOT_COMPLETED01 
	{
		public COOLING_NOT_COMPLETED01()
		{
			this.InitializeComponent();
		}
	}
}