// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LUBEOIL_S52.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for LUBEOIL_S52.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for LUBEOIL_S52.xaml
	/// </summary>
    [Export("LUBEOIL_S52")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class LUBEOIL_S52 
	{
		public LUBEOIL_S52()
		{
			this.InitializeComponent();
		}
	}
}