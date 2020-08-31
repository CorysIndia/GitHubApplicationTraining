// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LUBEOIL_S4.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for LUBEOIL_S4.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for LUBEOIL_S4.xaml
	/// </summary>
    [Export("LUBEOIL_S4")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class LUBEOIL_S4 
	{
		public LUBEOIL_S4()
		{
			this.InitializeComponent();
		}
	}
}