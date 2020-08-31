// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ESD_CONFIRMATION_SCREEN01.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ESD_CONFIRMATION_SCREEN01.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.Faceplates
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for ESD_CONFIRMATION_SCREEN01.xaml
	/// </summary>
    [Export("ESD_CONFIRMATION_SCREEN01")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class ESD_CONFIRMATION_SCREEN01 
	{
		public ESD_CONFIRMATION_SCREEN01()
		{
			this.InitializeComponent();
		}
	}
}