// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CONTROLOIL_S53.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CONTROLOIL_S53.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for CONTROLOIL_S53.xaml
	/// </summary>
    [Export("CONTROLOIL_S53")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class CONTROLOIL_S53 
	{
		public CONTROLOIL_S53()
		{
			this.InitializeComponent();
		}
	}
}