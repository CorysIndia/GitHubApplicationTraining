// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CONTROLOIL_S51.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CONTROLOIL_S51.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for CONTROLOIL_S51.xaml
	/// </summary>
    [Export("CONTROLOIL_S51")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class CONTROLOIL_S51 
	{
		public CONTROLOIL_S51()
		{
			this.InitializeComponent();
		}
	}
}