// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LUBEOIL_S51.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for LUBEOIL_S51.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for LUBEOIL_S51.xaml
	/// </summary>
    [Export("LUBEOIL_S51")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class LUBEOIL_S51 
	{
		public LUBEOIL_S51()
		{
			this.InitializeComponent();
		}
	}
}