// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LUBEOIL_S6.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for LUBEOIL_S6.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for LUBEOIL_S6.xaml
	/// </summary>
    [Export("LUBEOIL_S6")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class LUBEOIL_S6 
	{
		public LUBEOIL_S6()
		{
			this.InitializeComponent();
		}
	}
}