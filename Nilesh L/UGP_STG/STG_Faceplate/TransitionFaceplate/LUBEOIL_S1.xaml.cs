// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LUBEOIL_S1.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for LUBEOIL_S1.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for LUBEOIL_S1.xaml
	/// </summary>
    [Export("LUBEOIL_S1")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class LUBEOIL_S1 
	{
		public LUBEOIL_S1()
		{
			this.InitializeComponent();
		}
	}
}