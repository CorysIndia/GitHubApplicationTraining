// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Trend3.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for Trend3.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.UGP_MIMICS
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for Trend3.xaml
	/// </summary>
    [Export("Trend3")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class Trend3 
	{
		public Trend3()
		{
			this.InitializeComponent();
		}
	}
}