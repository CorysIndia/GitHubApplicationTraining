// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UNIT003_LOCAL_PANEL2.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for UNIT003_LOCAL_PANEL2.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.LOCAL_PANELS
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for UNIT003_LOCAL_PANEL2.xaml
	/// </summary>
    [Export("UNIT003_LOCAL_PANEL2")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class UNIT003_LOCAL_PANEL2 
	{
		public UNIT003_LOCAL_PANEL2()
		{
			this.InitializeComponent();
		}
	}
}