// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CONTROLOIL_S2.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CONTROLOIL_S2.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for CONTROLOIL_S2.xaml
	/// </summary>
    [Export("CONTROLOIL_S2")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class CONTROLOIL_S2 
	{
		public CONTROLOIL_S2()
		{
			this.InitializeComponent();
		}
	}
}