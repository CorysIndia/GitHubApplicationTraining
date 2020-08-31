// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ESD_CONFIRMATION_SCREEN.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ESD_CONFIRMATION_SCREEN.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.Faceplates
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for ESD_CONFIRMATION_SCREEN.xaml
	/// </summary>
    [Export("ESD_CONFIRMATION_SCREEN")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class ESD_CONFIRMATION_SCREEN 
	{
		public ESD_CONFIRMATION_SCREEN()
		{
			this.InitializeComponent();
		}
	}
}