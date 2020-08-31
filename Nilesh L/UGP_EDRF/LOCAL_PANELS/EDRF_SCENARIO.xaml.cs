// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EDRF_SCENARIO.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for EDRF_SCENARIO.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.LOCAL_PANELS
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for EDRF_SCENARIO.xaml
	/// </summary>
    [Export("EDRF_SCENARIO")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class EDRF_SCENARIO 
	{
		public EDRF_SCENARIO()
		{
			this.InitializeComponent();
		}
	}
}