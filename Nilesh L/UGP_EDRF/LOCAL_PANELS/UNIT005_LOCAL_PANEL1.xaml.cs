// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UNIT005_LOCAL_PANEL1.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for UNIT005_LOCAL_PANEL1.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.LOCAL_PANELS
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for UNIT005_LOCAL_PANEL1.xaml
	/// </summary>
    [Export("UNIT005_LOCAL_PANEL1")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class UNIT005_LOCAL_PANEL1 
	{
		public UNIT005_LOCAL_PANEL1()
		{
			this.InitializeComponent();
		}
	}
}