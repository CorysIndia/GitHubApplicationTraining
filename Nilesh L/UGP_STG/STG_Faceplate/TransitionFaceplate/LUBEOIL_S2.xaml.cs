// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LUBEOIL_S2.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for LUBEOIL_S2.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for LUBEOIL_S2.xaml
	/// </summary>
    [Export("LUBEOIL_S2")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class LUBEOIL_S2 
	{
		public LUBEOIL_S2()
		{
			this.InitializeComponent();
		}
	}
}