// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LOCAL_PANEL3.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for LOCAL_PANEL3.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.LOCAL_PANEL
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for LOCAL_PANEL3.xaml
	/// </summary>
    [Export("LOCAL_PANEL3")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class LOCAL_PANEL3 
	{
		public LOCAL_PANEL3()
		{
			this.InitializeComponent();
		}
	}
}