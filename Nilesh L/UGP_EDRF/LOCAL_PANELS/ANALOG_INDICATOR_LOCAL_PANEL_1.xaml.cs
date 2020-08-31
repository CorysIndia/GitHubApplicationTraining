// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ANALOG_INDICATOR_LOCAL_PANEL_1.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ANALOG_INDICATOR_LOCAL_PANEL_1.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.LOCAL_PANELS
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for ANALOG_INDICATOR_LOCAL_PANEL_1.xaml
	/// </summary>
    [Export("ANALOG_INDICATOR_LOCAL_PANEL_1")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class ANALOG_INDICATOR_LOCAL_PANEL_1 
	{
		public ANALOG_INDICATOR_LOCAL_PANEL_1()
		{
			this.InitializeComponent();
		}
	}
}