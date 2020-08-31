// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Trend2.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for Trend2.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.UGP_MIMICS
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for Trend2.xaml
	/// </summary>
    [Export("Trend2")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class Trend2 
	{
		public Trend2()
		{
			this.InitializeComponent();
		}
	}
}