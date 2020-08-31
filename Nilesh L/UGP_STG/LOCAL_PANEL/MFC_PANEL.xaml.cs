// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MFC_PANEL.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for MFC_PANEL.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.LOCAL_PANEL
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for MFC_PANEL.xaml
	/// </summary>
    [Export("MFC_PANEL")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class MFC_PANEL 
	{
		public MFC_PANEL()
		{
			this.InitializeComponent();
		}
	}
}