// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CONTROLOIL_S1.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CONTROLOIL_S1.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for CONTROLOIL_S1.xaml
	/// </summary>
    [Export("CONTROLOIL_S1")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class CONTROLOIL_S1 
	{
		public CONTROLOIL_S1()
		{
			this.InitializeComponent();
		}
	}
}