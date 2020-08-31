// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CONTROLOIL_S4.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CONTROLOIL_S4.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for CONTROLOIL_S4.xaml
	/// </summary>
    [Export("CONTROLOIL_S4")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class CONTROLOIL_S4 
	{
		public CONTROLOIL_S4()
		{
			this.InitializeComponent();
		}
	}
}