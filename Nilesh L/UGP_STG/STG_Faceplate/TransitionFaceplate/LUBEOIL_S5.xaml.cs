// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LUBEOIL_S5.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for LUBEOIL_S5.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for LUBEOIL_S5.xaml
	/// </summary>
    [Export("LUBEOIL_S5")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class LUBEOIL_S5 
	{
		public LUBEOIL_S5()
		{
			this.InitializeComponent();
		}
	}
}