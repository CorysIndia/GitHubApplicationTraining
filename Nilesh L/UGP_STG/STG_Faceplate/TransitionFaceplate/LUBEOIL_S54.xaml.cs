// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LUBEOIL_S54.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for LUBEOIL_S54.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for LUBEOIL_S54.xaml
	/// </summary>
    [Export("LUBEOIL_S54")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class LUBEOIL_S54 
	{
		public LUBEOIL_S54()
		{
			this.InitializeComponent();
		}
	}
}