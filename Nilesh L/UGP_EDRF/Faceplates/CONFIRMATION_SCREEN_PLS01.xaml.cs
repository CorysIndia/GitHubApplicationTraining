// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CONFIRMATION_SCREEN_PLS01.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CONFIRMATION_SCREEN_PLS01.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.Faceplates
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for CONFIRMATION_SCREEN_PLS01.xaml
	/// </summary>
    [Export("CONFIRMATION_SCREEN_PLS01")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class CONFIRMATION_SCREEN_PLS01 
	{
		public CONFIRMATION_SCREEN_PLS01()
		{
			this.InitializeComponent();
		}
	}
}