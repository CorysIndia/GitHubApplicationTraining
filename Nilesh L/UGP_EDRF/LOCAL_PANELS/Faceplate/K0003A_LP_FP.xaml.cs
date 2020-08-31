// --------------------------------------------------------------------------------------------------------------------
// <copyright file="K0003A_LP_FP.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for K0003A_LP_FP.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.LOCAL_PANELS.Faceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for K0003A_LP_FP.xaml
	/// </summary>
    [Export("K0003A_LP_FP")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class K0003A_LP_FP 
	{
		public K0003A_LP_FP()
		{
			this.InitializeComponent();
		}
	}
}