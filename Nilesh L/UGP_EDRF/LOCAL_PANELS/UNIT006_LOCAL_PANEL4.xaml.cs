// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UNIT006_LOCAL_PANEL4.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for UNIT006_LOCAL_PANEL4.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.LOCAL_PANELS
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for UNIT006_LOCAL_PANEL4.xaml
	/// </summary>
    [Export("UNIT006_LOCAL_PANEL4")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class UNIT006_LOCAL_PANEL4 
	{
		public UNIT006_LOCAL_PANEL4()
		{
			this.InitializeComponent();
		}
	}
}