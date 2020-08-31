// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LUBEOIL_S7.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for LUBEOIL_S7.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for LUBEOIL_S7.xaml
	/// </summary>
    [Export("LUBEOIL_S7")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class LUBEOIL_S7 
	{
		public LUBEOIL_S7()
		{
			this.InitializeComponent();
		}
	}
}