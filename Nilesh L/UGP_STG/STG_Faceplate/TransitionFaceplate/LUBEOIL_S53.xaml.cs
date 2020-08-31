// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LUBEOIL_S53.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for LUBEOIL_S53.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for LUBEOIL_S53.xaml
	/// </summary>
    [Export("LUBEOIL_S53")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class LUBEOIL_S53 
	{
		public LUBEOIL_S53()
		{
			this.InitializeComponent();
		}
	}
}