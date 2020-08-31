// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UGP_TEST_PAD03_CCS.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for UGP_TEST_PAD03_CCS.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.UGP_MIMICS
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for UGP_TEST_PAD03_CCS.xaml
	/// </summary>
    [Export("UGP_TEST_PAD03_CCS")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class UGP_TEST_PAD03_CCS 
	{
		public UGP_TEST_PAD03_CCS()
		{
			this.InitializeComponent();
		}
	}
}